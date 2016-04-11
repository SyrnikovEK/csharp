using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubStatistics.UI.UserScene
{
    public partial class EditUserControl : BaseUserControl
    {
        private bool editMode = false;
        private UserPresenter presenter = null;

        public EditUserControl()
        {
            InitializeComponent();
            editMode = false;
            presenter = new UserPresenter(new UserUserControl());
        }

        public EditUserControl(Object param)
        {
            InitializeComponent();
            editMode = true;

            User editUser = param as User;
            userLoginTextBox.Text = editUser.Login;
            userPasswordTextBox.Text = editUser.Password;
            userEMailTextBox.Text = editUser.EMail;
            playerNameTextBox.Text = editUser.PlayerData.Name;
            playerExpTextBox.Text = editUser.PlayerData.Exp.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.UserScene);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (editMode)
            {

            }
            else
            {
                presenter.AddUser(new User
                {
                    Login = userLoginTextBox.Text,
                    EMail = userEMailTextBox.Text,
                    CreationDate = DateTime.Now,
                    IsEmailValid = false,
                    Password = userPasswordTextBox.Text,
                    PlayerData = new Player
                    {
                        Name = playerNameTextBox.Text,
                        Exp = Int32.Parse(playerExpTextBox.Text)
                    }
                });
                SwitchScene(Scene.UserScene);
            }
        }
    }
}
