using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PuttyManager.Util
{
    public class WinApi
    {
        // declare the delegate
        public delegate bool WindowEnumDelegate(IntPtr hwnd, int lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow(IntPtr hWnd);

        //Экспортируем нужные Win32 функции
        [DllImport("User32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        // declare the API function to enumerate child windows
        [DllImport("user32.dll")]
        public static extern int EnumChildWindows(IntPtr hwnd, WindowEnumDelegate del, int lParam);

        // declare the API function to enumerate windows
        [DllImport("user32.dll")]
        public static extern int EnumWindows(WindowEnumDelegate del, int lParam);
        
        [DllImport("user32.dll")]
        public static extern int DestroyWindow(IntPtr hwnd);

        // declare the GetWindowText API function
        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hwnd, StringBuilder bld, int size);

        // declare the GetClassName API function
        [DllImport("user32.dll")]
        public static extern int GetClassName(IntPtr hwnd, StringBuilder bld, int size);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int WM_CLOSE = 0x0010;
        public const int WM_QUIT = 0x0012;
        public const int SC_CLOSE = 0xF060;

        /// <summary>
        /// Win32 API Constants for ShowWindowAsync()
        /// </summary>
        public const int SW_HIDE = 0;
        public const int SW_SHOWNORMAL = 1;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_RESTORE = 9;
        public const int SW_SHOWDEFAULT = 10;
    }
}