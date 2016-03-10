using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    [Serializable]
    public class Player : AbstractPlayer , IPlayer
    {
        public Player(int level, string name, int straight, int agility, int stamina , int exp = 0)
        {
            if (level <= 0)
            {
                level = 1;
            }
            if (string.IsNullOrEmpty(name))
            {
                name = "Unnaimed";
            }
            if (stamina <= 0)
            {
                stamina = 1;
            }
            if (agility <= 0)
            {
                agility = 1;
            }
            if (straight <= 0)
            {
                straight = 1;
            }
            if (exp < 0)
            {
                exp = 0;
            }

            base.level = level;
            base.name = name;            
            base.hp = 100 + ((stamina - 1) * 10);
            base.straight = straight;
            base.agility = agility;
            base.stamina = stamina;
            base.exp = exp;
        }
        public override void SetBlock(BodyPart part)
        {
            base.blockedPart = part;
        }       
    }
}
