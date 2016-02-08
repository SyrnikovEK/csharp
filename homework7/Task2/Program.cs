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
            MyList<int> myList = new MyList<int>(10);
            myList[3] = 2;
            myList.Add(3);

            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.ReadKey();
        }
    }
}
