using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle :Point, Square<Point>
    {
        public Rectangle(Color color, bool state, int x, int y) : base(x, y)
        {

        }

        double Square<Point>.Square(params Point[] Point)
        {
            double dl1, dl2;
            dl1 = Math.Sqrt(Math.Pow((this.x - Point[0].x), 2) + Math.Pow((this.y - Point[0].y), 2));
            dl2 = Math.Sqrt(Math.Pow((this.x - Point[1].x), 2) + Math.Pow((this.y - Point[1].y), 2));
            return (dl1 * dl2);
        }
    }
}
