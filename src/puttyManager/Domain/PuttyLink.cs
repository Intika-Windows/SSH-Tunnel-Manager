using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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

    public class PuttyLink
    {
        public enum EConnectionState
        {
            Inactive,
            Intermediate,
            Active
        }

        private const string PlinkLocation = "plink.exe";
        private const string ShellStartedMessage = "Started a shell/command";

        private volatile Process _process;
        private volatile string _lastError;
        private volatile EConnectionState _connectionState = EConnectionState.Inactive;

        public PuttyLink(HostInfo host)
        {
            if (host == null) throw new ArgumentNullException("host");
            Host = host;
        }

        public HostInfo Host { get; private set; }

        public string LastError
        {
            get { return _lastError; }
            private set
            {
                _lastError = value; // "Reads and writes of the following data types are atomic: bool, char, byte, sbyte, short, ushort, uint, int, float, and reference types."
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

        private void onConnectionStateChanged()
        {
            if (ConnectionStateChanged != null)
                ConnectionStateChanged(this, EventArgs.Empty);
        }

        public void AsyncStart()
        {
            Thread thread = new Thread(Start) {IsBackground = true};
            thread.Start();
        }

        public void Start()
        {
            try
            {
                ConnectionState = EConnectionState.Intermediate;

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

                _process.ErrorDataReceived += (o, args) =>
                    {
                        if (args.Data != null && args.Data.Contains(ShellStartedMessage))
                            ConnectionState = EConnectionState.Active;
                    };
                _process.Start();
                _process.BeginErrorReadLine();
                Debug.WriteLine("Plink: Started!");

                //_process.StandardInput.AutoFlush = true;

                var buffer = new StringBuilder();
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
                        LastError = "Invalid username.";
                    }
                    else if (data.Contains("password:"))
                    {
                        // Неверный пароль (Доступ запрещен)
                        Stop();
                        // _process.StandardInput.WriteLine(form.Password);
                        //throw new Exception("Access Denied.");
                        LastError = "Access Denied.";
                    }
                }
            }
            catch (Exception e)
            {
                LastError = e.Message;
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

        public void Stop()
        {
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

            var args = String.Format("-ssh {0}@{1} -P {2} -pw {3} -v", Host.Login, Host.Hostname, Host.Port, Host.Password);
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
}
