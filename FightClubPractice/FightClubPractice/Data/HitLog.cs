using FightClubPractice.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Data
{
    public class HitLog
    {
        public int HitLogId { get; set; }

        public int CombatLogId { get; set; }

        public int FirstPalyerHitValue { get; set; }
        public int FirstPlayerCurrentHp { get; set; }
        public BodyPart FirstPalyerPart { get; set; }
        public TurnResult FirstPalyerResult { get; set; }

        public int SecondPlayerHitValue { get; set; }
        public int SecondPlayerCurrentHp { get; set; }
        public BodyPart SecondPlayerPart { get; set; }
        public TurnResult SecondPlayerResult { get; set; }
    }
}
