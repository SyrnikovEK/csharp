using FightClubPractice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Repository
{
    public class HitLogRepository : AbstractRepository<HitLog>
    {
        public override void Add(HitLog item)
        {
            //HitLog newItem = new HitLog();
            context.HitLogs.Add(item);
        }
    }
}
