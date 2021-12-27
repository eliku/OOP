using System;

namespace Lesson2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBank Bank1 = new AccountBank(123);
            Console.WriteLine(Bank1.Info());

            AccountBank Bank2 = new AccountBank(1, Type.Insured);
            Console.WriteLine(Bank2.Info());
        }
    }
}
