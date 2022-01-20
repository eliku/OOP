using System;

namespace Task2
{
    class Program
    {
       

        static void Main(string[] args)
        {
            var figure1 = new Figure(Color.Black, true, 6, 8);

            figure1.MovedHorizontally(false, 5);
            Console.WriteLine(figure1.ToString());

            var point2 = new Point( 7, 8);
            var point3 = new Point(17, 5);

            var circleNew = new Circle(Color.Black, true, 2, 4);

            var rectangle = new Rectangle(Color.Black, true, 2, 4);

            Console.WriteLine(circleNew.Square(point2));
            Console.WriteLine(rectangle.Square(point2, point3));
        }
    }
}
