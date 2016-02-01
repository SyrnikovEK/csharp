using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class ArrayExtensions
    {
        public static void MySort(this int[] arr, int left, int right , bool dir)
        {
            if (dir)
            {
                int l = left;
                int r = right;
                int tmp;
                int mid = arr[(r + l) / 2];

                while (l <= r)
                {
                    while (arr[l] < mid)
                    {
                        l++;
                    }
                    while (arr[r] > mid)
                    {
                        r--;
                    }
                    if (l <= r)
                    {
                        tmp = arr[l];
                        arr[l] = arr[r];
                        arr[r] = tmp;

                        l++;
                        r--;
                    }
                }

                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }

                if (l < right)
                {
                    MySort(arr, l, right , dir);
                }
                if (r > left)
                {
                    MySort(arr, left, r , dir);
                }
            }
            else
            {
                int l = left;
                int r = right;
                int tmp;
                int mid = arr[(r + l) / 2];

                while (l <= r)
                {
                    while (arr[l] > mid)
                    {
                        l++;
                    }
                    while (arr[r] < mid)
                    {
                        r--;
                    }
                    if (l <= r)
                    {
                        tmp = arr[l];
                        arr[l] = arr[r];
                        arr[r] = tmp;

                        l++;
                        r--;
                    }
                }

                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }

                if (l < right)
                {
                    MySort(arr, l, right , dir);
                }
                if (r > left)
                {
                    MySort(arr, left, r , dir);
                }
            }
        }
    }
}
