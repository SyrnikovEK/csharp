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

namespace FightClubStatisticsPractice.UI.PlayerScene
{
    public partial class PlayerControl : BaseUserControl , IPlayerControl
    {
        private PlayerPresenter presenter = null;


        public PlayerControl()
        {
            InitializeComponent();
            presenter = new PlayerPresenter(this);
        }

        private void UserUserControl_Load(object sender, EventArgs e)
        {

        }

        public void DrawUsersTable(List<PlayerDTO> userList)
        {
            usersDataGrid.Update();
            usersDataGrid.DataSource = userList;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            presenter.TurnAddUserControl();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if (usersDataGrid.RowCount > 0)
            {
                int userId = int.Parse(usersDataGrid.CurrentRow.Cells[0].Value.ToString());
                presenter.TurnEditUserControl(userId);
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (usersDataGrid.RowCount > 0)
            {
                if (MessageBox.Show("Please, confirm deletion", "Confirm deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    presenter.DeleteUser(int.Parse(usersDataGrid.CurrentRow.Cells[0].Value.ToString()));
                    usersDataGrid.Update();
                }
                else
                {

                }
            }
            else
            {

            }

        }

        private void toMenuButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.MenuScene);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.CombatLogScene, int.Parse(usersDataGrid.CurrentRow.Cells[0].Value.ToString()));
        }
    }
}
