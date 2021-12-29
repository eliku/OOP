using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //первый счет
            AccountBank Bank1 = new AccountBank();

            Bank1.balance = 300;
            Bank1.type = Type.Savings;
            Bank1.number = 123;

            Console.WriteLine(Bank1.Info());

            //второй счет
            AccountBank Bank2 = new AccountBank();

            Bank2.balance = 460;
            Bank2.type = Type.Frozen;
            Bank2.number = 124;

            Console.WriteLine(Bank2.Info());

            Bank1.TransferMoney(Bank2, 23);
            Console.WriteLine(Bank1.Info());
            Console.WriteLine(Bank2.Info());

        }
    }
}
