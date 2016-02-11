using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public abstract class AbstractPlayer : IPlayer
    {
        private int level;
        private int hp;
        private string name;
        private int straight;
        private int agility;
        private int stamina;
        private BodyPart blockedPart;

        public int Level
        {
            get
            {
                return level;
            }
        }
        public int Hp
        {
            get
            {
                return hp;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Straight
        {
            get
            {
                return straight;
            }
        }
        public int Agility
        {
            get
            {
                return straight;
            }
        }
        public int Stamina
        {
            get
            {
                return straight;
            }
        }

        public abstract void SetBlock(BodyPart part);
        public void GetHit(BodyPart part , FightPapams par)
        {
            if (par.agility > agility)
            {
                hp -= par.straight * 5;
            }
            else
            {
                if (Dice.Throw() > 14)
                {
                    hp -= par.straight * 5;
                }         
            }
        }
    }
}
