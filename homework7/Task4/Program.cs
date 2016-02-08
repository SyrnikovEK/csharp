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
            MyList<int> myList = new MyList<int>(10);
            int[] arr = new int[0];
            myList[3] = 2;
            myList.Add(3);

            arr = myList.GetArray();

            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine("List: {0}    Array: {1}" , myList[i] , arr[i]);
            }

            Console.ReadKey();
        }
    }
}
