using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Circle : Point
    {
        public Circle(Color color, bool state, int x, int y) : base(x, y)
        {

        }
        public double Square(Point point1)
        {
            return (Math.Pow(Math.Sqrt(Math.Pow((this.x - point1.x),2) + Math.Pow((this.y - point1.y), 2)),2) * Math.PI);
        }
        
    }
}
