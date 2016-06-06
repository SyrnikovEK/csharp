using FightClubPractice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Repository
{
    public class CombatLogRepository : AbstractRepository<CombatLog>
    {
        public override void Add(CombatLog item)
        {
            context.CombatLogs.Add(new CombatLog
            {
                PlayerId = item.PlayerId,
                CombatHitLogs = item.CombatHitLogs,
                CombatTime = item.CombatTime,
                Exp = item.Exp,
                GameType = item.GameType,
                Result = item.Result,
                CombatLogId = context.CombatLogs.Count() + 1
            });
            

            context.SaveChanges();
        }
    }
}
