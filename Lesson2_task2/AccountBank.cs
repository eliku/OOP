using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_task2
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
        private static int _number;   //номер счета
        private int _balance;         //баланс
        private Type _type;

        public int number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        public int balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public Type type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public void inputAccount(int Balance, Type type)
        {
            _number++;
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
