using FightClubStatistics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    class CombatLogRepository : AbstractRepository<CombatLog>, ICombatLogRepository
    {
        public override void Update(CombatLog item)
        {
            throw new NotImplementedException();
        }
    }
}
