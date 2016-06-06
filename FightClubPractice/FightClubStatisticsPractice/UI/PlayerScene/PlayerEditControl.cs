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
using System.Text.RegularExpressions;

namespace FightClubStatisticsPractice.UI.PlayerScene
{
    public partial class PlayerEditControl : BaseUserControl , IUserControl
    {
        private bool editMode = false;
        private PlayerPresenter presenter = null;
        private PlayerDTO editUser = null;
        private string namepassPattern = @"^[a-zA-Z0-9]+$";
        private string emailPattern = @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$";

        public PlayerEditControl()
        {
            InitializeComponent();
            editMode = false;
            presenter = new PlayerPresenter(new PlayerControl());
        }

        public PlayerEditControl(Object param)
        {
            InitializeComponent();
            editMode = true;

            editUser = (PlayerDTO)param;
            DrawEditUserInfo();

            presenter = new PlayerPresenter(new PlayerControl());
        }

        private void DrawEditUserInfo()
        {
            playerNameTextBox.Text = editUser.Name;
            playerExpTextBox.Text = editUser.Straight.ToString();
            textBox1.Text = editUser.Stamina.ToString();
            textBox2.Text = editUser.Agility.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.PlayerScene);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserData())
            {
                if (editMode)
                {
                    editUser.Name = playerNameTextBox.Text;
                    editUser.Straight = int.Parse(playerExpTextBox.Text);
                    editUser.Stamina = int.Parse(textBox1.Text);
                    editUser.Agility = int.Parse(textBox2.Text);
                    presenter.EditUser(editUser);
                    SwitchScene(Scene.PlayerScene);
                }
                else
                {
                    presenter.AddUser(new PlayerDTO
                    {
                        Name = playerNameTextBox.Text,
                        Straight = int.Parse(playerExpTextBox.Text),
                        Stamina = int.Parse(textBox1.Text),
                        Agility = int.Parse(textBox2.Text)
                    });
                    SwitchScene(Scene.PlayerScene);
                }
            }
            else
            {
                MessageBox.Show("Wrong data");
            }
        }

        // Validation
        private bool ValidateUserData()
        {
            bool isDataValid = true;
            Regex regexName = new Regex(namepassPattern);
            Regex regexEmail = new Regex(emailPattern);

            isDataValid &= regexName.IsMatch(playerNameTextBox.Text);
            isDataValid &= (playerExpTextBox.Text != "");
            int testnum;
            isDataValid &= !(int.TryParse(playerExpTextBox.ToString(), out testnum));

            return isDataValid;
        }

        private void playerExpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
