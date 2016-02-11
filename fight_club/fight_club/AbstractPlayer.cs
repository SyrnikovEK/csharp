using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public abstract class AbstractPlayer : IPlayer
    {
        protected int level;
        protected int hp;
        protected string name;
        protected int straight;
        protected int agility;
        protected int stamina;
        protected BodyPart blockedPart;

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
        public int MaxHp
        {
            get
            {
                return (100 + ((stamina - 1) * 5));
            }
        }

        public AbstractPlayer()
        {
            level = 1;
            name = "PlayerName";
            straight = 2;
            agility = 2;
            stamina = 1;
            hp = 100 + ((stamina - 1) * 5);
        }

        public AbstractPlayer(int level , string name , int straight , int agility , int stamina)
        {
            this.level = level;
            this.name = name;
            hp = 100 + ((stamina - 1) * 5);
            this.straight = straight;
            this.agility = agility;
            this.stamina = stamina; 
        }

        public abstract void SetBlock(BodyPart part);
        public int GetHit(BodyPart part , FightPapams par)
        {
            int damage;
            if (part != blockedPart)
            {
                if (par.agility > agility)
                {
                    hp -= par.straight * 5;
                    damage = par.straight * 5;
                }
                else
                {
                    if (Dice.Throw() > 10)
                    {
                        hp -= par.straight * 5;
                        damage = par.straight * 5;
                    }
                    else
                    {
                        damage = 0;
                    }
                }
            }
            else
            {
                damage = 0;
            }
            return damage;
        }

    }
}
