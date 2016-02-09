using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list1 = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                list1.Add(i);
            }

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
