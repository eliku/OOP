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

        //Определить оператор ==
        public static bool operator ==(RationalNumbers rn1, RationalNumbers rn2)
        {
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
    }
}
