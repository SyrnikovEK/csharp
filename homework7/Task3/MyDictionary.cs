using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class MyDictionary<TKey , TValue>
    {
        public class KeyValuePair//<TKey , TValue>
        {
            public TKey key;
            public TValue value;
            KeyValuePair(TKey skey , TValue svalue)
            {
                key = skey;
                value = svalue;
            }
        }

        private int length;
        private KeyValuePair[] items;
        public int Length
        {
            get
            {
                return length;
            }
        }

        public MyDictionary()
        {
            length = 0;
            items = new KeyValuePair[0];
        }


        //public KeyValuePair this[TKey index]
        //{
        //    get
        //    {
        //        for (int i = 0; i < items.Length; i++)
        //        {
        //            if (items[i].key == index) //
        //            {
        //                return items[i];
        //                break;
        //            }
        //        }
        //    }

        //    set
        //    {
        //        items[index] = value;
        //    }
        //}

        public void Add(KeyValuePair item)
        {
            KeyValuePair[] newitems = new KeyValuePair[length];
            Array.Copy(items, newitems, length);
            items = new KeyValuePair[length + 1];
            Array.Copy(newitems, items, newitems.Length);
            items[length] = item;
            length++;
        }
    }
}
