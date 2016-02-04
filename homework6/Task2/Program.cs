using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public delegate double MyDelegate1(int par1 , int par2);
        public delegate bool MyDelegate2(int par1, int par2 , out double res);
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            double c = 0;

            MyDelegate1 Sum = (int par1, int par2) => { return (par1 + par2); };
            MyDelegate1 Sub = (int par1, int par2) => { return par1 - par2; };
            MyDelegate1 Mult = (int par1, int par2) => { return par1 * par2; };
            MyDelegate2 Div = (int par1, int par2, out double res) => { res = ((double)par1 / (double)par2); return true; };

            Console.WriteLine(Sum(a , b));
            Console.WriteLine(Sub(a, b));
            Console.WriteLine(Mult(a, b));
            if (Div(a , b , out c))
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
