using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Game
{
    public class Player : AbstractPlayer , IPlayer
    {
        public int PlayerId { get; set; }
        #region Constructors
        public Player(string name, int straight, int agility, int stamina, int exp = 0)
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
            
            base.name = name;
            base.straight = straight;
            base.agility = agility;
            base.stamina = stamina;
            base.hp = base.CalculateHp(); 
            base.exp = exp;
            base.level = ((int)(base.exp / 1000) + 1);
        }
        #endregion

        #region Methods
        public override void SetBlock(BodyPart part)
        {
            base.blockedPart = part;
        }
        #endregion
    }
}
