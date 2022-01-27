using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Lines: ConsWindows
    {
        public Lines( int x, int y, ConsoleColor foreСolor) : base(x, y, foreСolor)
        {
            X = x;
            Y = y;
            Console.SetCursorPosition(X, Y);

        }
        //горизонтальная линия
        public void Horizontal(char symbol, int width)
        {
            Console.WriteLine($"{new string(symbol, width - 2)}");
        }

        //вертикальная линия
        public void Vertical(char symbol, int heiht)
        {
            for (int i = 0; i <= heiht - 2; i++)
            {
                Console.WriteLine(($"{symbol}"));
                this.Position(X, i+1);
            }
        }
    }
}
