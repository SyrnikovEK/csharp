using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fight_club
{
    public partial class SecondPlayerLoadUserControl : BaseUserControl
    {
        public SecondPlayerLoadUserControl()
        {
            InitializeComponent();
        }

        private void LoginSecondPlayerButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Combat);
        }

        private void PlaerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsLetter(e.KeyChar)) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }

}
