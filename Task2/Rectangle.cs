using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle : Point
    {
        public Rectangle(Color color, bool state, int x, int y) : base(x, y)
        {

        }
        public double Square(Point point1, Point point2)
        {
            double dl1, dl2;
            dl1 = Math.Sqrt(Math.Pow((this.x - point1.x), 2) + Math.Pow((this.y - point1.y), 2));
            dl2 = Math.Sqrt(Math.Pow((this.x - point2.x), 2) + Math.Pow((this.y - point2.y), 2));
            return (dl1 * dl2);
        }
    }
}
