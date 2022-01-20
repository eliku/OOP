using System;
/*
 * Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах. 
 * Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode().
 * Переопределить методToString() для печати информации о счете. 
 * Протестировать функционирование переопределенных методов и операторов на простом примере.
 * 
 */

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountBant1 = new AccountBank(1, 123456, Type.Budget);
            var accountBant2 = new AccountBank(2, 123456, Type.Budget);
            Console.WriteLine(accountBant1.ToString());
            Console.WriteLine(accountBant2.ToString());
            Console.WriteLine(accountBant2.Equals(accountBant1));
            Console.WriteLine(accountBant1== accountBant2);
        }
    }
}
