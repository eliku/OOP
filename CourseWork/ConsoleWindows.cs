using System;


namespace CourseWork
{
    public class ConsoleWindows
    {
        private int _width;                //ширина окна
        private int _height;               //высота окна
         
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
    }
}
