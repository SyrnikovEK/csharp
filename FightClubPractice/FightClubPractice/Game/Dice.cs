using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Game
{
    public static class Dice
    {
        private static Random rnd = new Random();
        public static int Throw()
        {
            return rnd.Next(20) + 1;
        }
    }
}
