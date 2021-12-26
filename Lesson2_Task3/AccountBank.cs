using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task3
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
        private Type _type;           //тип

        public AccountBank(int Balance)
        {
            _balance = Balance;
            _number++;
        }

        public AccountBank(Type types)
        {
            _type = types;
            _number++;
        }

        public AccountBank(int Balance, Type types)
        {
            _balance = Balance;
            _number++;
            _type = types;
        }
        public string Info()
        {
            string str = $"Номер счета {_number}, баланс {_balance}, тип счета {_type}";
            return str;
        }
    }
}
