using System;

namespace Lesson2_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBank Bank = new AccountBank();
            Bank.number = 123;
            Bank.balance = 5;
            Bank.type = Type.Insured;
            Console.WriteLine(Bank.Info());

        }
    }
}
