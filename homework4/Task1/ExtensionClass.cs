using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class ExtensionClass
    {
        public static string DeleteSpaces(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str.ToArray();
                if (str[i] == ' ')
                {
                    str = str.Remove(i , 1);
                    i--;
                }
            }
            return str;
        }
    }
}
