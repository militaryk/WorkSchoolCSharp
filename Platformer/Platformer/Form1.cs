using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Platformer
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle[] area = new Rectangle[3];//area[0] to area[3]
        Rectangle[] area2 = new Rectangle[3];//area[0] to area[3]
        Rectangle[] area3 = new Rectangle[3];//area[0] to area[3]
        Rectangle theperson;
        Rectangle therocket;
        Random speed = new Random();
        Random speed2 = new Random();
        Random speed3 = new Random();
        Image platform = Image.FromFile(Application.StartupPath + @"\platform.png");
        Image platform2 = Image.FromFile(Application.StartupPath + @"\platform.png");
        Image platform3 = Image.FromFile(Application.StartupPath + @"\platform.png");
        Image person = Image.FromFile(Application.StartupPath + @"\person.jpg");
        Image rocket = Image.FromFile(Application.StartupPath + @"\tjrocket.png");
        int x1 = 200, y = 100;
        int x2 = 200, y2 = 200;
        int x3 = 200, y3 = 300;
        int xp = 200, yp = 200;
        int score = 0;
        int diffcontrol = 50;
        int difftime = 1;
        int[] platformSpeed = new int[3];
        int[] platform2Speed = new int[3];
        int[] platform3Speed = new int[3];
        bool left, right, gravity = true, jump, jumpdelay = false;
        int highscore;
        bool movingdown;
        string user;
        int leg1, leg2, leg3;
        int gp1, gp2, gp3;
        bool ingame;
        int platformchange = 1;
        private void TmrPerson_Tick(object sender, EventArgs e)
        {
            if (left)
            {
                if (left) // if left arrow pressed
                {
                    if (theperson.X < 10) //check to see if person within 10 of left side
                    {
                        theperson.X = 10;
                    }
                    else
                    {
                        theperson.X -= 10; //else move 5 to the left
                    }
                }
            }

            if (right)
            {
                if (right) // if left arrow pressed
                {
                    if (theperson.X > PnlGame.Width - 40)// is person within 40 of right side
                    {
                        theperson.X = PnlGame.Width - 40;
                        theperson.X = PnlGame.Width - 40;
                    }
                    else
                    {
                        theperson.X += 10; //else move 5 to the left
                    }
                }
            }
            if (theperson.Y < -10)// is person within 40 of right side
            {
                theperson.Y -= -10;
            }
            if (ingame == true)
            {
                if (theperson.Y > 550)
                {
                    Gameover();
                }
            }
            if (jump == true)
            {
                gravity = false;
                TmrJump.Enabled = true;
                jumpdelay = true;
            }
            if (jumpdelay == true)
            {

            }
            else
            {
                gravity = true;
            }
        }

        void Gameover()
        {
            TmrPerson.Enabled = false;
            ingame = false;
            TmrPlatform.Enabled = false;
            theperson.Y = 800;
            if (score >= highscore)
            {
                highscore = score;
            }
            MessageBox.Show("Game Over " + user + " you scored a whooping score of " + score);
            theperson = new Rectangle(xp - 40, yp - 40, 20, 20);
            for (int i = 0; i <= 2; i++)
            {
                area[i] = new Rectangle(x1 + gp1 * i, y, leg1, 20);
            }
            for (int o = 0; o <= 2; o++)
            {
                area2[o] = new Rectangle(x2 + gp2 * o, y2, leg2, 20);
            }
            for (int p = 0; p <= 2; p++)
            {
                area3[p] = new Rectangle(x3 + gp3 * p, y3, leg3, 20);
            }
            InitializeComponent();
            BtnStart.Enabled = true;
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            ingame = true;
            Gamestart();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions. \n The aim is dont die, dont fall into the void. \n 1. Press Space To Jump \n 2.Arrow Keys to control left and right \n \n Difficulty: \n Difficulty can be selected by entering a number between 1 and 9, \n 1 is default and 9 is extreme. \n Note higher the score the higher the XP is earned");
            MessageBox.Show("Please Enter Username Before You Begin \n \n \n \n \n \n \n \n OR ELSE!");
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions. \n The aim is dont die, dont fall into the void. \n 1. Press Space To Jump \n 2.Arrow Keys to control left and right \n \n Difficulty: \n Difficulty can be selected by entering a number between 1 and 9, \n 1 is default and 9 is extreme. \n Note higher the score the higher the XP is earned");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Space) { if (jumpdelay == false) { jump = true; } }

        }

        void HideGame()
        {
            PnlGame.Visible = false;
            BtnConfirm.Visible = false;
            BtnStart.Visible = false;
            BtnStop.Visible = false;
            LblScore.Visible = false;
            LblUser.Visible = false;
            TbUser.Visible = false;
            BtnConfrimDiff.Visible = true;
            LblDiff.Visible = true;
            LblDiffDet.Visible = true;
            TbDiff.Visible = true;
        }

        void ShowGame()
        {
            PnlGame.Visible = true;
            BtnConfirm.Visible = true;
            BtnStart.Visible = true;
            BtnStop.Visible = true;
            LblScore.Visible = true;
            LblUser.Visible = true;
            TbUser.Visible = true;
            BtnConfrimDiff.Visible = false;
            LblDiff.Visible = false;
            LblDiffDet.Visible = false;
            TbDiff.Visible = false;
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            HideGame();
            BtnConfrimDiff.Visible = true;
            LblDiff.Visible = true;
            LblDiffDet.Visible = true;
            TbDiff.Visible = true;
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            ShowGame();
        }

        private void BtnConfrimDiff_Click(object sender, EventArgs e)
        {
            int diff = Int32.Parse(TbDiff.Text);
            Lbldiffmin.Text = diff.ToString();
            TmrPlatform.Interval = 100 / diff;
            TmrGravity.Interval = 100 / diff;
            diffcontrol = 100 / diff;
        }

        private void TbDiff_Leave(object sender, EventArgs e)
        {
            if (TbDiff.Text == "")
            {
                MessageBox.Show("Please Enter Something");
            }
            else
            {
                int TbCheck = Int32.Parse(TbDiff.Text);
                if (TbCheck > 9)
                {
                    TbDiff.Text = TbDiff.Text.Remove(TbDiff.Text.Length - TbDiff.Text.Length);
                    int diff = Int32.Parse(TbDiff.Text);
                }
            }
        }

        private void TbDiff_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TbDiff.Text, "[^0-9]")&& TbDiff.Text != null)
            {
                MessageBox.Show("Please enter only numbers.");
                TbDiff.Text = TbDiff.Text.Remove(TbDiff.Text.Length - 1);
            }
        }

        private void TmrPlatformChange_Tick(object sender, EventArgs e)
        {
            TmrPlatformChange.Interval = platformchange;
            Random pltchange = new Random();
            int pltchng = pltchange.Next(1, 3);
            if (pltchng == 1)
            {
                for (int i = 0; i <= 2; i++)
                {
                    PnlGame.Invalidate();
                }
            }
            if (pltchng == 3)
            {
                for (int o = 0; o <= 2; o++)
                {
                    PnlGame.Invalidate();
                }
            }
            if (pltchng == 2)
            {
                for (int p = 0; p <= 2; p++)
                {
                    PnlGame.Invalidate();
                }
            }

        }

        private void TmrDiff_Tick(object sender, EventArgs e)
        {
            difftime += 1;
            TmrPlatform.Interval = diffcontrol / difftime;
            TmrGravity.Interval = diffcontrol / difftime;
        }

        private void TmrJump_Tick(object sender, EventArgs e)
        {
            DelayJump();
        }

        void DelayJump()
        {
            TmrJump.Enabled = false;
            jump = false;
            gravity = true;
        }

        private void TmrGravity_Tick(object sender, EventArgs e)
        {
            if (gravity == true)
            {
                theperson.Y += 10;
                movingdown = true;
            }
            if (gravity == false)
            {
                theperson.Y -= 10;
                movingdown = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Space) { jump = false; }
        }

        private void TmrPlatform_Tick(object sender, EventArgs e)
        {
            if (movingdown == false)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (theperson.IntersectsWith(area[i]))
                    {
                        theperson.Y = theperson.Y + 10;
                        DelayJump();
                    }
                }
                for (int o = 0; o <= 2; o++)
                {
                    if (theperson.IntersectsWith(area2[o]))
                    {
                        theperson.Y = theperson.Y + 10;
                        DelayJump();
                    }
                }
                for (int p = 0; p <= 2; p++)
                {
                    if (theperson.IntersectsWith(area3[p]))
                    {
                        theperson.Y = theperson.Y + 10;
                        DelayJump();
                    }
                }
            }
            if (movingdown == true)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (theperson.IntersectsWith(area[i]))
                    {
                        theperson.Y = theperson.Y - 10;
                        jumpdelay = false;
                    }
                }
                for (int o = 0; o <= 2; o++)
                {
                    if (theperson.IntersectsWith(area2[o]))
                    {
                        theperson.Y = theperson.Y - 10;
                        jumpdelay = false;
                    }
                }
                for (int p = 0; p <= 2; p++)
                {
                    if (theperson.IntersectsWith(area3[p]))
                    {
                        theperson.Y = theperson.Y - 10;
                        jumpdelay = false;
                    }
                } 
            }
            if (right == true)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (theperson.IntersectsWith(area[i]))
                    {
                        theperson.X = theperson.X - 10;
                    }
                }
                for (int o = 0; o <= 2; o++)
                {
                    if (theperson.IntersectsWith(area2[o]))
                    {
                        theperson.X = theperson.X - 10;
                    }
                }
                for (int p = 0; p <= 2; p++)
                {
                    if (theperson.IntersectsWith(area3[p]))
                    {
                        theperson.X = theperson.X - 10;
                    }
                }
            }
            if (left == true)
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (theperson.IntersectsWith(area[i]))
                    {
                        theperson.X = theperson.X + 10;
                    }
                }
                for (int o = 0; o <= 2; o++)
                {
                    if (theperson.IntersectsWith(area2[o]))
                    {
                        theperson.X = theperson.X + 10;
                    }
                }
                for (int p = 0; p <= 2; p++)
                {
                    if (theperson.IntersectsWith(area3[p]))
                    {
                        theperson.X = theperson.X + 10;
                    }
                }
            }
            for (int i = 0; i <= 2; i++)
            {
                area[i].X -= platformSpeed[i];
            }
            for (int o = 0; o <= 2; o++)
            {
                area2[o].X -= platform2Speed[o];
            }
            for (int p = 0; p <= 2; p++)
            {
                area3[p].X -= platform3Speed[p];
            }
            PnlGame.Invalidate();
            for (int i = 0; i <= 2; i++)
            {
                if (area[i].X < -200)
                {
                    score += 1; //add 1 to score
                    LblScore.Text = score.ToString(); //display score on form

                    area[i].X = 800;
                }
            }
            for (int o = 0; o <= 2; o++)
            {
                if (area2[o].X < -200)
                {
                    score += 1; //add 1 to score
                    LblScore.Text = score.ToString(); //display score on form

                    area2[o].X = 800;
                }
            }
            for (int p = 0; p <= 2; p++)
            {
                if (area3[p].X < -200)
                {
                    score += 1; //add 1 to score
                    LblScore.Text = score.ToString(); //display score on form

                    area3[p].X = 800;
                }
            }
            therocket.X += 40;
            if (therocket.X > 800)
            {
                score += 1; //add 1 to score
                LblScore.Text = score.ToString(); //display score on form
                Random rocketlayer = new Random();
                int rcktlayer = rocketlayer.Next(25, 375);
                therocket.Y = rcktlayer;
                therocket.X = -200;
            }
            if (theperson.IntersectsWith(therocket))
            {
                Gameover();
            }
        }
        public Form1()
        {
            Random rndgap = new Random();
            int gap = rndgap.Next(300, 300);
            Random rndgap2 = new Random();
            int gap2 = rndgap2.Next(300, 300);
            Random rndgap3 = new Random();
            int gap3 = rndgap3.Next(300, 300);
            Random rndlength1 = new Random();
            int length1 = rndlength1.Next(150, 150);
            Random rndlength2 = new Random();
            int length2 = rndlength2.Next(150, 150);
            Random rndlength3 = new Random();
            int length3 = rndlength3.Next(150, 150);
            for (int i = 0; i <= 2; i++)
            {
                platformSpeed[i] = speed.Next(1000, 1000); //each platform has a random speed
                area[i] = new Rectangle(x1 + gap * i, y, length1, 20);
            }
            for (int o = 0; o <= 2; o++)
            {
                platform2Speed[o] = speed2.Next(1000, 1000); //each platform has a random speed
                area2[o] = new Rectangle(x2 + gap2 * o, y2, length2, 20);
            }
            for (int p = 0; p <= 2; p++)
            {
                platform3Speed[p] = speed3.Next(1000, 1000);
                area3[p] = new Rectangle(x3 + gap3 * p, y3, length3, 20);
            }
            theperson = new Rectangle(xp - 40, yp - 40, 20, 20);
            therocket = new Rectangle(xp - 40, yp - 40, 140, 100);
            Random pltchng = new Random();
            platformchange = pltchng.Next(8000, 20000);
            InitializeComponent();
            leg1 = length1;
            leg2 = length2;
            leg3 = length3;
            gap = gp1;
            gap2 = gp2;
            gap3 = gp3;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            g.DrawImage(person, theperson);
            g.DrawImage(rocket, therocket);
            //use the DrawImage method to draw the platform on the panel
            for (int i = 0; i <= 2; i++)
            {
                g.DrawImage(platform, area[i]);
            }
            for (int o = 0; o <= 2; o++)
            {
                g.DrawImage(platform2, area2[o]);
            }
            for (int i = 0; i <= 2; i++)
            {
                g.DrawImage(platform3, area3[i]);
            }
            for (int i = 0; i <= 2; i++)
            {
                platformSpeed[i] = speed.Next(10, 20); //each platform has a random speed
            }
            for (int o = 0; o <= 2; o++)
            {
                platform2Speed[o] = speed2.Next(10, 20); //each platform has a random speed
            }
            for (int p = 0; p <= 2; p++)
            {
                platform3Speed[p] = speed2.Next(10, 20); //each platform has a random speed
            }
        }
        void Gamestart()
        {
            BtnStart.Enabled = false;
            BtnStop.Enabled = false;
            BtnConfirm.Enabled = false;
            TbUser.Enabled = false;
            TmrPerson.Enabled = true;
            TmrPlatform.Enabled = true;
            TmrGravity.Enabled = true;
            TbDiff.Enabled = false;
            BtnConfrimDiff.Enabled = false;
        }


































































































































































































































































































































































































































































































    }
}
