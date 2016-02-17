using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fight_club
{
    public partial class PlayerCreationForm : Form
    {
        public PlayerCreationForm()
        {
            InitializeComponent();
        }

        private void EnterNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChosingStatsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayerCreationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ToMenuButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm frm = new AuthorizationForm();
            frm.Show();
            this.Hide();
        }

        private void PlayerCreateButton_Click(object sender, EventArgs e)
        {
            MenuForm frm = new MenuForm();
            frm.Show();
            this.Hide();
        }
    }
}
