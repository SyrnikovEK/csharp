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
        public BodyPart blockedPart;

        public delegate string MyEvent(object sender, BodyPart e);

        public event MyEvent onBlock;
        public event MyEvent onWound;
        public event MyEvent onDeath;

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
                return agility;
            }
        }
        public int Stamina
        {
            get
            {
                return stamina;
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
            straight = 3;
            agility = 2;
            stamina = 1;
            hp = 100 + ((stamina - 1) * 5);
        }

        //public AbstractPlayer(int level , string name , int straight , int agility , int stamina)
        //{
        //    this.level = level;
        //    this.name = name;
        //    hp = 100 + ((stamina - 1) * 5);
        //    this.straight = straight;
        //    this.agility = agility;
        //    this.stamina = stamina; 
        //}

        public abstract void SetBlock(BodyPart part);
        public int GetHit(BodyPart part , FightPapams par)
        {
            int damage;
            if (part != blockedPart)
            {
                hp -= par.straight * 5;
                damage = par.straight * 5;
                onWound(this , part);
            }
            else
            {
                if (Dice.Throw() + (par.agility - agility) > 14)
                {
                    hp -= par.straight * 5;
                    damage = par.straight * 5;
                    onWound(this , part);
                }
                else
                {
                    damage = 0;
                    onBlock(this , blockedPart);
                }
            }
            if (hp <= 0)
            {
                onDeath(this , BodyPart.Head);
            }
            return damage;
        }


        
    }
}
