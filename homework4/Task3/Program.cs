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
            Random r1 = new Random();
            int[] arr = new int[] { 2, 4, 1, 3, 5, 9, 6, 0, 8, 7 };
            int[] arr2 = new int[10];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = r1.Next(0, 100);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            arr2.MySort(0, arr2.Length - 1 , false);

            Console.ReadKey();
        }
    }
}
