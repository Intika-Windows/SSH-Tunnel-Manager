using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using SSHTunnelManager.Util;

namespace SSHTunnelManager.Domain
{
    [Obsolete(@"This is a part of early implementation of tunnel manager based on putty.exe. " +
              @"Classes are very unstable because of a lot of modification without testing and deprecated to use.")]
    public class PuttyWindow
    {
        public const string ConfigurationWindowText = "PuTTY Configuration";

        private const string StatusInactive = "Inactive";
        private const string StatusInactiveStrange = "Inactive, Strange";
        private const string StatusActive = "Active";
        private const string StatusActiveStrange = "Active, Strange";
        private const string StatusConfigurationWindow = "Configuration";

        //private HostInfo _instanceInfo;

        public PuttyWindow(IntPtr hwnd)
        {
            Hwnd = hwnd;
        }

        /*public HostInfo InstanceInfo
        {
            get
            {
                if (_instanceInfo == null)
                {
                    var instanceData = PuttyWindowsManager.FromPuttyArguments(ProcessCommandLine);
                    if (instanceData == null) 
                        return null;
                    //_instanceInfo = EncryptedSettings.Instance.Hosts.Find(instanceData.Equals) ?? instanceData; TODO
                }
                return _instanceInfo;
            }
        }*/

        public IntPtr Hwnd { get; private set; }
        public string Text { get { return getWindowText(Hwnd); } }
        public string ClassName { get { return getWindowClass(Hwnd); } }
        
        public string MachineName
        {
            get
            {
                string username, machineName;
                getData(out username, out machineName);
                return machineName;
            }
        }

        private bool getData(out string username, out string machineName)
        {
            username = "";
            machineName = "";
            // from Process arguments

            // regular
            var m = Regex.Match(Text, @"^(?<username>[^@]+)@(?<machineName>[^:]+):.*$");
            if (m.Success)
            {
                username = m.Groups["username"].Value;
                machineName = m.Groups["machineName"].Value;
                return true;
            }
            // strange
            m = Regex.Match(Text, @"^(?<machineName>[a-zA-Z0-9\-]+)([a-zA-Z0-9\-\.])* - PuTTY$");
            if (m.Success)
            {
                machineName = m.Groups["machineName"].Value;
                return true;
            }
            return false;
        }

        public Process Process
        {
            get
            {
                int pid;
                WinApi.GetWindowThreadProcessId(Hwnd, out pid);
                var proc = Process.GetProcessById(pid);
                return proc;
            }
        }

        public void Kill()
        {
            Process.Kill();
        }

        public string ProcessCommandLine
        {
            get
            {
                var results = new List<string>();
                var wmiQuery = string.Format(@"select CommandLine from Win32_Process where ProcessId='{0}'", Process.Id);

                using (var searcher = new ManagementObjectSearcher(wmiQuery))
                using (ManagementObjectCollection retObjectCollection = searcher.Get())
                {
                    results.AddRange(retObjectCollection.Cast<ManagementObject>().
                                         Select(retObject => (string) retObject[@"CommandLine"]));
                }

                var cmdArgs = results.FirstOrDefault();
                return cmdArgs ?? "";
            }
        }

        public bool Inactive
        {
            get
            {
                var iAmBad = false;
                WinApi.EnumWindows(delegate(IntPtr childHwnd, int lparam)
                                       {
                                           var text = new PuttyWindow(childHwnd).Text;
                                           if (text == @"PuTTY Fatal Error" && WinApi.GetParent(childHwnd) == Hwnd)
                                           {
                                               iAmBad = true;
                                           }
                                           return true;
                                       }, 0);
                return iAmBad;
            }
        }

        public bool Strange
        {
            get
            {
                var lookedPattern = string.Format(@"^[a-zA-Z0-9\-\.]+ - PuTTY$");
                var anyGoodPutty = Regex.IsMatch(Text, lookedPattern);
                return anyGoodPutty;
            }
        }

        public bool Configuration
        {
            get { return Text == ConfigurationWindowText; }
        }

        public string StatusText
        {
            get
            {
                return Inactive
                           ? (Strange ? StatusInactiveStrange : StatusInactive)
                           : (Strange 
                                  ? StatusActiveStrange
                                  : (Configuration ? StatusConfigurationWindow : StatusActive));
            }
        }

        public void Show()
        {
            WinApi.ShowWindowAsync(Hwnd, WinApi.SW_SHOWNORMAL);
            WinApi.SetForegroundWindow(Hwnd);
        }

        public void Hide()
        {
            WinApi.ShowWindowAsync(Hwnd, WinApi.SW_HIDE);
        }

        private static string getWindowText(IntPtr hwnd)
        {
            var sb = new StringBuilder(512);
            WinApi.GetWindowText(hwnd, sb, 512);
            return sb.ToString();
        }

        private static string getWindowClass(IntPtr hwnd)
        {
            var sb = new StringBuilder(512);
            WinApi.GetClassName(hwnd, sb, 512);
            return sb.ToString();
        }

        /*public override string ToString()
        {
            var pid = InstanceInfo;
            if (pid != null)
                return string.Format("{0}@{1}:{2}", pid.Username, pid.Hostname, pid.Port);
            return string.Format("Hwnd = {0}", Hwnd);
        }*/
    }
}