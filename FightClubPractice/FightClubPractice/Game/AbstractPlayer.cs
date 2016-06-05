using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FightClubPractice.Game
{
    public abstract class AbstractPlayer : IPlayer
    {
        #region Fields
        protected int level;
        protected int hp;
        protected string name;
        protected int straight;
        protected int agility;
        protected int stamina;
        protected int exp;
        public BodyPart blockedPart;
        #endregion        

        #region Properties
        public int Level
        {
            get
            {
                return exp;
            }
            set
            {
                exp = value;
            }
        }
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Straight
        {
            get
            {
                return straight;
            }
            set
            {
                straight = value;
            }
        }
        public int Agility
        {
            get
            {
                return agility;
            }
            set
            {
                agility = value;
            }
        }
        public int Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                stamina = value;
            }
        }
        public int MaxHp
        {
            get
            {
                return (100 + ((stamina - 1) * 10));
            }
            set
            {
                MaxHp = value;
            }
        }
        public int Exp
        {
            get
            {
                return exp;
            }
            set
            {
                exp = value;
            }
        }
        #endregion

        #region Events
        public delegate void MyEvent(object sender, BodyPart e);
        public event MyEvent Block;
        public event MyEvent Wound;
        #endregion

        #region Constructors
        public AbstractPlayer()
        {
        }
        #endregion

        #region Methods
        public abstract void SetBlock(BodyPart part);
        public int GetHit(BodyPart part, FightPapams par)
        {
            int damage;
            if (part != blockedPart)
            {
                damage = CalculateDamage(par.straight);
                hp -= damage;
                //Wound.Invoke(this, part);
            }
            else
            {
                if (Dice.Throw() + (par.agility - agility) > 14)   // chanse of succesfull block is 70% - agility difference
                {
                    damage = CalculateDamage(par.straight);
                    hp -= damage;
                    //Wound.Invoke(this, part);
                }
                else
                {
                    damage = 0;
                    //Block.Invoke(this, blockedPart);
                }
            }
            return damage;
        }

        public void AddExp(int exp)
        {
            this.exp += exp;
            level = ((int)(exp / 1000) + 1);
        }

        protected int CalculateHp()
        {
            return 100 + ((stamina - 1) * 10);
        }

        private int CalculateDamage(int str)
        {
            return str * 5;
        }
        #endregion
    }
}
