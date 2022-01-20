using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
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

        public AccountBank(int Number, int Balance, Type typeAccount)
        {
            if (Number == 0) Console.WriteLine("Номер не существует");
            else _number = Number;
            _balance = Balance;
            _type = typeAccount;
        }

        //вывод информации о счете
        public string Info()
            {
                string str = $"Номер счета {_number}, баланс {_balance}, тип счета {_type}";
                return str;
            }

        //Определить оператор ==
        public static bool operator ==(AccountBank account1, AccountBank account2)
        {
            bool isaccount1IsNull = ReferenceEquals(account1, null);
            bool isaccount2IsNull = ReferenceEquals(account2, null);

            if (isaccount1IsNull == isaccount2IsNull && isaccount1IsNull == true) return true;

            return account1.balance == account2.balance && account1.type == account2.type;
        }

        //Определить оператор !=
        public static bool operator !=(AccountBank account1, AccountBank account2)
        {

            return account1.balance != account2.balance && account1.type != account2.type;
        }
        //Переопределить метод Equals
        public bool Equals(AccountBank obj)
        {
            bool areEqual = false;

            if (obj.number == this.number && obj.balance == this.balance && obj.type == this.type)
            {
                areEqual = true;
            }

            return areEqual;
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            if (_number == 0)
            {
                return "Счет не существует";
            }

            return $"Номер счета {_number}, баланс {_balance}, тип счета {_type}";
        }

    }
}
