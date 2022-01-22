using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class BCoder : ICoder
    {
        public string Encode(string Srt)
        {
            char[] code = new char[Srt.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char ch = Srt[i];

                if (!Char.IsLetter(ch))
                    code[i] = ch;
                else
                {
                    if (Char.IsLower(ch))
                    {
                        int k = Convert.ToInt32(ch - 'а');
                        code[i] = (char)('я' - k);
                    }
                    else
                    {
                        int k = Convert.ToInt32(ch - 'А');
                        code[i] = (char)('Я' - k);
                    }
                }
            }

            return new string(code);
        }

        public string Decode(string Srt)
        {
            char[] code = new char[Srt.Length];
            for (int i = 0; i < code.Length; i++)
            {
                char ch = Srt[i];

                if (!Char.IsLetter(ch))
                    code[i] = ch;
                else
                {
                    if (Char.IsLower(ch))
                    {
                        int k = Convert.ToInt32('я' - ch);
                        code[i] = (char)('а' + k);
                    }
                    else
                    {
                        int k = Convert.ToInt32('Я' - ch);
                        code[i] = (char)('А' + k);
                    }
                }
            }

            return new string(code);
        }
    }
}
