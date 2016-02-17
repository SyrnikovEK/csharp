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
        int allstats = 8;
        public int freestats = 5;
        int oldstr = 1;
        int oldstm = 1;
        int oldagi = 1;
        int str = 1;
        int agi = 1;
        int stm = 1;
        public PlayerCreationForm()
        {
            InitializeComponent();
            DrawFreeStats();
        }

        void ValueChangeHandler(object sender, EventArgs e)
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

        private void AgilityValue_ValueChanged(object sender, EventArgs e)
        {
            if ((allstats - str - (int)AgilityValue.Value - stm) < 0)
            {
                AgilityValue.Value = oldagi;
            }
            else
            {
                agi = (int)AgilityValue.Value;
                freestats = allstats - str - agi - stm;
                oldagi = agi;
            }        
            DrawFreeStats();
        }

        private void StaminaValue_ValueChanged(object sender, EventArgs e)
        {
            if ((allstats - str - agi - (int)StaminaValue.Value) < 0)
            {
                StaminaValue.Value = oldstm;
            }
            else
            {
                stm = (int)StaminaValue.Value;
                freestats = allstats - str - agi - stm;
                oldstm = stm;
            }
            DrawFreeStats();
        }

        private void StraightValue_ValueChanged(object sender, EventArgs e)
        {
            if ((allstats - (int)StraightValue.Value - agi - stm) < 0)
            {
                StraightValue.Value = oldstr;
            }
            else
            {
                str = (int)StraightValue.Value;
                freestats = allstats - str - agi - stm;
                oldstr = str;
            }
            DrawFreeStats();
        }

        void DrawFreeStats()
        {
            LastStatsLabel.Text = freestats.ToString();
        }
    }
}
