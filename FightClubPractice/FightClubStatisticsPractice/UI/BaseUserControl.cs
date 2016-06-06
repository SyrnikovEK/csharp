using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubStatisticsPractice.UI
{
    public enum Scene
    {
        MenuScene,
        PlayerScene,
        PlayerEditScene,
        CombatLogScene,
        HitLogScene
    }
    public partial class BaseUserControl : UserControl, IUserControl
    {
        public void SwitchScene(Scene targetScene)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene);
        }

        public void SwitchScene(Scene targetScene, Object param)
        {
            var form = this.FindForm() as MainForm;
            form.SwitchScene(targetScene, param);
        }
    }
}
