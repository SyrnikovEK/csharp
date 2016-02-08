using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class MyList<T>
    {
        private int length;
        private T[] items;
        public int Length
        {
            get
            {
                return length;
            }
        }

        public MyList()
        {
            length = 0;
            items = new T[0];
        }

        public MyList(int size)
        {
            length = size;
            items = new T[size];
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }

            set
            {
                items[index] = value;
            }
        }

        public void Add(T item)
        {
            T[] newitems = new T[length];
            Array.Copy(items, newitems, length);
            items = new T[length + 1];
            Array.Copy(newitems, items, newitems.Length);
            items[length] = item;
            length++;

        }

    }
}
