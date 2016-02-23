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
    public partial class MenuUserControl : BaseUserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
            
        }

        private void PveEnterButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Combat);
        }

        private void PvpEnterButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Combat);
        }

        private void RecordTableButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.RecordTable);
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Autorization);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
