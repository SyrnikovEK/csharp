using FightClubPractice.Data;
using FightClubPractice.Game;
using FightClubPractice.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Repository
{
    public class PlayerRepository : AbstractRepository<PlayerDTO>
    {
        public override bool IsExist(string name)
        {
            PlayerDTO pl = null;
            pl = context.Players.Where(x => x.Name == name).FirstOrDefault();
            return (pl != null);
        }

        public void Update(Player item)
        {
            PlayerDTO oldPlayer;
            oldPlayer = context.Players.Where(x => x.PlayerDTOId == item.PlayerId).FirstOrDefault();
            oldPlayer.Name = item.Name;
            oldPlayer.Level = item.Level;
            oldPlayer.Exp = item.Exp;
            oldPlayer.Hp = item.Hp;
            oldPlayer.Straight = item.Straight;
            oldPlayer.Stamina = item.Stamina;
            oldPlayer.Agility = item.Agility;

            context.SaveChanges();
        }

        public Player Get(string name)
        {
            PlayerDTO pl = context.Players.Where(x => x.Name == name).FirstOrDefault();
            Player returnedPlayer = new Player(pl.Name , pl.Straight , pl.Agility , pl.Stamina , pl.Exp);
            returnedPlayer.PlayerId = pl.PlayerDTOId;
            return returnedPlayer;
        }

        public void Add(Player item)
        {
            base.Add(new PlayerDTO { Name = item.Name , Level = item.Level , Exp = item.Exp , Hp = item.Hp , Agility = item.Agility , Stamina = item.Stamina , Straight = item.Straight});
        }

        public List<Player> GetAllPlayers()
        {
            List<Player> returnedList = new List<Player>();
            List<PlayerDTO> dtoList = context.Players.ToList();
            foreach (var item in dtoList)
            {
                returnedList.Add(new Player(item.Name, item.Straight, item.Agility, item.Stamina, item.Exp));
            }
            return returnedList;
        }

        public override void Update(PlayerDTO item)
        {
            PlayerDTO oldPlayer;
            oldPlayer = context.Players.Where(x => x.PlayerDTOId == item.PlayerDTOId).FirstOrDefault();
            oldPlayer.Name = item.Name;
            oldPlayer.Level = item.Level;
            oldPlayer.Exp = item.Exp;
            oldPlayer.Hp = item.Hp;
            oldPlayer.Straight = item.Straight;
            oldPlayer.Stamina = item.Stamina;
            oldPlayer.Agility = item.Agility;

            context.SaveChanges();
        }
    }
}
