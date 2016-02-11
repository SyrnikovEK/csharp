using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public interface IPlayer
    {
        void SetBlock(BodyPart part);
        void GetHit(BodyPart part , FightPapams par);
    }
}
