using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBank Bank = new AccountBank();
            Bank.inputAccount(145, 4, Type.Savings);
            Console.WriteLine(Bank.Info());
        }
    }
}
