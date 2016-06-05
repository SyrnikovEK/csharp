using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Game
{
    public struct FightPapams
    {
        public int straight;
        public int agility;

        public FightPapams(int straight, int agility)
        {
            this.straight = straight;
            this.agility = agility;
        }
    }
}
