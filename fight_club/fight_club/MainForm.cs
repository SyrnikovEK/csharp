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
    public enum Scene
    {
        Autorization,
        PlayerCreation,
        Menu,
        Combat,
        RecordTable,
        SecondPlayerLoad
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SwitchScene(Scene.Autorization);
        }

        public void SwitchScene(Scene scene)
        {
            BaseUserControl ctrl = null;
            switch (scene)
            {
                case Scene.Autorization:
                    {
                        ctrl = new AutorizationUserControl();
                        break;
                    }
                case Scene.Combat:
                    {
                        ctrl = new CombatUserControl();
                        break;
                    }
                case Scene.Menu:
                    {
                        ctrl = new MenuUserControl();
                        break;
                    }
                case Scene.PlayerCreation:
                    {
                        ctrl = new PlayerCreationUserControl();
                        break;
                    }
                case Scene.RecordTable:
                    {
                        ctrl = new RecordTableUserControl();
                        break;
                    }
                case Scene.SecondPlayerLoad:
                    {
                        ctrl = new SecondPlayerLoadUserControl();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (ctrl != null)
            {
                ////this.Height = ctrl.Height;
                ////this.Width = ctrl.Width;
                mainPanel.Height = ctrl.Height;
                mainPanel.Width = ctrl.Width;
                ctrl.Dock = DockStyle.Fill;                
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
