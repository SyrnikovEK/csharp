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
            context.Players.Add(new Game.Player("pla", 3, 3, 3));

            base.Seed(context);
        }
    }
}
