using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class RationalNumbers
    {
        private int _numerator;
        private int _denominator;

        public int numerator
        {
            get { return _numerator; }
            set { _numerator = value;}
        }

        public int denominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }

        public RationalNumbers(int Numerator, int Denominator)
        {
            if (Denominator == 0) Console.WriteLine("Знаменатель не может быть равен 0.");
            _numerator = Numerator;
            _denominator = Denominator;
        }

        //Определить оператор +
        public static RationalNumbers operator +(RationalNumbers rn1, RationalNumbers rn2)
        {
            return new RationalNumbers(rn1.numerator * rn2.denominator + rn2.numerator * rn1.denominator, rn1.denominator * rn2.denominator);
        }

        //Определить оператор -
        public static RationalNumbers operator -(RationalNumbers rn1, RationalNumbers rn2)
        {
            return new RationalNumbers(rn1.numerator * rn2.denominator - rn2.numerator * rn1.denominator, rn1.denominator * rn2.denominator);
        }

        //Определить оператор /
        public static RationalNumbers operator /(RationalNumbers rn1, RationalNumbers rn2)
        {
            return new RationalNumbers(rn1.numerator * rn2.denominator, rn1.denominator * rn2.numerator);
        }

        //Определить оператор ==
        public static bool operator ==(RationalNumbers rn1, RationalNumbers rn2)
        {
            bool isRn1IsNull = ReferenceEquals(rn1, null);
            bool isRn2IsNull = ReferenceEquals(rn2, null);

            if (isRn1IsNull == isRn2IsNull && isRn1IsNull == true) return true;

            return rn1.numerator == rn2.numerator && rn1.denominator == rn2.denominator;
        }

        //Определить оператор !=
        public static bool operator !=(RationalNumbers rn1, RationalNumbers rn2)
        {
            return rn1.numerator != rn2.numerator || rn1.denominator != rn2.denominator;
        }

        //Определить оператор ++
        public static RationalNumbers operator ++(RationalNumbers rn)
        {
            return new RationalNumbers(rn.numerator + rn.denominator, rn.denominator);
        }

        //Определить оператор --
        public static RationalNumbers operator --(RationalNumbers rn)
        {
            return new RationalNumbers(rn.numerator - rn.denominator, rn.denominator);
        }

        //Определить оператор сравнения >
        public static bool operator >(RationalNumbers rn1, RationalNumbers rn2)
        {
            if (rn1.denominator == rn2.denominator)
            {
                return rn1.numerator > rn2.numerator;
            }

            if (rn1.numerator == rn2.numerator)
            {
                return rn1.denominator < rn2.denominator;
            }

            return rn1.numerator * rn2.denominator > rn2.numerator * rn1.denominator;
        }

        //Определить оператор сравнения <
        public static bool operator <(RationalNumbers rn1, RationalNumbers rn2)
        {
            if (rn1.denominator == rn2.denominator)
            {
                return rn1.numerator < rn2.numerator;
            }

            if (rn1.numerator == rn2.numerator)
            {
                return rn1.denominator > rn2.denominator;
            }

            return rn1.numerator * rn2.denominator < rn2.numerator * rn1.denominator;
        }

        //Определить оператор сравнения >=
        public static bool operator >=(RationalNumbers rn1, RationalNumbers rn2)
        {
            if (rn1.denominator == rn2.denominator)
            {
                return rn1.numerator >= rn2.numerator;
            }

            if (rn1.numerator == rn2.numerator)
            {
                return rn1.denominator <= rn2.denominator;
            }

            return rn1.numerator * rn2.denominator >= rn2.numerator * rn1.denominator;
        }

        //Определить оператор сравнения <=
        public static bool operator <=(RationalNumbers rn1, RationalNumbers rn2)
        {
            if (rn1.denominator == rn2.denominator)
            {
                return rn1.numerator <= rn2.numerator;
            }

            if (rn1.numerator == rn2.numerator)
            {
                return rn1.denominator >= rn2.denominator;
            }

            return rn1.numerator * rn2.denominator <= rn2.numerator * rn1.denominator;
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            if (numerator == 0)
            {
                return "0";
            }

            if (numerator == denominator)
            {
                return "1";
            }
            if (denominator == 1)
            {
                return numerator.ToString();
            }
            return numerator + "/" + denominator;
        }

        //Определить операторы преобразования типов между типом дробь float
        public static explicit operator float(RationalNumbers rn1)
        {
            return (float)rn1.numerator;
        }


    }
}
