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
        }
    }
}
