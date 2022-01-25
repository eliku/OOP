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

        public void ReadAndWrite()
        {
            foreach (string s in _array)
            {
                Console.SetCursorPosition(3, Console.CursorTop);
                Console.WriteLine(s.Replace(_name, ""));
                //list.Add(s.Replace(dirName, ""));
            }

        }
    }
}
