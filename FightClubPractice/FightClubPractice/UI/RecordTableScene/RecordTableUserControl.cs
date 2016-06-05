using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FightClubPractice.Game;
using FightClubPractice.Repository;

namespace FightClubPractice.UI.RecordTableScene
{
    public partial class RecordTableUserControl : BaseUserControl
    {
        Player player1;
        PlayerRepository repos = new PlayerRepository();
        public RecordTableUserControl()
        {
            InitializeComponent();            
            RecordTable.DataSource = repos.GetAll().ToList();
            RecordTable.Refresh();
        }

        public RecordTableUserControl(object par)
        {
            InitializeComponent();

            RecordTable.DataSource = repos.GetAll().ToList();
            player1 = (Player)par;
        }

        private void RecordTableUserControl_Load(object sender, EventArgs e)
        {

        }

        private void ToMenu_Click(object sender, EventArgs e)
        {
            SwitchScene(Scene.Menu, player1);
        }

        private void RecordTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
