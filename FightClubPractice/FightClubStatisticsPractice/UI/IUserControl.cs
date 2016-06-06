using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatisticsPractice.UI
{
    public interface IUserControl
    {
        void SwitchScene(Scene targetScene);
        void SwitchScene(Scene targetScene, Object param);
    }
}
