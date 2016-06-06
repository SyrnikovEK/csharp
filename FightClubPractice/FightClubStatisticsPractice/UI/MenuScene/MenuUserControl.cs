using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubStatisticsPractice.UI.MenuScene
{
    public partial class MenuUserControl : BaseUserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void toUsersControl_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.PlayerScene);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toCombatLogControl_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.CombatLogScene);
        }

        private void toHitLogControl_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.HitLogScene);
        }
    }
}