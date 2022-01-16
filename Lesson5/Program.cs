using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Comp1 = new ComplexNumber(1,2);

            var Comp2 = new ComplexNumber(3, 7);

            Console.WriteLine(Comp1.ToString());

            Console.WriteLine((Comp1+Comp2).ToString());

            Console.WriteLine((Comp1 * Comp2).ToString());
        }
    }
}
