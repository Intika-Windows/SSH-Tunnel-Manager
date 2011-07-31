using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using PuttyManager.Business;

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

    public enum EConnectionState
    {
        Inactive,
        Intermediate,
        ActiveWithWarnings,
        Active
    }

    public interface IPuttyLink
    {
        HostInfo Host { get; }
        string LastStartError { get; }
        EConnectionState ConnectionState { get; }

        /// <summary>
        /// В случае, если процесс запущен асинхронно (методом AsyncStart), события будут срабатывать из асинхронного потока.
        /// Поэтому нужно продумать Threadsafe, для изменения состояния формы лучше использовать Control.BeginInvoke()
        /// </summary>
        event EventHandler ConnectionStateChanged;

        void AsyncStart();
        void Start();
        void Stop();
    }

    public class PuttyLink : IPuttyLink
    {
        private const string PlinkLocation = "plink.exe";
        private const string ShellStartedMessage = "Started a shell/command";

        private volatile Process _process;
        private volatile string _lastStartError;
        private volatile EConnectionState _connectionState = EConnectionState.Inactive;

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
                _lastStartError = value; // "Reads and writes of the following data types are atomic: bool, char, byte, sbyte, short, ushort, uint, int, float, and reference types."
            }
        }

        public EConnectionState ConnectionState
        {
            get { return _connectionState; }
            private set
            {
                _connectionState = value;
                Debug.WriteLine("Connection state changed, new state: {0}", ConnectionState);
                onConnectionStateChanged();
            }
        }

        /// <summary>
        /// В случае, если процесс запущен асинхронно (методом AsyncStart), события будут срабатывать из асинхронного потока.
        /// Поэтому нужно продумать Threadsafe, для изменения состояния формы лучше использовать Control.BeginInvoke()
        /// </summary>
        public event EventHandler ConnectionStateChanged;

        public Dictionary<TunnelInfo, ForwardingResult> ForwardingResults { get; private set; }

        private void onConnectionStateChanged()
        {
            if (ConnectionStateChanged != null)
                ConnectionStateChanged(this, EventArgs.Empty);
        }

        public void AsyncStart()
        {
            if (ConnectionState != EConnectionState.Inactive)
            {
                throw new InvalidOperationException("Link already started.");
            }
            Thread thread = new Thread(Start) {IsBackground = true};
            thread.Start();
        }

        public void Start()
        {
            if (ConnectionState != EConnectionState.Inactive)
            {
                throw new InvalidOperationException("Link already started.");
            }
            try
            {
                ConnectionState = EConnectionState.Intermediate;
                LastStartError = "";

                // fill results dic
                ForwardingResults = Host.Tunnels.ToDictionary(t => t, t => ForwardingResult.CreateSuccess());

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
                        char c = (char)_process.StandardOutput.Read();
                        buffer.Append(c);
                    }

                    _process.StandardOutput.DiscardBufferedData();
                    string data = buffer.ToString().ToLower();
                    buffer.Clear();

                    if (data.Contains("login as:"))
                    {
                        // Неверный логин
                        Stop();
                        // _process.StandardInput.WriteLine(username);
                        //throw new Exception("Invalid username.");
                        LastStartError = "Invalid username.";
                    }
                    else if (data.Contains("password:") && !passwordProvided)
                    {
                        _process.StandardInput.WriteLine(Host.Password);
                        passwordProvided = true;
                    }
                }
            }
            catch (Exception e)
            {
                LastStartError = e.Message;
                //Result = new PuttyLinkResult(false, e.Message);
                return;
            }
            finally
            {
                Debug.WriteLine("Plink: Stopped!");
                ConnectionState = EConnectionState.Inactive;
            }
            //Result = new PuttyLinkResult(true);
        }

        private void errorDataHandler(object o, DataReceivedEventArgs args)
        {
            if (args.Data == null)
                return;
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
                    ForwardingResults[tunnel] = ForwardingResult.CreateFailed(errorString);
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
                    ForwardingResults[tunnel] = ForwardingResult.CreateFailed(errorString);
                }
            }
            // Access denied error
            if (args.Data.Contains("Access denied"))
            {
                // Неверный пароль (Доступ запрещен)
                LastStartError = "Access Denied.";
                Stop();
            }
            // connection establishing
            if (args.Data.Contains(ShellStartedMessage))
            {
                ConnectionState = EConnectionState.Active;
            }
        }

        public void Stop()
        {
            if (ConnectionState == EConnectionState.Inactive)
                return;
            Debug.WriteLine("Plink: Stopping!");
            try
            {
                _process.Kill();
                Debug.WriteLine("Plink: Kill command!");
            }
            catch (Exception)
            {
            }
        }

        //public PuttyLinkResult Result { get; private set; }

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
