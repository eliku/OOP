using System;

namespace Lesson2_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBank Bank = new AccountBank();
            Console.WriteLine(Bank.Info());
            Bank.inputAccount( 4, Type.Budget);
            Console.WriteLine(Bank.Info());
            Bank.inputAccount(5, Type.Contract);
            Console.WriteLine(Bank.Info());
        }
    }
}
