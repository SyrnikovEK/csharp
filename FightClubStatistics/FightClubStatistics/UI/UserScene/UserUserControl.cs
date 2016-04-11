using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FightClubStatistics;

namespace FightClubStatistics.UI.UserScene
{
    public interface IUserUserControl
    {
        void DrawUsersTable(List<User> userList);
    }
    public partial class UserUserControl : BaseUserControl , IUserUserControl
    {
        private UserPresenter presenter = null;
        

        public UserUserControl()
        {            
            InitializeComponent();
            presenter = new UserPresenter(this);
        }

        private void UserUserControl_Load(object sender, EventArgs e)
        {

        }

        public void DrawUsersTable(List<User> userList)
        {
            usersDataGrid.DataSource = userList;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            presenter.AddUser();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(usersDataGrid.CurrentRow.Cells[0].Value.ToString());
            presenter.EditUser(userId);
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            presenter.DeleteUser(Int32.Parse(usersDataGrid.CurrentRow.Cells[0].Value.ToString()));
            usersDataGrid.Update();
        }
    }
}
