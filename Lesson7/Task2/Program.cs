using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            var point2 = new Point(7, 8);
            var point3 = new Point(17, 5);

            var circleNew = new Circle(Color.Black, true, 2, 4);

            var rectangle = new Rectangle(Color.Black, true, 2, 4);

            rectangle.MovedHorizontally(true, 2);

            Point[] points = { point2, point3};
            Console.WriteLine(circleNew.Square(point2));
            Console.WriteLine(rectangle.Square(point2, point3));

        }
    }
}
