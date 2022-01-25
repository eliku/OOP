using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class IsDirectory: ConsWindows
    {
        private string _name;
        private string[] _array;
        private string[] _files;

        public List<string> FolderList = new List<string>();


        public string Name 
        {
            get {
                return _name;
            }
            set {
                _name = value;

                if (Directory.Exists(_name))
                {
                    _array = Directory.GetDirectories(_name);
                    _files = Directory.GetFiles(_name);
                }

            }
        }

        public string[] Array
        {
            get
            {
                return _array;
            }
        }
        public IsDirectory(int x, int y, ConsoleColor foreСolor) : base(x, y, foreСolor)
        {
            X = x;
            Y = y;
            Console.SetCursorPosition(X, Y);
        }

        public void ReadAndWriteFolder(ConsoleColor color)
        {
            ForeColor = color;

            foreach (string s in _array)
            {
                this.Position(3, Y);
                Console.WriteLine(s.Replace(_name, ""));
                FolderList.Add(s.Replace(_name, ""));
                Y++;
            }

        }

        public void ReadAndWriteFile(ConsoleColor color)
        {
            ForeColor = color;

            foreach (string s in _files)
            {
                this.Position(3, Y);
                Console.WriteLine(s.Replace(_name, ""));
                FolderList.Add(s.Replace(_name, ""));
                Y++;
            }
        }
    }
}
