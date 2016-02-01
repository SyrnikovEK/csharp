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
            Notebook notebook1 = new Notebook("Qwe", "Asd", 100);
            notebook1.Show();

            Console.ReadKey();
        }
    }
}
