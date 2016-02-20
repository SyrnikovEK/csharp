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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        public object globalvar;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PveEnterButton_Click(object sender, EventArgs e)
        {
            CombatForm frm = new CombatForm();
            frm.Show();
            this.Hide();
        }

        private void PvpEnterButton_Click(object sender, EventArgs e)
        {
            LoadSecondPlayerForm frm = new LoadSecondPlayerForm();
            frm.Show();
            this.Hide();
        }

        private void RecordTableButton_Click(object sender, EventArgs e)
        {
            RecordTableForm frm = new RecordTableForm();
            frm.Show();
            this.Hide();
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm frm = new AuthorizationForm();
            frm.Show();
            this.Hide();
        }
    }
}
