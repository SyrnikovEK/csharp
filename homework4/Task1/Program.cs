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
            //Console.WriteLine("a a a");
            //Console.WriteLine("   a b c d e   ".DeleteSpaces());
            //Console.WriteLine(PolishNotationCalculator.Calculate(PolishNotationConverter.Convert()));

            string expr = "";
            //expr = "3+4*2/(1-5)^2";         //ans 3.5
            //expr = "(8+2*5)/(1+3*2-4)";     // ans 6
            expr = " 3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3";
            Console.WriteLine(PolishNotationConverter.Convert(expr));


            //Console.WriteLine("Enter expression");
            //expr = Console.ReadLine();
            //Console.WriteLine(Calculator.Calculate(expr));

            Console.ReadKey();
        }
    }
}
