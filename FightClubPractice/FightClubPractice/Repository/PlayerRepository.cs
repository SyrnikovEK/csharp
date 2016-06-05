using FightClubPractice.Game;
using FightClubPractice.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Repository
{
    public class PlayerRepository : AbstractRepository<Player>
    {
        public override bool IsExist(string name)
        {
            return (context.Players.Where(x => x.Name == name) is Player);
        }

        public override void Update(Player item)
        {
            Player oldPlayer;
            oldPlayer = context.Players.Where(x => x.PlayerId == item.PlayerId).FirstOrDefault();
            oldPlayer.Name = oldPlayer.Name;
            oldPlayer.Level = item.Level;
            oldPlayer.Exp = item.Exp;
            oldPlayer.Hp = item.Hp;
            oldPlayer.MaxHp = item.MaxHp;
            oldPlayer.Straight = item.Straight;
            oldPlayer.Stamina = item.Stamina;
            oldPlayer.Agility = item.Agility;

            context.SaveChanges();
        }

        public Player Get(string name)
        {
            Player pl = context.Players.Where(x => x.Name == name).FirstOrDefault();
            return pl;
        }
    }
}
