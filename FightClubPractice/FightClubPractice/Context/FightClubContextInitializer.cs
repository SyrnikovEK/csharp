using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Context
{
    public class FightClubContextInitializer : DropCreateDatabaseAlways<FightClubContext>
    {
        protected override void Seed(FightClubContext context)
        {
            context.Players.Add(new Data.PlayerDTO
            {
                Name = "Ted",
                Exp = 120,
                Level = 1,
                Hp = 115,
                Agility = 2,
                Stamina = 3,
                Straight = 3
            });

            base.Seed(context);
        }
    }
}
