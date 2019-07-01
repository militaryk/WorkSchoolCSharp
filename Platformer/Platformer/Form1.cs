using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle[] area = new Rectangle[3];//area[0] to area[3]
        Rectangle[] area2 = new Rectangle[3];//area[0] to area[3]
        Rectangle[] area3 = new Rectangle[3];//area[0] to area[3]
        Rectangle theperson;
        Random speed = new Random();
        Random speed2 = new Random();
        Random speed3 = new Random();
        Image platform = Image.FromFile(Application.StartupPath + @"\platform.jpg");
        Image platform2 = Image.FromFile(Application.StartupPath + @"\platform.jpg");
        Image platform3 = Image.FromFile(Application.StartupPath + @"\platform.jpg");
        Image person = Image.FromFile(Application.StartupPath + @"\person.jpg");
        int x1 = 200, y = 100;
        int x2 = 200, y2 = 200;
        int x3 = 200, y3 = 300;
        int xp = 200, yp = 200;
        int score = 0;
        int[] platformSpeed = new int[3];
        int[] platform2Speed = new int[3];
        int[] platform3Speed = new int[3];
        bool left, right, gravity = true, jump, jumpdelay = false;
        int highscore;
        bool movingdown;
        string user;

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
            if (theperson.Y > 550)
            {
                Gameover();
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
            TmrPlatform.Enabled = false;
            if (score >= highscore)
            {
                highscore = score;
            }
            MessageBox.Show("Game Over " + user + " you scored a whooping score of " + score);
        }
        

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Gamestart();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions. \n The aim is dont die, dont fall into the void. \n 1. Press Space To Jump \n 2.Arrow Keys to control left and right");
            MessageBox.Show("Please Enter Username Before You Begin");
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions. \n The aim is dont die, dont fall into the void. \n 1. Press Space To Jump \n 2.Arrow Keys to control left and right");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Space) { if (jumpdelay == false) { jump = true; } }

        }

        private void TmrJump_Tick(object sender, EventArgs e)
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
                    }
                }
                for (int o = 0; o <= 2; o++)
                {
                    if (theperson.IntersectsWith(area2[o]))
                    {
                        theperson.Y = theperson.Y + 10;
                    }
                }
                for (int p = 0; p <= 2; p++)
                {
                    if (theperson.IntersectsWith(area3[p]))
                    {
                        theperson.Y = theperson.Y + 10;
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
        }
        public Form1()
        {
            Random rndgap = new Random();
            int gap = rndgap.Next(300, 300);
            Random rndgap2 = new Random();
            int gap2 = rndgap2.Next(300, 300);
            Random rndgap3 = new Random();
            int gap3 = rndgap3.Next(300, 300);
            theperson = new Rectangle(xp-40 , yp-40, 20, 20);
            for (int i = 0; i <= 2; i++)
            {
                platformSpeed[i] = speed.Next(10, 20); //each platform has a random speed
                area[i] = new Rectangle(x1 + gap * i, y, 150, 20);
            }
            for (int o = 0; o <= 2; o++)
            {
                platform2Speed[o] = speed2.Next(10, 20); //each platform has a random speed
                area2[o] = new Rectangle(x2 + gap2 * o, y2, 150, 20);
            }
            for (int p = 0; p <= 2; p++)
            {
                platform3Speed[p] = speed3.Next(10, 20);
                area3[p] = new Rectangle(x3 + gap3 * p, y3, 150, 20);
            }
            InitializeComponent();
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            g.DrawImage(person, theperson);
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
            BtnControl.Enabled = false;
            TmrPerson.Enabled = true;
            TmrPlatform.Enabled = true;
            TmrGravity.Enabled = true;
        }
    }
}
