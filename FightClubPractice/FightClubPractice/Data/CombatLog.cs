﻿using FightClubPractice.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Data
{
    public class CombatLog
    {
        public int CombatLogId { get; set; }
        public GameType GameType { get; set; }
        public int PlayerId { get; set; }
        public virtual List<HitLog> CombatHitLogs { get; set; }
        public GameResult Result { get; set; }
        public int Exp { get; set; }
        public DateTime CombatTime { get; set; }

        public CombatLog()
        {
            CombatHitLogs = new List<HitLog>();
        }
    }
}
