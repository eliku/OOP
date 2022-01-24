using System;


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
                _y = value;
            }
        }

        public ConsWindows(int width, int heihgt, string title, ConsoleColor backСolor, ConsoleColor foreСolor)
        {
            Width = width;
            Height = heihgt;
            Title = title;
            BackColor = backСolor;
            ForeColor = foreСolor;

            Console.Clear();
        }

        //метод передвижение по консоле
        public void Position(int x, int y) 
        {
            X = x;
            Y = y;
            Console.SetCursorPosition(X, Y);
        }
    }
}
