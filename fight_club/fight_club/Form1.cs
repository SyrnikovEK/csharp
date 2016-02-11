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
        public frmGame()
        {
            InitializeComponent();

            //BodyPart firstPlPunchChoosenPart;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        //  will be deleted-------------------------------------------------------------------------


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_1st_punch_body.ChangeMark();
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_1st_punch_feet.ChangeMark();
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_1st_punch_lefthand.ChangeMark();
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_1st_punch_righthand.ChangeMark();
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
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_1st_block_body.ChangeMark();
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_1st_block_feet.ChangeMark();
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_1st_block_lefthand.ChangeMark();
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_1st_block_righthand.ChangeMark();
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
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_2nd_punch_body.ChangeMark();
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_2nd_punch_feet.ChangeMark();
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_2nd_punch_lefthand.ChangeMark();
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_2nd_punch_righthand.ChangeMark();
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
                        break;
                    }
                case BodyPart.Body:
                    {
                        btn_2nd_block_body.ChangeMark();
                        break;
                    }
                case BodyPart.Feet:
                    {
                        btn_2nd_block_feet.ChangeMark();
                        break;
                    }
                case BodyPart.LeftHand:
                    {
                        btn_2nd_block_lefthand.ChangeMark();
                        break;
                    }
                case BodyPart.RightHand:
                    {
                        btn_2nd_block_righthand.ChangeMark();
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



        //  /will be deleted-------------------------------------------------------------------------
    }
}
