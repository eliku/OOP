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

        public abstract Color color
        {
            get;
            set;
        }

        public abstract bool state
        {
            get;
            set;
        }

        public abstract int x
        {
            get;
            set;
        }

        public int y
        {
            get;
            set;
        }

        public Figure(Color color, bool state, int x, int y)
        {
            _color = this.color;
            _state = this.state;
            _x = this.x;
            _y = this.y;
        }

        public Figure(int x, int y)
        {
            _x = this.x;
            _y = this.y;
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
