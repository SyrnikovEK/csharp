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

        }

        public void Remove(string name)
        {

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
    }
}
