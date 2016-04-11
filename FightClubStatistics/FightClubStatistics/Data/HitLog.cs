using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    public class HitLog
    {
        public int HitLogId { get; set; }
        public int FirstPalyerHitValue { get; set; }
        public BodyPart FirstPalyerPart { get; set; }
        public GameResult FirstPalyerResult { get; set; }

        public int SecondPlayerHitValue { get; set; }
        public BodyPart SecondPlayerPart { get; set; }
        public GameResult SecondPlayerResult { get; set; }
    }
}
