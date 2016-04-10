﻿using FightClubStatistics.UI.UserScene;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubStatistics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SwitchScene(Scene.UserScene);
        }

        public void SwitchScene(Scene scene)
        {
            BaseUserControl ctrl = null;
            switch (scene)
            {
                case Scene.Autorization:
                    {
                        break;
                    }
                case Scene.UserScene:
                    {
                        ctrl = new UserUserControl();
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
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2);
                ctrl.Dock = DockStyle.Fill;
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(ctrl);

            }
        }
    }
}
