using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    enum Type
    {
        Budget,
        Insured,
        Frozen,
        Contract,
        Correspondent,
        Savings
    };

    class AccountBank
    {
        private int _number;          //номер счета
        private int _balance;         //баланс
        private Type _type;

        public void inputAccount(int Number, int Balance, Type type)
        {
            _number = Number;
            _balance = Balance;
            _type = type;
        }
        public string Info()
        {
            string str = $"Номер счета {_number}, баланс {_balance}, тип счета {_type}";
            return str;
        }
    }
}
