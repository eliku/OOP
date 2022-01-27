using System;
using System.Configuration;
using System.Text;

namespace CourseWork
{
    public class ConsWindows
    {
        private int _width;                    //ширина окна
        private int _height;                   //высота окна
        private string _title;                 //заголовок консоли
        private ConsoleColor _backСolor;       //цвет фона консоли
        private ConsoleColor _foreСolor;       //цвет фона консоли
        //координаты точки
        private int _x;
        private int _y;
        private int _ySave;


        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.BufferWidth = _width;
                Console.WindowWidth = _width;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.BufferHeight = _height;
                Console.WindowHeight = _height;
            }

        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                Console.Title = _title;
            }
        }

        public ConsoleColor BackColor
        {
            get
            {
                return _backСolor;
            }
            set
            {
                _backСolor = value;
                Console.BackgroundColor = _backСolor;
            }
        }

        public ConsoleColor ForeColor
        {
            get
            {
                return _foreСolor;
            }
            set
            {
                _foreСolor = value;
                Console.ForegroundColor = _foreСolor;
            }
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value>=0)
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value >= 0 && value<Console.BufferHeight)
                _y = value;
            }
        }

        public int ySave
        {
            get
            {
                return _ySave;
            }
            set
            {
                if (value>0)
                _ySave = value;
            }
        }

        public ConsWindows(int width, int heihgt, string title, ConsoleColor backСolor, ConsoleColor foreСolor)
        {
            Width = width;
            Height = heihgt;
            Title = title;
            BackColor = backСolor;
            ForeColor = foreСolor;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
        }
        public ConsWindows(int x, int y, ConsoleColor foreColor)
        {
            X = x;
            Y = y;
            ForeColor = foreColor;
        }
        //метод передвижение по консоле
        public void Position(int x, int y) 
        {
            X = x;
            Y = y;
            Console.SetCursorPosition(X, Y);
        }

        public void SelectLine(int x, int y, ConsoleColor color, ConsoleColor frontColor,  string str)
        {
            BackColor = color;
            ForeColor = frontColor;
            this.Position(x, y);
            Console.WriteLine(str);
        }

        public void ScreenВrawing()
        {
            this.BackColor = ConsoleColor.DarkBlue;
            Console.Clear();
            //прорисовка экрана
            //горизонтальная 
            var lines0 = new Lines(1, 0, ConsoleColor.Blue);
            lines0.Horizontal('_', Width);
            //вертикальная
            var lines20 = new Lines(0, 1, ConsoleColor.Blue);
            lines20.Vertical('|', Height);
            //вертикальная
            var lines30 = new Lines(Width / 2, 1, ConsoleColor.Blue);
            lines30.Vertical('|', Height);
            //вертикальная
            var lines40 = new Lines(Width - 2, 1, ConsoleColor.Blue);
            lines40.Vertical('|', Height);
            //горизонтальная 
            var lines50 = new Lines(1, Height - 2, ConsoleColor.Blue);
            lines50.Horizontal('_', Width);
        }
    }
}
