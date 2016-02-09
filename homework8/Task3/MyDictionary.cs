using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task3
{
    public class MyDictionary<TKey, TValue> : IEnumerable
    {
        public class KeyValuePair//<TKey , TValue>
        {
            public TKey key;
            public TValue value;
            public KeyValuePair(TKey skey, TValue svalue)
            {
                key = skey;
                value = svalue;
            }
            public KeyValuePair()
            {
                key = default(TKey);
                value = default(TValue);
            }

            //public string ToString()
            //{
            //    return key.ToString() + " " + value.ToString();
            //}
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

        public MyDictionary(int count)
        {
            length = count;
            items = new KeyValuePair[count];
        }


        public KeyValuePair this[TKey index]
        {          
            get
            {
                KeyValuePair returnedItem = new KeyValuePair();
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i].key.Equals(index)) //
                    {
                        //return items[i];
                        returnedItem = items[i];
                        break;
                    }
                }
                return returnedItem;
            }

            set
            {
                KeyValuePair returnedItem = new KeyValuePair();
                int i;
                for (i = 0; i < items.Length; i++)
                {
                    if (items[i].key.Equals(index)) //
                    {
                        //return items[i];
                        returnedItem = items[i];
                        break;
                    }
                }

                if (returnedItem != null)
                {
                    items[i] = value;
                }
            }
        }

        public void Add(TKey key , TValue value)//(KeyValuePair item)
        {
            KeyValuePair[] newitems = new KeyValuePair[length];
            Array.Copy(items, newitems, length);
            items = new KeyValuePair[length + 1];
            Array.Copy(newitems, items, newitems.Length);
            items[length] = new KeyValuePair(key , value);
            length++;
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();  // ?
        }
    }
}
