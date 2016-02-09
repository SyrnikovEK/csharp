using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate int[] MyDelegate(int[] arr);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = (int[] arr) =>
            {
                int[] returnedArr = new int[(arr.Length / 2) + 1];
                int j = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    returnedArr[j] = arr[i];
                    i++;
                    j++;
                }
                return returnedArr;
            };

            int[] oldArr = new int[5] {1 , 2 , 3 , 4 , 5 };
            int[] newArr = new int[0];
            newArr = myDelegate(oldArr);

            for (int i = 0; i < oldArr.Length; i++)
            {
                Console.Write(oldArr[i] + " ");
                if (i < newArr.Length)
                {
                    Console.Write(" " + newArr[i]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
