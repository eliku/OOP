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
        private const int BEGIN_POSITION = 3;
        static string inputString;
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

            ConsoleMain.ScreenВrawing();

            var directoryNew = new IsDirectory(5,1,ConsoleColor.White);

            directoryNew.Name = null;
            directoryNew.Position(BEGIN_POSITION, ConsoleMain.Height - 1);
            ConsoleMain.ySave = BEGIN_POSITION;

            KeyEvent kevt = new KeyEvent();
            ConsoleKeyInfo key;

            kevt.KeyPress += (sender, e) =>
            {
                ConsoleMain.Position(ConsoleMain.X, ConsoleMain.Height - 1);
                Console.Write(e.ch);
                ConsoleMain.X++;
            };

            do
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow) 
                {
                    ConsoleMain.SelectLine(BEGIN_POSITION, ConsoleMain.ySave, ConsoleColor.DarkBlue, ConsoleColor.White, directoryNew.FolderList[ConsoleMain.ySave-1]);
                    ConsoleMain.ySave++;
                    ConsoleMain.SelectLine(BEGIN_POSITION, ConsoleMain.ySave, ConsoleColor.Gray, ConsoleColor.White, directoryNew.FolderList[ConsoleMain.ySave-1]);
                    inputString = "";
                    directoryNew.OutInfoDirectory(new DirectoryInfo(directoryNew.FolderList[ConsoleMain.ySave - 1]));
                }
                if (key.Key == ConsoleKey.UpArrow) 
                {
                    ConsoleMain.SelectLine(BEGIN_POSITION, ConsoleMain.ySave, ConsoleColor.DarkBlue, ConsoleColor.White, directoryNew.FolderList[ConsoleMain.ySave-1]);
                    ConsoleMain.ySave--;
                    ConsoleMain.SelectLine(BEGIN_POSITION, ConsoleMain.ySave, ConsoleColor.Gray, ConsoleColor.White, directoryNew.FolderList[ConsoleMain.ySave-1]);
                    inputString = "";
                    directoryNew.OutInfoDirectory(new DirectoryInfo(directoryNew.FolderList[ConsoleMain.ySave - 1]));
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    if (inputString == "\0")
                    {
                        ConsoleMain.ScreenВrawing();
                        directoryNew.Position(BEGIN_POSITION, 1);
                        directoryNew.Name = directoryNew.Name + directoryNew.FolderList[ConsoleMain.ySave - 1];                    
                        ConsoleMain.ySave = 0;                        
                    }
                    else {
                        if (inputString.IndexOf("cd") != -1)
                        {
                            directoryNew.Name = inputString.Substring("cd".Length, inputString.Length - 2);
                        }
                        //удаление файла и каталога
                        if (inputString.IndexOf("rm") != -1)
                        {
                            directoryNew.DelFiles();
                        }
                        //копирование каталога или файла
                        if (inputString.IndexOf("cp") != -1)
                        {
                            directoryNew.Copy();
                        }

                        inputString = "";
                    }
                }   
                ConsoleMain.BackColor = ConsoleColor.Black; ConsoleMain.ForeColor = ConsoleColor.White;
                if (inputString == "")
                {
                    Console.SetCursorPosition(0, ConsoleMain.Height-1);
                    Console.Write($"{new string(' ', ConsoleMain.Width)}");
                }
                inputString = inputString + key.KeyChar;
                kevt.OnKeyPress(key.KeyChar);
            } while (key.Key != ConsoleKey.Escape);

            Environment.Exit(0);
        }
    }
}
