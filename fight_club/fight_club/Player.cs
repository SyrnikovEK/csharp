using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class Player : AbstractPlayer
    {
        public Player(int level, string name, int straight, int agility, int stamina)
        {
            base.level = level;
            base.name = name;
            base.hp = 100 + ((stamina - 1) * 5);
            base.straight = straight;
            base.agility = agility;
            base.stamina = stamina;
        }
        public override void SetBlock(BodyPart part)
        {
            base.blockedPart = part;
        }       
    }
}
