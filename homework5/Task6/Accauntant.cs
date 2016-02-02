using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public static class Accauntant
    {
        public static bool AskForBonus(Position worker , int hours)
        {
            if (hours > (int)worker)
            {
                return true;
            }
            else
                return false;
        }
    }
}
