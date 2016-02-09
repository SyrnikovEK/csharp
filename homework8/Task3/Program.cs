using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();

            myDictionary.Add(1, "one");
            myDictionary.Add(2, "two");
            myDictionary.Add(3, "three");
            myDictionary.Add(4, "four");
            myDictionary.Add(5, "five");

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);  // ToString not working?
            }

            

            Console.ReadKey();
        }
    }
}
