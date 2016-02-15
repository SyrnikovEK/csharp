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
    public partial class frmGame : Form
    {
        public GameControl game = new GameControl();
        public BodyPart firstPlPunchChoosenPart;
        public BodyPart firstPlBlockChoosenPart;
        public BodyPart secondPlPunchChoosenPart;
        public BodyPart secondPlBlockChoosenPart;
        public frmGame()
        {
            InitializeComponent();
            prbar_1st_hp.Maximum = game.player1.MaxHp;
            prbar_1st_hp.Value = game.player1.Hp;
            prbar_2nd_hp.Maximum = game.player2.MaxHp;
            prbar_2nd_hp.Value = game.player2.Hp;
            lbl_1st_hp.Text = game.player1.Hp + " / " + game.player1.MaxHp;
            lbl_2nd_hp.Text = game.player2.Hp + " / " + game.player2.MaxHp;
            lbl_1st_name.Text = game.player1.Name;
            lbl_2nd_name.Text = game.player2.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (game.player2 is NPC)
            {
                pnl_2nd_player.Enabled = false;
            }
        }
        

        //  -------------------------------------------------------------------------


        #region Обработка заполнения выбора ударов
        public void Player1PunchClean(BodyPart part)
        {
            btn_1st_punch_head.UnMark();
            btn_1st_punch_body.UnMark();
            btn_1st_punch_feet.UnMark();
            btn_1st_punch_lefthand.UnMark();
            btn_1st_punch_righthand.UnMark();

            switch (part)
            {
                case BodyPart.Head:
                    {
                        btn_1st_punch_head.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.Head;
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_1st_punch_body.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.Body;
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_1st_punch_feet.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.Feet;
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_1st_punch_lefthand.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.LeftHand;
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_1st_punch_righthand.ChangeMark();
                        firstPlPunchChoosenPart = BodyPart.RightHand;
                        break;
                    }
                default:
                    break;
            }
        }

        public void Player1BlockClean(BodyPart part)
        {
            btn_1st_block_head.UnMark();
            btn_1st_block_body.UnMark();
            btn_1st_block_feet.UnMark();
            btn_1st_block_lefthand.UnMark();
            btn_1st_block_righthand.UnMark();

            switch (part)
            {
                case BodyPart.Head:
                    {
                        btn_1st_block_head.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.Head;
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_1st_block_body.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.Body;
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_1st_block_feet.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.Feet;
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_1st_block_lefthand.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.LeftHand;
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_1st_block_righthand.ChangeMark();
                        firstPlBlockChoosenPart = BodyPart.RightHand;
                        break;
                    }
                default:
                    break;
            }
        }

        public void Player2PunchClean(BodyPart part)
        {
            btn_2nd_punch_head.UnMark();
            btn_2nd_punch_body.UnMark();
            btn_2nd_punch_feet.UnMark();
            btn_2nd_punch_lefthand.UnMark();
            btn_2nd_punch_righthand.UnMark();

            switch (part)
            {
                case BodyPart.Head:
                    {
                        btn_2nd_punch_head.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.Head;
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_2nd_punch_body.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.Body;
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_2nd_punch_feet.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.Feet;
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_2nd_punch_lefthand.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.LeftHand;
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_2nd_punch_righthand.ChangeMark();
                        secondPlPunchChoosenPart = BodyPart.RightHand;
                        break;
                    }
                default:
                    break;
            }
        }

        public void Player2BlockClean(BodyPart part)
        {
            btn_2nd_block_head.UnMark();
            btn_2nd_block_body.UnMark();
            btn_2nd_block_feet.UnMark();
            btn_2nd_block_lefthand.UnMark();
            btn_2nd_block_righthand.UnMark();

            switch (part)
            {
                case BodyPart.Head:
                    {
                        btn_2nd_block_head.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.Head;
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_2nd_block_body.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.Body;
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_2nd_block_feet.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.Feet;
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_2nd_block_lefthand.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.LeftHand;
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_2nd_block_righthand.ChangeMark();
                        secondPlBlockChoosenPart = BodyPart.RightHand;
                        break;
                    }
                default:
                    break;
            }
        }

        #region HORROR(don't open!!!)
        private void button1_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.Head);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.Body);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.Feet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.LeftHand);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player1PunchClean(BodyPart.RightHand);
        }

        private void btn_1st_block_head_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.Head);
        }

        private void btn_1st_block_body_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.Body);
        }

        private void btn_1st_block_feet_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.Feet);
        }

        private void btn_1st_block_lefthand_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.LeftHand);
        }

        private void btn_1st_block_righthand_Click(object sender, EventArgs e)
        {
            Player1BlockClean(BodyPart.RightHand);
        }

        private void btn_2nd_punch_head_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.Head);
        }

        private void btn_2nd_punch_body_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.Body);
        }

        private void btn_2nd_punch_feet_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.Feet);
        }

        private void btn_2nd_punch_lefthand_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.LeftHand);
        }

        private void btn_2nd_punch_righthand_Click(object sender, EventArgs e)
        {
            Player2PunchClean(BodyPart.RightHand);
        }

        private void btn_2nd_block_head_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.Head);
        }

        private void btn_2nd_block_body_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.Body);
        }

        private void btn_2nd_block_feet_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.Feet);
        }

        private void btn_2nd_block_lefthand_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.LeftHand);
        }

        private void btn_2nd_block_righthand_Click(object sender, EventArgs e)
        {
            Player2BlockClean(BodyPart.RightHand);
        }


        #endregion

        #endregion

        private void btn_1st_endturn_Click(object sender, EventArgs e)
        {
            btn_1st_endturn.Enabled = false;
            pnl_1st_block.Enabled = false;
            pnl_1st_punch.Enabled = false;
            EndTurn();
        }

        private void btn_2nd_endturn_Click(object sender, EventArgs e)
        {
            btn_2nd_endturn.Enabled = false;
            pnl_2nd_block.Enabled = false;
            pnl_2nd_punch.Enabled = false;
            EndTurn();
        }

        public void EndTurn()
        {
            if ((!btn_1st_endturn.Enabled) && (!btn_2nd_endturn.Enabled))
            {
                string[] str = game.EndTurn(firstPlPunchChoosenPart, firstPlBlockChoosenPart, secondPlPunchChoosenPart, secondPlBlockChoosenPart);
                prbar_1st_hp.Value = game.player1.Hp;
                prbar_2nd_hp.Value = game.player2.Hp;
                lbl_1st_hp.Text = game.player1.Hp + " / " + (100 + (game.player1.Stamina - 1) * 5);
                lbl_2nd_hp.Text = game.player2.Hp + " / " + (100 + (game.player2.Stamina - 1) * 5);

                textlog.AppendText(str[0] + "\n");
                textlog.AppendText(str[1] + "\n");
                textlog.AppendText("----------------------------------------------------------------" + "\n");
                btn_1st_endturn.Enabled = true;
                btn_2nd_endturn.Enabled = true;
                pnl_1st_block.Enabled = true;
                pnl_1st_punch.Enabled = true;
                pnl_2nd_block.Enabled = true;
                pnl_2nd_punch.Enabled = true;
            }
        }




        //  -------------------------------------------------------------------------
    }
}
