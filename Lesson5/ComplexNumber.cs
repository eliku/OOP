using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class ComplexNumber
    {
        private int _a;          //действительное число a                                    
        private int _b;          //действительное число b

        public int a
        {
            get { return _a; }
            set { _a = value; }
        }

        public int b
        {
            get { return _b; }
            set { _b = value; }
        }
        public ComplexNumber(int A, int B)
        {
            _a = A;
            _b = B;
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            if (a == 0)
            {
                return  "+i*" + b;
            }

            if (b == 0)
            {
                return Convert.ToString(a);
            }

            return a + "+i*" + b;
        }

        //Определить оператор +
        public static ComplexNumber operator +(ComplexNumber complex1, ComplexNumber complex2)
        {
            return new ComplexNumber(complex1.a + complex2.a, complex1.b + complex2.b);
        }

        //Определить оператор -
        public static ComplexNumber operator -(ComplexNumber complex1, ComplexNumber complex2)
        {
            return new ComplexNumber(complex1.a - complex2.a, complex1.b - complex2.b);
        }

        //Определить оператор *
        //по правилу(a + bi) · (c + di) = (ac – bd) + (ad + bc)i
        public static ComplexNumber operator *(ComplexNumber complex1, ComplexNumber complex2)
        {
            return new ComplexNumber(complex1.a * complex2.a - complex1.b * complex2.b, complex1.a * complex2.b + complex1.b * complex2.a);
        }

        //Определить оператор ==
        public static bool operator ==(ComplexNumber complex1, ComplexNumber complex2)
        {
            bool isComp1IsNull = ReferenceEquals(complex1, null);
            bool isComp2IsNull = ReferenceEquals(complex2, null);

            if (isComp1IsNull == isComp2IsNull && isComp1IsNull == true) return true;

            return complex1.a == complex2.a && complex1.b == complex2.b;
        }

        //Определить оператор !=
        public static bool operator !=(ComplexNumber complex1, ComplexNumber complex2)
        {

            return complex1.a != complex2.a || complex1.b != complex2.b;
        }
    }
}
