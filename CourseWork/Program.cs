using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Threading;


namespace CourseWork
{
    class Program
    {
        static Configuration configFile;
        static KeyValueConfigurationCollection settings;
        static string dirName;
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
            //сохранение конфигурации
            configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            settings = configFile.AppSettings.Settings;

            if (settings["Direction"] == null)
            {
                settings.Add("Direction", "C:\\");
                dirName = "C:\\";
            }
            else
            {
                dirName = settings["Direction"].Value;
            }

            var ConsoleMain = new ConsWindows(120, 40, "File Manager", ConsoleColor.DarkBlue, ConsoleColor.White);

            //прорисовка экрана
            //горизонтальная 
            var lines = new Lines(1,0, ConsoleColor.Blue);            
            lines.Horizontal('_', ConsoleMain.Width);
            //вертикальная
            var lines2 = new Lines(0, 1, ConsoleColor.Blue);           
            lines2.Vertical('|', ConsoleMain.Height);
            //вертикальная
            var lines3 = new Lines(ConsoleMain.Width / 2, 1, ConsoleColor.Blue);
            lines3.Vertical('|', ConsoleMain.Height);
            //вертикальная
            var lines4 = new Lines(ConsoleMain.Width-2, 1, ConsoleColor.Blue);
            lines4.Vertical('|', ConsoleMain.Height);
            //горизонтальная 
            var lines5 = new Lines(1, ConsoleMain.Height - 2, ConsoleColor.Blue);   
            lines5.Horizontal('_', ConsoleMain.Width);
            ConsoleMain.Position(5, 0);

            

            Console.WriteLine(dirName);

            var directoryNew = new IsDirectory(5,1,ConsoleColor.White);
            directoryNew.Name = dirName;
            directoryNew.ReadAndWriteFolder(ConsoleColor.White);
            directoryNew.ReadAndWriteFile(ConsoleColor.Black);

            

            Console.Read();
        }
    }
}
