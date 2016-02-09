using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class MyListExtension
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] arr = new T[0];
            foreach (var item in list)
            {
                T[] newarr = new T[arr.Length];
                Array.Copy(arr, newarr, arr.Length);
                arr = new T[newarr.Length + 1];
                Array.Copy(newarr , arr , newarr.Length);
                arr[arr.Length] = item;
            }
            
            return arr;
        }
    }
}
