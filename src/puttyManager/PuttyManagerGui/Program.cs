using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PuttyManager.Domain;
using PuttyManager.Util;
using PuttyManager;
using PuttyManagerGui.Properties;

namespace PuttyManagerGui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
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

                var storedPwd = Settings.Default.EncryptedSettingsPassword;
                if (!(EncryptedSettings.EncryptedSourceExist &&
                      !string.IsNullOrWhiteSpace(storedPwd)  &&
                      EncryptedSettings.Initialize(storedPwd)))
                {
                    // Если файла нет || файл есть но нет сохраненного пасса || есть файл, пасс, но пасс не подошел
                    var pwdDlgMode = EncryptedSettings.EncryptedSourceExist
                                         ? PasswordDialog.EMode.RequestPassword
                                         : PasswordDialog.EMode.CreatePassword;
                    PasswordDialog pwdDlg;
                    do
                    {
                        pwdDlg = new PasswordDialog();
                        pwdDlg.Setup(pwdDlgMode);
                        var res = pwdDlg.ShowDialog();
                        if (res != DialogResult.OK)
                            return;
                    } while (!EncryptedSettings.Initialize(pwdDlg.Password));

                    Settings.Default.EncryptedSettingsPassword = pwdDlg.SavePassword ? pwdDlg.Password : "";
                    Settings.Default.Save();
                }

                Application.Run(new PuttyManagerForm());
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
