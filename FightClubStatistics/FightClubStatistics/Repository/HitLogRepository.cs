using FightClubStatistics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    class HitLogRepository : AbstractRepository<HitLog>, IHitLogRepository
    {
        public override void Update(HitLog item)
        {
            throw new NotImplementedException();
        }
    }
}
