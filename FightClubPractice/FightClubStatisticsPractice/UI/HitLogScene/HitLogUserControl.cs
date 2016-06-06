using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FightClubPractice.Data;
using FightClubPractice.Repository;

namespace FightClubStatisticsPractice.UI.HitLogScene
{
    public partial class HitLogUserControl : BaseUserControl
    {
        HitLogRepository repos;
        List<HitLog> combatLogList;
        public HitLogUserControl()
        {
            InitializeComponent();

            repos = new HitLogRepository();
            combatLogList = repos.GetAll().ToList();

            usersDataGrid.Update();
            usersDataGrid.DataSource = combatLogList;
        }

        public HitLogUserControl(object par)
        {
            InitializeComponent();

            repos = new HitLogRepository();
            combatLogList = repos.GetAll().Where(x => x.CombatLogId == (int)par).ToList();

            usersDataGrid.Update();
            usersDataGrid.DataSource = combatLogList;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.CombatLogScene);
        }

        private void toMenuButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.MenuScene);
        }
    }
}
