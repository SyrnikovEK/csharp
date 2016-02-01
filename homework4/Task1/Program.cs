using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 45;
            //double b = 45.45;
            //Calculator.Sum(a,b);
            //Console.WriteLine("a a a");
            //Console.WriteLine("   a b c d e   ".DeleteSpaces());

            Console.WriteLine(PolishNotationConverter.Convert("3+4*2/(1-5)^2"));

            Console.ReadKey();
        }
    }
}
