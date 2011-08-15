using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SSHTunnelManager.Business;
using SSHTunnelManager.Domain;
using SSHTunnelManager.Util;
using SSHTunnelManagerGUI.Forms;
using SSHTunnelManagerGUI.Properties;
using log4net.Core;

namespace SSHTunnelManagerGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PuttyProfile.ReadProfile("_stm_preset_");
            /*var enc = CryptoHelper.EncryptStringAes("Hello, World!...", "qwerty7");
            var ret = CryptoHelper.DecryptStringAes(enc, "qwerty7");*/

            // We can run single instance only here based on Visual Studio
            // Project Settings. So initialize instance to null here.
            Process instance = null;

            // If we are supposed to, check to see if we are the only instance of this
            // program running.
            if (Settings.Default.StartSingleInstanceOnly)
                instance = RunningInstance();

            // If we are the only running instance of this program then continue.
            if (instance == null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var startUpDlg = new StartUpDialog();
                if (startUpDlg.DialogRequired && startUpDlg.ShowDialog() == DialogResult.Cancel)
                    return;

                // Apply config
                var cfg = new Config
                              {
                                  RestartEnabled = Settings.Default.Config_RestartEnabled,
                                  MaxAttemptsCount = Settings.Default.Config_MaxAttemptsCount,
                                  RestartDelay = Settings.Default.Config_RestartDelay
                              };
                Logger.SetThresholdForAppender("DelegateAppender", Settings.Default.Config_TraceDebug ? Level.Debug : Level.Info);

                var hm = new HostsManager<HostViewModel>(cfg, startUpDlg.Storage, startUpDlg.Filename, startUpDlg.Password);

                // changeSource request handling
                while (true)
                {
                    var mainForm = new MainForm(hm);
                    Application.Run(mainForm);

                    if (mainForm.ChangeSourceRequested)
                    {
                        startUpDlg = new StartUpDialog();
                        if (startUpDlg.ShowDialog() == DialogResult.Cancel)
                            return;
                        hm = new HostsManager<HostViewModel>(cfg, startUpDlg.Storage, startUpDlg.Filename, startUpDlg.Password);
                    } else
                    {
                        break;
                    }
                };
            }
            else
            {
                // We are not the only running instance of this program. So do this.
                HandleRunningInstance(instance);
            }
        }

        // Look at all currently runninng processes and see if there is already one of
        // us running with the name of TheNotifyIconExamplewc1.exe
        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);

            // Вернуть процесс с таким же названием и исполняемым файлом ИЛИ null
            return processes.Where(process => process.Id != current.Id).FirstOrDefault(process =>
                Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == process.MainModule.FileName);
        }

        // Bring to focus the current running process with our name
        // and we will go away without doing anything more.
        public static void HandleRunningInstance(Process instance)
        {
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL);
            SetForegroundWindow(instance.MainWindowHandle);
        }

        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private const int WS_SHOWNORMAL = 1;
    }
}
