using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FightClubPractice.Repository;
using FightClubPractice.Data;

namespace FightClubStatisticsPractice.UI.CombatLogScene
{
    public partial class CombatLogUserControl : BaseUserControl
    {
        CombatLogRepository repos;
        List<CombatLog> combatLogList;
        public CombatLogUserControl()
        {
            InitializeComponent();

            repos = new CombatLogRepository();
            combatLogList = repos.GetAll().ToList();

            usersDataGrid.Update();
            usersDataGrid.DataSource = combatLogList;
        }

        public CombatLogUserControl(object par)
        {
            InitializeComponent();

            repos = new CombatLogRepository();
            combatLogList = repos.GetAll().Where(x => x.PlayerId == (int)par) .ToList();

            usersDataGrid.Update();
            usersDataGrid.DataSource = combatLogList;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.HitLogScene, int.Parse(usersDataGrid.CurrentRow.Cells[0].Value.ToString()));
        }

        private void toMenuButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.MenuScene);
        }
    }
}
