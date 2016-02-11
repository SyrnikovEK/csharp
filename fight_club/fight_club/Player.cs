using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class Player : AbstractPlayer
    {
        public override void SetBlock(BodyPart part)
        {
            base.blockedPart = part;
        }       
    }
}
