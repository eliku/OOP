using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ACoder: ICoder
    {
        public string Encode(string Srt) 
        {
            char[] code = new char[Srt.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char c = Srt[i];

                if (!Char.IsLetter(c))
                    code[i] = c;
                else 
                    code[i] = (char)((c + 1));
            }

            return new string(code);
        }

        public string Decode(string Srt)
        {
            char[] code = new char[Srt.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char c = Srt[i];

                if (!Char.IsLetter(c))
                    code[i] = c;
                else
                    code[i] = (char)((c - 1));
            }

            return new string(code);
        }

    }
}
