using FightClubPractice.Data;
using FightClubPractice.Game;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Context
{
    public class FightClubContext : DbContext
    {
        public FightClubContext()
        {
            Database.SetInitializer(new FightClubContextInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CombatLog> CombatLogs { get; set; }
        public DbSet<HitLog> HitLogs { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
