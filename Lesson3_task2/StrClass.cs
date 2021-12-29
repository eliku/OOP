using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_task2
{
    class StrClass
    {
        public string ReverseString(string Str)
        {
            char[] arr = Str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
