using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "qwertyuiop[";
            Console.WriteLine(str.MySubstring(2,4));

            Console.WriteLine(str.MyIndexOf("ert"));

            Console.WriteLine(str.MyReplace("e" , "A"));


            Console.ReadKey();
        }
    }
}
