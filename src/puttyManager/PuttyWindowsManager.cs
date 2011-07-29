using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using PuttyManager.Business;
using PuttyManager.Domain;
using PuttyManager.Util;

namespace PuttyManager
{
    public class PuttyWindowsManager
    {
        private const string PuttyClassName = "PuTTY";
        private static readonly string _puttyFullPath = Application.StartupPath + @"\putty.exe";

        public static void CreatePuttyInstance(HostInfo puttyInfo)
        {
            var psi = new ProcessStartInfo
                        {
                            FileName = _puttyFullPath,
                            Arguments = PuttyArguments(puttyInfo)
                        };
            var proc = Process.Start(psi);
            proc.WaitForInputIdle();
            var hwnd = proc.MainWindowHandle;
            WinApi.ShowWindowAsync(hwnd, WinApi.SW_HIDE);
        }

        public static void KillInactivePuttyWindows()
        {
            var puttyBadWindows = new List<IntPtr>();
            WinApi.EnumWindows(delegate(IntPtr childHwnd, int lparam)
                                   {
                                       var text = new PuttyWindow(childHwnd).Text;
                                       if (text == "PuTTY Fatal Error")
                                       {
                                           puttyBadWindows.Add(WinApi.GetParent(childHwnd));
                                       }
                                       return true;
                                   }, 0);
            killPutties(puttyBadWindows);
        }

        /// <summary>
        /// Определение есть ли такой путти в состоянии Good (определяется по имени машины и логину)
        /// </summary>
        /// <param name="puttyInfo"></param>
        /// <returns></returns>
        public static bool HasGoodPutty(HostInfo puttyInfo)
        {
            var lookedText = String.Format("{0}@{1}:", puttyInfo.Username, puttyInfo.MachineName);
            var anyGoodPutty = GetPuttyWindows().Any(pw => pw.Text.Contains(lookedText));
            return anyGoodPutty;
        }

        /// <summary>
        /// Определение есть ли такой путти в состоянии Strange (определяется по имени машины)
        /// </summary>
        /// <param name="hostInfo"></param>
        /// <returns></returns>
        public static bool HasStrangePutty(HostInfo hostInfo)
        {
            /*                                                    (string.Equals(pw.MachineName, HostInfo.MachineName, StringComparison.CurrentCultureIgnoreCase) ||
                                                     string.Equals(pw.MachineName, Environment.MachineName, StringComparison.CurrentCultureIgnoreCase) ||
                                                     string.Equals(pw.MachineName, "localhost", StringComparison.CurrentCultureIgnoreCase))*/
            var anyStrangePutty = GetPuttyWindows().Any(pw => pw.Strange && pw.InstanceInfo.Equals(hostInfo));
            return anyStrangePutty;
        }

        public static void KillAllPutties()
        {
            killPutties(GetPuttyWindows().Select(w => w.Hwnd));
        }

        public static void ShowAllPutties()
        {
            foreach (var wnd in GetPuttyWindows())
            {
                WinApi.ShowWindowAsync(wnd.Hwnd, WinApi.SW_SHOWNORMAL);
                WinApi.SetForegroundWindow(wnd.Hwnd);
            }
        }

        private static void killPutties(IEnumerable<IntPtr> hwnds)
        {
            foreach (var hwnd in hwnds)
            {
                new PuttyWindow(hwnd).Kill();
            }
        }

        public static IEnumerable<PuttyWindow> GetPuttyWindows()
        {
            var puttyWindows = new List<PuttyWindow>();
            WinApi.EnumWindows((hwnd, lParam) =>
                                   {
                                       var window = new PuttyWindow(hwnd);
                                       if (window.ClassName == PuttyClassName || window.Text == PuttyWindow.ConfigurationWindowText)
                                       {
                                           puttyWindows.Add(window);
                                       }
                                       return true;
                                   }, 0);
            return puttyWindows;
        }

        public static void AutoRecovery()
        {
            // Проходим по топологии, если можем - создаем инстанц. Все элементы иерархии должны иметь финальное состояние Good (не Strange).
            foreach (var hostData in EncryptedSettings.Instance.Hosts.Where(
                                        hostData => !HasGoodPutty(hostData) && !HasStrangePutty(hostData) &&
                                            (hostData.DependsOn == null || HasGoodPutty(hostData.DependsOn))))
            {
                CreatePuttyInstance(hostData);
            }
        }

        /// <summary>
        /// Парсинг командной строки с вычленением основным параметров соединения
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static HostInfo FromPuttyArguments(string args)
        {
            const string pattern = @"""[^""]+""\s+-ssh\s+(?<Username>[^@]+)@(?<Hostname>[^\s]+)\s+-P\s+(?<Port>\d+)\s+-pw\s+(?<Password>[^\s]+)";
            var m = Regex.Match(args, pattern);
            if (!m.Success)
                return null;

            var pid = new HostInfo
                          {
                              Username = m.Groups["Username"].Value,
                              Hostname = m.Groups["Hostname"].Value,
                              Port = m.Groups["Port"].Value,
                              Password = m.Groups["Password"].Value
                          };
            return pid;
        }

        public static string PuttyArguments(HostInfo host)
        {
            // example: -ssh username@domainName -P 22 -pw password -D 5000 -L 44333:username.dyndns.org:44333

            var args = String.Format("-ssh {0}@{1} -P {2} -pw {3}", host.Username, host.Hostname, host.Port, host.Password);
            var sb = new StringBuilder(args);
            foreach (var arg in host.Tunnels.Select(PuttyTunnelArguments))
            {
                sb.AppendFormat(" {0}", (object) arg);
            }
            args = sb.ToString();
            return args;
        }

        public static string PuttyTunnelArguments(TunnelInfo tunnel)
        {
            if (tunnel == null) throw new ArgumentNullException("tunnel");
            switch (tunnel.Type)
            {
            case TunnelType.Local:
                return String.Format(@"-L {0}:{1}:{2}", tunnel.LocalPort, tunnel.RemoteHostname, tunnel.RemotePort);
            case TunnelType.Remote:
                throw new NotImplementedException();
            case TunnelType.Dynamic:
                return String.Format(@"-D {0}", tunnel.LocalPort);
            default:
                throw new FormatException("Некорректный тип туннеля.");
            }
        }
    }
}