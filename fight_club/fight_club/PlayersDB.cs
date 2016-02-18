using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class PlayersDB
    {
        private AbstractPlayer[] elements;
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
            elements = new AbstractPlayer[0];
            count = 0;
        }

        public bool IsExist(string name)
        {
            bool exist = false;
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Name == name)
                {
                    exist = true;
                }
            }
            return exist;
        }

        public void Add(AbstractPlayer player)
        {
            AbstractPlayer[] newarr = new AbstractPlayer[count+1];
            Array.Copy(newarr, elements, elements.Length);
            newarr[count + 1] = player;
            count++;
            elements = new AbstractPlayer[count];
            Array.Copy(elements , newarr , count);
        }

        public void Remove(string name)
        {
            //int i = 0;
            //if (IsExist(name))
            //{

            //}
        }

        public AbstractPlayer Get(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Name == name)
                {
                    return elements[i];
                }
            }
            return null;
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
    }
}
