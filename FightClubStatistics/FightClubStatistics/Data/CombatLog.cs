using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    public class CombatLog
    {
        public GameType GameType { get; set; }
        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }
        public List<HitLog> CombatHitLog { get; set; }
        public Player Winner { get; set; }
        public int Exp { get; set; }
        public DateTime CombatTime { get; set; }
    }
}
