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
        Rectangle theperson; // theperson
        Rectangle therocket; // Rocket
        Random speed = new Random(); //speed of platforms 1's
        Random speed2 = new Random(); //speed of platform 2's
        Random speed3 = new Random(); //speed of platform 3's
        Image platform = Image.FromFile(Application.StartupPath + @"\platform.jpg");// graphics for platform 1
        Image platform2 = Image.FromFile(Application.StartupPath + @"\platform.jpg");// graphics for platform 2
        Image platform3 = Image.FromFile(Application.StartupPath + @"\platform.jpg");// graphics for platform 3
        Image person = Image.FromFile(Application.StartupPath + @"\person.png");// graphics for person/character
        Image rocket = Image.FromFile(Application.StartupPath + @"\rocket.png");// graphics for rocket
        int x1 = 200, y = 100;// starting location for platform 1
        int x2 = 200, y2 = 200;// starting location for platform 2
        int x3 = 200, y3 = 300;// starting location for platform 3
        int xp = 200, yp = 200;// starting location for person
        int score = 0;// score int
        int diffcontrol = 50; // default difficulty int
        int difftime = 1; // difficulty default time
        int[] platformSpeed = new int[3]; //Speed of platform 1's  
        int[] platform2Speed = new int[3];//Speed of platform 2's
        int[] platform3Speed = new int[3]; //Speed of platforms 3's
        bool left, right, gravity = true, jump, jumpdelay = false; // controls for left, right, gravity affecting player, jump, should jump be delayed
        int highscore; // highscore, doesnt save over games
        string user; // username
        bool movingdown; // Is the player moving down?
        int leg1, leg2, leg3; // length of platforms
        int gp1, gp2, gp3; // controls gaps between platforms
        bool ingame; // is the player ingame
        private void TmrPerson_Tick(object sender, EventArgs e)
        {
            if (left) // move the player left
            {
                    if (theperson.X < 10)
                    {
                        theperson.X = 10;
                    }
                    else
                    {
                        theperson.X -= 10;
                    }
            }

            if (right)  // move the player right
            {
                    if (theperson.X > PnlGame.Width - 40)
                    {
                        theperson.X = PnlGame.Width - 40;
                        theperson.X = PnlGame.Width - 40;
                    }
                    else
                    {
                        theperson.X += 10;
                    }
            }
            if (theperson.Y < -10) 
            {
                //theperson.Y -= -10;
            }
            if (jump == true) // jump if jump is true
            {
                gravity = false;
                TmrJump.Enabled = true;
                jumpdelay = true;
            }
            if (jumpdelay == true) // if jump true do nothing
            {

            }
            else // if jump isnt true gravity is a thing
            {
                gravity = true;
            }
        }

        void Gameover() //method to play when game is over.
        {
            TmrPerson.Enabled = false;
            ingame = false;
            TmrPlatform.Enabled = false;
            theperson.Y = yp - 40;
            theperson.X = xp - 40;
            Invalidate();
            if (score >= highscore) // set highscore
            {
                highscore = score;
            }
            MessageBox.Show("Game Over " + user + " you scored a whooping score of " + score);
            // reset game (Still in progress)
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


        private void BtnStart_Click(object sender, EventArgs e) // if button start is clicked
        {
            ingame = true;
            Gamestart();
            user = TbUser.Text;
            score = 0;
            theperson.Y = yp - 40;
            theperson.X = xp - 40;
        }


        private void Form1_Load(object sender, EventArgs e) // instructions to play beofre game apears
        {
            MessageBox.Show("Instructions. \n The aim is dont die, dont fall into the void. \n 1. Press Space To Jump \n 2.Arrow Keys to control left and right \n \n Difficulty: \n Difficulty can be selected by entering a number between 1 and 9, \n 2 is default and 9 is extreme. \n Note higher the score the higher the XP is earned");
            MessageBox.Show("Please Enter Username Before You Begin \n \n \n \n \n \n \n \n OR ELSE!");
        }

        private void BtnInstruction_Click(object sender, EventArgs e) // Instructions if player wishes to read them again
        {
            MessageBox.Show("Instructions. \n The aim is dont die, dont fall into the void. \n 1. Press Space To Jump \n 2.Arrow Keys to control left and right \n \n Difficulty: \n Difficulty can be selected by entering a number between 1 and 9, \n 2 is default and 9 is extreme. \n Note higher the score the higher the XP is earned");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // if a key is pressed, controls movement
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Space) { if (jumpdelay == false) { jump = true; } }

        }

        private void BtnConfrimDiff_Click(object sender, EventArgs e) // Changes difficulty if player clicks confirm difficulty, otherwise its default at 2
        {
            int diff = Int32.Parse(TbDiff.Text);
            Lbldiffmin.Text = diff.ToString();
            TmrPlatform.Interval = 100 / diff;
            TmrGravity.Interval = 100 / diff;
            diffcontrol = 100 / diff;
        }

        private void TbDiff_Leave(object sender, EventArgs e) // If the player trys to leave text box blank, if not blank change diff int
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

        private void TbDiff_TextChanged(object sender, EventArgs e) // if the person trys to enter something that isnt a number or leave it blank
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TbDiff.Text, "[^0-9]")&& TbDiff.Text != null)
            {
                MessageBox.Show("Please enter only numbers.");
                TbDiff.Text = TbDiff.Text.Remove(TbDiff.Text.Length - 1);
            }
        }

        private void TmrJump_Tick(object sender, EventArgs e) //Tmr to control jump
        {
            DelayJump();
        }

        void DelayJump() //Method for the delay of the jump
        {
            TmrJump.Enabled = false;
            jump = false;
            gravity = true;
        }

        private void TmrGravity_Tick(object sender, EventArgs e) // Controls gravity for the game
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

        private void Form1_KeyUp(object sender, KeyEventArgs e) // if the player release a key, controls movements
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Space) { jump = false; }
        }

        private void TmrPlatform_Tick(object sender, EventArgs e) // controls the movement of the platforms, and if the player intersects with the platform, and rocket.
        {
            if (movingdown == false) // if the player intesects with the platform from the bottom repulse the character downwards.
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
            if (movingdown == true) // if the player intersects with the platfrom from the top repluse the character upwards
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
            if (right == true) // if the player intersects with the platform from the right, repluse the character left
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (theperson.IntersectsWith(area[i]))
                    {
                        theperson.X = theperson.X - 40;
                    }
                }
                for (int o = 0; o <= 2; o++)
                {
                    if (theperson.IntersectsWith(area2[o]))
                    {
                        theperson.X = theperson.X - 40;
                    }
                }
                for (int p = 0; p <= 2; p++)
                {
                    if (theperson.IntersectsWith(area3[p]))
                    {
                        theperson.X = theperson.X - 40;
                    }
                }
            }
            if (left == true) // if the player intersects with the platform from the left, repulse the character right
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (theperson.IntersectsWith(area[i]))
                    {
                        theperson.X = theperson.X + 40;
                    }
                }
                for (int o = 0; o <= 2; o++)
                {
                    if (theperson.IntersectsWith(area2[o]))
                    {
                        theperson.X = theperson.X + 40;
                    }
                }
                for (int p = 0; p <= 2; p++)
                {
                    if (theperson.IntersectsWith(area3[p]))
                    {
                        theperson.X = theperson.X + 40;
                    }
                }
            } 
            // platform movement
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
            
            for (int i = 0; i <= 2; i++)  // if the platform exits the screen give a point
            {
                if (area[i].X < -200)
                {
                    score += 1; //add 1 to score
                    LblScore.Text = score.ToString(); //display score on form

                    area[i].X = 800;
                }
            }
            for (int o = 0; o <= 2; o++) // if the platform exits the screen give a point
            {
                if (area2[o].X < -200)
                {
                    score += 1; //add 1 to score
                    LblScore.Text = score.ToString(); //display score on form

                    area2[o].X = 800;
                }
            }
            for (int p = 0; p <= 2; p++) // if the platform exits the screen give a point
            {
                if (area3[p].X < -200)
                {
                    score += 1; //add 1 to score
                    LblScore.Text = score.ToString(); //display score on form

                    area3[p].X = 800;
                }
            }
            therocket.X += 40;
            if (therocket.X > 800) // if the rocket exits the screen
            {
                score += 1; //add 1 to score
                LblScore.Text = score.ToString(); //display score on form
                Random rocketlayer = new Random();
                int rcktlayer = rocketlayer.Next(25, 375);
                therocket.Y = rcktlayer;
                therocket.X = -100;
            }
            if (theperson.IntersectsWith(therocket))
            {
                Gameover();
            }
            if (ingame == true) // is the person ingame
            {
                if (theperson.Y > 550) // is the person lower than 500, if so game over.
                {
                    Gameover(); // game over method
                }
            }
        }
        public Form1()
        {
            Random rndgap = new Random();
            int gap = rndgap.Next(240, 360);
            Random rndgap2 = new Random();
            int gap2 = rndgap2.Next(240, 360);
            Random rndgap3 = new Random();
            int gap3 = rndgap3.Next(240, 360);
            for (int i = 0; i <= 2; i++)
            {
                platformSpeed[i] = speed.Next(800, 1200); //each platform has a random speed between 800 and 1200
                area[i] = new Rectangle(x1 + gap * i, y, 150, 20);
            }
            for (int o = 0; o <= 2; o++)
            {
                platform2Speed[o] = speed2.Next(800, 1200); //each platform has a random speed between 800 and 1200
                area2[o] = new Rectangle(x2 + gap2 * o, y2, 150, 20);
            }
            for (int p = 0; p <= 2; p++)
            {
                platform3Speed[p] = speed3.Next(800, 1200); //each platform has a random speed between 800 and 1200
                area3[p] = new Rectangle(x3 + gap3 * p, y3, 150, 20);
            }
            theperson = new Rectangle(xp - 40, yp - 40, 20, 20);
            therocket = new Rectangle(xp - 40, yp - 40, 70, 40);
            Random pltchng = new Random();
            InitializeComponent();
            leg1 = 150;
            leg2 = 150;
            leg3 = 150;
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
        void Gamestart() // start the game
        {
            BtnStart.Enabled = false;
            BtnInstruction.Enabled = false;
            TbUser.Enabled = false;
            TmrPerson.Enabled = true;
            TmrPlatform.Enabled = true;
            TmrGravity.Enabled = true;
            TbDiff.Enabled = false;
            BtnConfrimDiff.Enabled = false;
        }
    }
}
