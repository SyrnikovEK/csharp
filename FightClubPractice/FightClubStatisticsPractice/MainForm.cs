using FightClubStatisticsPractice.UI;
using FightClubStatisticsPractice.UI.CombatLogScene;
using FightClubStatisticsPractice.UI.HitLogScene;
using FightClubStatisticsPractice.UI.MenuScene;
using FightClubStatisticsPractice.UI.PlayerScene;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubStatisticsPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //playerRepository = new PlayerRepository();
            SwitchScene(Scene.MenuScene);
        }

        public void SwitchScene(Scene scene)
        {
            BaseUserControl ctrl = null;
            switch (scene)
            {
                case Scene.MenuScene:
                    {
                        ctrl = new MenuUserControl();
                        break;
                    }
                case Scene.PlayerScene:
                    {
                        ctrl = new PlayerControl();
                        break;
                    }
                case Scene.PlayerEditScene:
                    {
                        ctrl = new PlayerEditControl();
                        break;
                    }
                case Scene.CombatLogScene:
                    {
                        ctrl = new CombatLogUserControl();
                        break;
                    }
                case Scene.HitLogScene:
                    {
                        ctrl = new HitLogUserControl();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }


            if (ctrl != null)
            {
                this.MinimumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                this.MaximumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                mainPanel.Height = ctrl.Height + 20;
                mainPanel.Width = ctrl.Width + 15;
                this.Text = ctrl.Name.ToString();
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
                ctrl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);

            }
        }

        public void SwitchScene(Scene scene, Object param)
        {
            BaseUserControl ctrl = null;
            switch (scene)
            {
                case Scene.PlayerScene:
                    {
                        ctrl = new PlayerControl();
                        break;
                    }
                case Scene.PlayerEditScene:
                    {
                        ctrl = new PlayerEditControl(param);
                        break;
                    }
                case Scene.CombatLogScene:
                    {
                        ctrl = new CombatLogUserControl(param);
                        break;
                    }
                case Scene.HitLogScene:
                    {
                        ctrl = new HitLogUserControl(param);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }


            if (ctrl != null)
            {
                this.MinimumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                this.MaximumSize = new Size(ctrl.Width + 15, ctrl.Height + 20);
                mainPanel.Height = ctrl.Height + 20;
                mainPanel.Width = ctrl.Width + 15;
                this.Text = ctrl.Name.ToString();
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
                ctrl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);

            }
        }
    }
}