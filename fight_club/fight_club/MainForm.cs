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
        public PlayersDB allPlayers;
        Player jack;
        public MainForm()
        {
            InitializeComponent();
            allPlayers = new PlayersDB();
            //allPlayers.Add(new Player(2, "Jack", 3, 3, 2));
            //PlayersSaver.Save(allPlayers);
            //allPlayers = PlayersSaver.Load();
            //if (allPlayers.IsExist("Jack"))
            //{
            //    jack = allPlayers.Get("jack");
            //    jack.AddExp(100);
            //    allPlayers.Replace("Jack", jack);
            //    label1.Text = jack.Exp.ToString();
            //}
                        
            //PlayersSaver.Save(allPlayers);
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
                this.Height = ctrl.Height + 20; // HOW???
                this.Width = ctrl.Width + 15;   // HOW???
                mainPanel.Height = ctrl.Height + 20;
                mainPanel.Width = ctrl.Width + 15;
                //this.pos                                   // how to refresh start pos?
                ctrl.Dock = DockStyle.Fill;                
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
