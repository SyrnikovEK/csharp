using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Game
{
    public interface IPlayer
    {
        void SetBlock(BodyPart part);
        int GetHit(BodyPart part, FightPapams par);
    }
}
