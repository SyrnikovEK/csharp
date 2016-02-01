using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class StringExtensions
    {
        public static string MySubstring(this string inputstring , int left , int right)
        {
            string outputstring = "";
            inputstring.ToArray();
            for (int i = left; i < (right + 1); i++)
            {
                outputstring += inputstring[i];
            }
            return outputstring;
        }

        public static int MyIndexOf(this string inputstring, string substring)
        {
            int index = -1;
            int k = 0;
            inputstring.ToArray();
            substring.ToArray();

            for (int i = 0; i < (inputstring.Length - substring.Length); i++)
            {
                bool eq = false;
                k = 0;
                for (int j = i; j < (i + substring.Length); j++)
                {
                    if (inputstring[j] != substring[k])
                    {
                        eq = false;
                        break;
                    }
                    eq = true;
                    k++;
                }
                if (eq)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static string MyReplace(this string inputstring, string substr1, string substr2)
        {
            int index = 0;
            string outputstring = "";
            substr1.ToArray();
            substr2.ToArray();

            while (inputstring.MyIndexOf(substr1) != -1)
            {
                index = inputstring.MyIndexOf(substr1);
                for (int i = 0; i < index; i++)
                {
                    outputstring += inputstring[i];
                }
                outputstring += substr2;
                for (int i = index + substr2.Length; i < inputstring.Length; i++)
                {
                    outputstring += inputstring[i];
                }
                inputstring = outputstring;
            }
            return outputstring;
        }
    }
}
