using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    enum Color
    {
        White,
        Red,
        Blue,
        Black,
        orange,
        Green
    };

    abstract class Figure
    {
        private Color _color;        //цвет фигуры
        private bool _state;         //состояние: true - видимое/ false - невидимое»
        private int _x;              //координата X
        private int _y;              //координата Y

        public Color color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public bool state
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public int x
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

        public int y
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

        public Figure(Color color, bool state, int x, int y)
        {
            _color = color;
            _state = state;
            _x = x;
            _y = y;
        }

        public Figure(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Figure()
        {
        }
        public void MovedHorizontally(bool Up, int numberSteps)
        {
            if (numberSteps == 0) return;

            if (Up)
            {
                for (int i = 0; i < numberSteps; i++) this.x++;
            }
            else
            {
                for (int i = 0; i < numberSteps; i++) if (this.x != 0) this.x--;
            }
        }

        public void MovedVertical(bool Up, int numberSteps)
        {
            if (numberSteps == 0) return;

            if (Up)
            {
                for (int i = 0; i < numberSteps; i++) this.y++;
            }
            else
            {
                for (int i = 0; i < numberSteps; i++) if (this.y != 0) this.y--;
            }
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            string str = "не видимый";

            if (state == true) str = "видимый";

            return $"Фигура: Цвет {color}, состояние {str}, координаты ({x},{y})";
        }
    }
}
