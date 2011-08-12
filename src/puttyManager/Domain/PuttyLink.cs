using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using PuttyManager.Business;
using PuttyManager.Util;

namespace PuttyManager.Domain
{
    public class PuttyLinkResult
    {
        public PuttyLinkResult(bool success, string message = null)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; private set; }
        public string Message { get; private set; }
    }

    public enum ELinkStatus
    {
        Stopped,
        Starting,
        StartedWithWarnings,
        Started,
        Waiting
    }

    public interface IPuttyLink
    {
        HostInfo Host { get; }
        string LastStartError { get; }
        ELinkStatus LinkStatus { get; }
        Dictionary<TunnelInfo, ForwardingResult> ForwardingResults { get; }

        /// <summary>
        /// В случае, если процесс запущен асинхронно (методом AsyncStart), события будут срабатывать из асинхронного потока.
        /// Поэтому нужно продумать Threadsafe, для изменения состояния формы лучше использовать Control.BeginInvoke()
        /// </summary>
        event EventHandler ConnectionStateChanged;

        void AsyncStart();
        void Start();
        void Stop();
        bool WaitForStop(int seconds = 10);
        bool WaitForStart(int seconds = 20);
    }

    public class PuttyLink : IPuttyLink
    {
        private const string PlinkLocation = "plink.exe";
        private const string ShellStartedMessage = "Started a shell/command";

        private volatile Process _process;
        private volatile string _lastStartError;
        private volatile ELinkStatus _linkStatus = ELinkStatus.Stopped;
        private volatile bool _stopRequested;

        public PuttyLink(HostInfo host)
        {
            if (host == null) throw new ArgumentNullException("host");
            Host = host;
        }

        public HostInfo Host { get; private set; }

        public string LastStartError
        {
            get { return _lastStartError; }
            private set
            {
                if (value == _lastStartError)
                    return;
                _lastStartError = value; // "Reads and writes of the following data types are atomic: bool, char, byte, sbyte, short, ushort, uint, int, float, and reference types."
                if (!string.IsNullOrEmpty(value))
                {
                    Logger.Log.ErrorFormat("[{0}] {1}", Host.Name, value);
                }
            }
        }

        private readonly ManualResetEventSlim _eventStopped = new ManualResetEventSlim(true);
        private readonly ManualResetEventSlim _eventStarted = new ManualResetEventSlim(false);

        public ELinkStatus LinkStatus
        {
            get { return _linkStatus; }
            private set
            {
                if (_linkStatus == value)
                    return;

                if (_linkStatus == ELinkStatus.Stopped && value == ELinkStatus.Starting)
                    Logger.Log.InfoFormat("[{0}] {1}", Host.Name, "Starting...");
                else if (value == ELinkStatus.Started)
                    Logger.Log.InfoFormat("[{0}] {1}", Host.Name, "Started");
                else if (value == ELinkStatus.StartedWithWarnings)
                    Logger.Log.InfoFormat("[{0}] {1}", Host.Name, "Started with warnings");
                else if (value == ELinkStatus.Stopped)
                {
                    Logger.Log.InfoFormat("[{0}] {1}", Host.Name, "Stopped");
                }
                
                _linkStatus = value;
                onConnectionStateChanged();

                if (_linkStatus == ELinkStatus.Stopped)
                {
                    _eventStopped.Set();
                } else
                {
                    _eventStopped.Reset();
                }
                if (_linkStatus == ELinkStatus.Started || 
                    _linkStatus == ELinkStatus.StartedWithWarnings)
                {
                    _eventStarted.Set();
                } else
                {
                    _eventStarted.Reset();
                }
            }
        }

        /// <summary>
        /// В случае, если процесс запущен асинхронно (методом AsyncStart), события будут срабатывать из асинхронного потока.
        /// Поэтому нужно продумать Threadsafe, для изменения состояния формы лучше использовать Control.BeginInvoke()
        /// </summary>
        public event EventHandler ConnectionStateChanged;

        private Dictionary<TunnelInfo, ForwardingResult> _forwardingResults;
        private readonly object _forwardingResultsLock = new object();
        public Dictionary<TunnelInfo, ForwardingResult> ForwardingResults
        {
            get
            {
                lock (_forwardingResultsLock)
                {
                    return new Dictionary<TunnelInfo, ForwardingResult>(_forwardingResults);
                }
            }
        }

        private void onConnectionStateChanged()
        {
            if (ConnectionStateChanged != null)
                ConnectionStateChanged(this, EventArgs.Empty);
        }

        public void AsyncStart()
        {
            if (LinkStatus != ELinkStatus.Stopped)
            {
                throw new InvalidOperationException("Link already started.");
            }
            Thread thread = new Thread(Start) {IsBackground = true};
            thread.Start();
        }

        public void Start()
        {
            if (LinkStatus != ELinkStatus.Stopped)
            {
                throw new InvalidOperationException("Link already started.");
            }
            try
            {
                log4net.ThreadContext.Properties["Host"] = Host;
                _stopRequested = false;
                LastStartError = "";

                bool atleastOneSuccess = false;
                for (int i = 0; i < Host.MaxAttemptsCount; ++i)
                {
                    // At least one success for AutoRestart enabling.
                    // Do not restart if process stopped by Stop() method.
                    // Reset Attempts count if last attempt was successful.
                    LinkStatus = ELinkStatus.Starting;
                    var success = startOnce();
                    atleastOneSuccess = atleastOneSuccess || success;
                    if (_stopRequested || !atleastOneSuccess)
                        break;
                    if (success)
                        i = 0;
                    LinkStatus = ELinkStatus.Waiting;
                    Thread.Sleep(Host.RestartDelay * 1000);
                }
            }
            catch (Exception e)
            {
                LastStartError = e.Message;
                return;
            }
            finally
            {
                Debug.WriteLine("Plink: Stopped!");
                LinkStatus = ELinkStatus.Stopped;
            }
        }

        /// <summary>
        /// Start attemt to establish link once.
        /// </summary>
        /// <returns>Link was successfully started.</returns>
        private bool startOnce()
        {
            // fill results dic
            lock (_forwardingResultsLock)
            {
                _forwardingResults = Host.Tunnels.ToDictionary(t => t, t => ForwardingResult.CreateSuccess());
            }

            // Процесс
            _process = new Process
                           {
                               StartInfo =
                                   {
                                       FileName = PlinkLocation,
                                       CreateNoWindow = true,
                                       UseShellExecute = false,
                                       RedirectStandardError = true,
                                       RedirectStandardOutput = true,
                                       RedirectStandardInput = true,
                                       Arguments = arguments()
                                   }
                           };

            _process.ErrorDataReceived += errorDataHandler;
            _process.Start();
            _process.BeginErrorReadLine();
            Debug.WriteLine("Plink: Started!");

            //_process.StandardInput.AutoFlush = true;

            var buffer = new StringBuilder();
            bool passwordProvided = false;
            while (!_process.HasExited)
            {
                while (_process.StandardOutput.Peek() >= 0)
                {
                    char c = (char) _process.StandardOutput.Read();
                    buffer.Append(c);
                }

                _process.StandardOutput.DiscardBufferedData();
                string data = buffer.ToString().ToLower();
                buffer.Clear();

                if (data.Contains("login as:"))
                {
                    // invalid username provided
                    Stop();
                    // _process.StandardInput.WriteLine(username);
                    LastStartError = "Invalid username";
                }
                else if (data.Contains("password:") && !passwordProvided)
                {
                    _process.StandardInput.WriteLine(Host.Password);
                    passwordProvided = true;
                }
            }
            return LinkStatus == ELinkStatus.Started || 
                   LinkStatus == ELinkStatus.StartedWithWarnings;
        }

        private readonly StringBuilder _multilineError = new StringBuilder();

        private void errorDataHandler(object o, DataReceivedEventArgs args)
        {
            if (args.Data == null)
                return;
            log4net.ThreadContext.Properties["Host"] = Host; // Set up context for working thread
            // LOCAL tunnels error
            var m = Regex.Match(args.Data, @"Local port (?<srcPort>\d+) forwarding to (?<dstHost>[^:]+):(?<dstPort>\d+) failed: (?<errorString>.*)", RegexOptions.IgnoreCase);
            if (m.Success)
            {
                var srcPort = m.Groups["srcPort"].Value;
                var dstHost = m.Groups["dstHost"].Value;
                var dstPort = m.Groups["dstPort"].Value;
                var errorString = m.Groups["errorString"].Value;
                var tunnel = Host.Tunnels.FirstOrDefault(
                    t => t.LocalPort == srcPort && t.RemoteHostname == dstHost && t.RemotePort == dstPort && t.Type == TunnelType.Local);
                if (tunnel != null)
                {
                    lock (_forwardingResultsLock)
                    {
                        _forwardingResults[tunnel] = ForwardingResult.CreateFailed(errorString);
                    }
                    Logger.Log.WarnFormat("[{0}] [{1}] {2}", Host.Name, tunnel.SimpleString, errorString);
                }
            }
            // DYNAMIC tunnels error
            m = Regex.Match(args.Data, @"Local port (?<srcPort>\d+) SOCKS dynamic forwarding failed: (?<errorString>.*)", RegexOptions.IgnoreCase);
            if (m.Success)
            {
                var srcPort = m.Groups["srcPort"].Value;
                var errorString = m.Groups["errorString"].Value;
                var tunnel = Host.Tunnels.FirstOrDefault(
                    t => t.LocalPort == srcPort && t.Type == TunnelType.Dynamic);
                if (tunnel != null)
                {
                    lock (_forwardingResultsLock)
                    {
                        _forwardingResults[tunnel] = ForwardingResult.CreateFailed(errorString);
                    }
                    Logger.Log.WarnFormat("[{0}] [{1}] {2}", Host.Name, tunnel.SimpleString, errorString);
                }
            }
            // Unable to open connection:
            if (args.Data.Contains("Unable to open connection:"))
            {
                _multilineError.Append("Unable to open connection: ");
                return;
            }
            // Access denied error
            if (args.Data.Contains("Access denied"))
            {
                // Неверный пароль (Доступ запрещен)
                LastStartError = "Access Denied";
                Stop();
            }
            // Fatal errors
            m = Regex.Match(args.Data, @"^FATAL ERROR:\s*(?<msg>.*)$");
            if (m.Success)
            {
                LastStartError = m.Groups["msg"].Value;
            }
            // connection establishing
            if (args.Data.Contains(ShellStartedMessage))
            {
                bool forwardingFails;
                lock (_forwardingResultsLock)
                {
                    forwardingFails = _forwardingResults.Any(p => !p.Value.Success);
                }
                LinkStatus = forwardingFails ? ELinkStatus.StartedWithWarnings : ELinkStatus.Started;
            }
            // multiline error?
            if (_multilineError.Length > 0)
            {
                _multilineError.Append(args.Data);
                LastStartError = _multilineError.ToString();
                _multilineError.Clear();
                Stop();
            }
            log4net.ThreadContext.Properties["Host"] = null;
        }

        public void Stop()
        {
            if (LinkStatus == ELinkStatus.Stopped)
                return;
            Debug.WriteLine("Plink: Stopping!");
            try
            {
                _stopRequested = true;
                _process.Kill();
                _multilineError.Clear();
                Debug.WriteLine("Plink: Kill command!");
            }
            catch (Exception)
            {
            }
        }

        public bool WaitForStop(int seconds = 10)
        {
            return _eventStopped.Wait(seconds * 1000);
        }

        public bool WaitForStart(int seconds = 20)
        {
            return _eventStarted.Wait(seconds * 1000);
        }

        private string arguments()
        {
            // example: -ssh username@domainName -P 22 -pw password -D 5000 -L 44333:username.dyndns.org:44333

            //var args = String.Format("-ssh {0}@{1} -P {2} -pw {3} -v", Host.Username, Host.Hostname, Host.Port, Host.Password);
            var args = String.Format("-ssh {0}@{1} -P {2} -v", Host.Username, Host.Hostname, Host.Port);
            var sb = new StringBuilder(args);
            foreach (var tunnelArg in Host.Tunnels.Select(tunnelArguments))
            {
                sb.Append(tunnelArg);
            }

            args = sb.ToString();
            return args;
        }

        private static string tunnelArguments(TunnelInfo tunnel)
        {
            if (tunnel == null) throw new ArgumentNullException("tunnel");
            switch (tunnel.Type)
            {
                case TunnelType.Local:
                    return String.Format(@" -L {0}:{1}:{2}", tunnel.LocalPort, tunnel.RemoteHostname, tunnel.RemotePort);
                case TunnelType.Remote:
                    return String.Format(@" -R {0}:{1}:{2}", tunnel.LocalPort, tunnel.RemoteHostname, tunnel.RemotePort);
                case TunnelType.Dynamic:
                    return String.Format(@" -D {0}", tunnel.LocalPort);
                default:
                    throw new FormatException("Некорректный тип туннеля.");
            }
        }
    }

    public class ForwardingResult
    {
        private ForwardingResult(bool success, string errorString = null)
        {
            Success = success;
            ErrorString = errorString;
        }

        public static ForwardingResult CreateSuccess() { return new ForwardingResult(true); }
        public static ForwardingResult CreateFailed(string errorString) { return new ForwardingResult(false, errorString); }

        public bool Success { get; private set; }
        public string ErrorString { get; private set; }

        public override string ToString()
        {
            return Success ? "Succeed" : ErrorString;
        }
    }
}
