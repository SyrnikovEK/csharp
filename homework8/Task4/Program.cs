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
            int[] arr = new int[0];

            MyList<int> list1 = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                list1.Add(i);
            }

            arr = (list1 as IEnumerable<int>).GetArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
