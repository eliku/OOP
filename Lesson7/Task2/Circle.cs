using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Circle : Point, ISquare<Point>
    {
        public Circle(Color color, bool state, int x, int y) : base(x, y)
        {

        }
        public double Square(params Point[] Point)
        {
            return (Math.Pow(Math.Sqrt(Math.Pow((this.x - Point[0].x), 2) + Math.Pow((this.y - Point[0].y), 2)), 2) * Math.PI);
        }

    }
}
