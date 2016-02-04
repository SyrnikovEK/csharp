using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate double MyDelegate(int par1 , int par2 , int par3);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = delegate (int par1, int par2, int par3) { return ((par1 + par2 + par3) / 3)}; 
            MyDelegate myDelegate = (int par1, int par2, int par3) => { return ((par1 + par2 + par3) / 3); };
            Console.WriteLine(myDelegate(1 , 2 , 3));
            Console.ReadKey();
        }
    }
}
