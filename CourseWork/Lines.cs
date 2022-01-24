using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Lines: ConsWindows
    {
        public Lines( int x, int y) : base(x, y)
        {

        }

        public void horizontal(char symbol)
        {
            Console.WriteLine($"{new string(symbol, Width - 2)}");
        }
    }
}
