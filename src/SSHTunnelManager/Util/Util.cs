using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace SSHTunnelManager.Util
{
    public class Helper
    {
        public static string JoinExceptionMessages(string sentence1, string sentence2)
        {
            var ret = String.Concat(Regex.Replace(sentence1, @"\.\s*$", ""), ". ", sentence2);
            return ret;
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int GetModuleFileName(IntPtr hModule, StringBuilder buffer, int length);

        private static string getLocalPath(string fileName)
        {
            Uri uri1 = new Uri(fileName);
            return (uri1.LocalPath + uri1.Fragment);
        }

        public static string GetExecutablePath()
        {
            string executablePath;
            Assembly assembly1 = Assembly.GetEntryAssembly();
            if (assembly1 == null)
            {
                StringBuilder builder1 = new StringBuilder(260);
                GetModuleFileName(IntPtr.Zero, builder1, builder1.Capacity);
                executablePath = Path.GetFullPath(builder1.ToString());
            }
            else
            {
                string text1 = assembly1.EscapedCodeBase;
                Uri uri1 = new Uri(text1);
                executablePath = uri1.Scheme == "file" 
                    ? getLocalPath(text1) 
                    : uri1.ToString();
            }

            Uri uri2 = new Uri(executablePath);
            if (uri2.Scheme == "file")
            {
                new System.Security.Permissions.FileIOPermission(System.Security.Permissions.FileIOPermissionAccess.PathDiscovery, executablePath).Demand();
            }
            return executablePath;
        }

        public static string StartupPath
        {
            get { return Path.GetDirectoryName(GetExecutablePath()); }
        }
    }
}
