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
    public partial class LoadSecondPlayerForm : Form
    {
        public LoadSecondPlayerForm()
        {
            InitializeComponent();
        }

        private void LoadSecondPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginSecondPlayerButton_Click(object sender, EventArgs e)
        {
            CombatForm frm = new CombatForm();
            frm.Show();
            this.Hide();
        }
    }
}
