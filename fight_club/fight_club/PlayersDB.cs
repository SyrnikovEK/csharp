using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace fight_club
{
    [Serializable]
    public class PlayersDB : IEnumerable
    {
        public Player[] elements;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public PlayersDB()
        {
            elements = new Player[0];
            count = 0;
        }

        public bool IsExist(string name)
        {
            bool exist = false;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (elements[i].Name == name)
                    {
                        exist = true;
                    }
                }
            }
            return exist;
        }

        public void Add(Player player)
        {
            Player[] newarr = new Player[count+1];
            Array.Copy(newarr, elements, elements.Length);
            newarr[count] = player;
            count++;
            elements = new Player[count];
            Array.Copy(elements , newarr , count);
        }

        private void Remove(string name)
        {
            //int i = 0;
            //if (IsExist(name))
            //{

            //}
        }

        public void Replace(string name , Player player)
        {
            elements[ReturnIndex(name)] = player;
        }

        public Player Get(string name)
        {
            Player player = null;
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Name == name)        // error, why?
                {
                    player = elements[i];
                }
            }
            return player;
        }

        private int ReturnIndex(string name)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Name == name)
                {
                    index = i;
                }
            }
            return index;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}
