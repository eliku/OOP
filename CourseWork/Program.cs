using System;
using System.Runtime.InteropServices;

namespace CourseWork
{
    class Program
    {
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_SIZE = 0xF000;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool EnableScrollBar(IntPtr hWnd, int wSBflags, int wArrows);

        static void Main(string[] args)
        {
            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);

            if (handle != IntPtr.Zero)
            {
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);

            }
            var ConsoleMain = new ConsWindows(120, 40, "File Manager", ConsoleColor.DarkBlue, ConsoleColor.White);

            //прорисовка экрана
            var lines = new Lines(1,0);
            lines.horizontal('_');
            // for (int i = 0; i< ConsoleMain.Height - 2; i++) Console.WriteLine(($"|{new string(' ', ConsoleMain.Width - 2)}|"));
            var lines2 = new Lines(1, ConsoleMain.Height - 2);
            lines2.horizontal('_');

            ConsoleMain.Position(0, 0);
            Console.Read();
        }

    }
}
