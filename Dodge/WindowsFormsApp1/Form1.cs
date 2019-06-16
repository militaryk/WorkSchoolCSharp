using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g; // declare the graphics object
        int x = 20, y = 20;// starting position of planet
        //Declare the rectangles to display the spaceship and planets in
        int x2 = 50, y2 = 290; //starting position of spaceship
        int lx2 = 50, ly2 = 800;
        int ly = 290;
        int tillfire = 0;
        Random speed = new Random();
        int[] planetSpeed = new int[7];
        //Load our two images from the bin\debug folder
        Image spaceship = Image.FromFile(Application.StartupPath + @"\alien1.png");
        Image planet1 = Image.FromFile(Application.StartupPath + @"\planet1.png");
        Rectangle areaSpaceship;
        Rectangle fireingmalaser;
        Image malaser = Image.FromFile(Application.StartupPath + @"\red.png");
        Rectangle[] area = new Rectangle[7];//area[0] to area[6]
        bool left, right, firemylaser;
        bool fired = false;
        string user = null;
        int score;
        int lives = 5;
        int thehighscore;
        int minspeed = 0;
        int cheats = 0;
        int maxspeed = 0;
        int minrnd = 20;
        int maxrnd = 30;
        int clicky;
        int laserspeed = 40;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
                if (e.KeyData == Keys.Space)
                {
                    firemylaser = true;
                    fired = true;
                }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }
        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (left)
            {
                if (left) // if left arrow pressed
                {
                    if (areaSpaceship.X < 10) //check to see if spaceship within 10 of left side
                    {
                        areaSpaceship.X = 10;
                        fireingmalaser.X = 10;
                    }
                    else
                    {
                        areaSpaceship.X -= 5; //else move 5 to the left
                        if (fired == false)
                        {
                            fireingmalaser.X -= 5;
                        }
                    }
                }
            }//move ship 5 to the left
            if (right)
            {
                if (right) // if right arrow key pressed
                {
                    if (areaSpaceship.X > PnlGame.Width - 40)// is spaceship within 40 of right side
                    {
                        areaSpaceship.X = PnlGame.Width - 40;
                        fireingmalaser.X = PnlGame.Width - 40;
                    }
                    else
                    {
                        areaSpaceship.X += 5;
                        if (fired == false)
                        {
                            fireingmalaser.X += 5;
                        }
                        
                    }
                }
            }// move ship 5 to the right
            if (fireingmalaser.Y < -400)
            {
                firemylaser = false;
                ly = y2;
                laser.Enabled = false;
                fireingmalaser.X = areaSpaceship.X;
                fireingmalaser.Y = 800;
                fired = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
            areaSpaceship = new Rectangle(x2, y2, 30, 30);//spaceship's rectangle	
            fireingmalaser = new Rectangle(lx2, ly2, 30, 30);
            for (int i = 0; i <= 6; i++)
            {
                area[i] = new Rectangle(x + 70 * i, y, 40, 40);
                planetSpeed[i] = speed.Next(10, 20); //each planet has a random speed
            }


        }


        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left and right arrow keys to move the spaceship. \n Don't get hit by the planets! \n Every planet that goes past scores a point. \n If a planet hits a spaceship a life is lost!", "Game Instructions");

        }

        private void MnuStart_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string context = TxtName.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))// if current character not a letter
                {
                    isletter = false;//make isletter false
                    break; // exit the for loop
                }

            }

            // to enter name again
            if (isletter == false)
            {
                TxtName.Clear();
            }
            else
            {
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TmrShip.Enabled = false;
            TmrPlanet.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            minrnd = 20;
            maxrnd = 30;
            Random rnd = new Random();
            int difficulty = rnd.Next(minrnd, maxrnd);
            user = TxtName.Text;
            minspeed = 0;
            maxspeed = 0;
            clicky = 0;
            labeluser.Text = user;
            if ( user == "Person")
            {
                MessageBox.Show("Please enter username before you begin " + user);
            }
            else
            {
                score = 0; //when game starts set the score to 0
                LblScore.Text = score.ToString(); //display the score on the form
                TmrPlanet.Enabled = true; //start the timer to move the planets
                TmrShip.Enabled = true; //start the timer to move the spaceship
                TxtName.Enabled = false;
                button2.Enabled = false;
                confirm.Enabled = false;
                if (cheats == 1)
                {
                    Difficulty.Enabled = false;
                }
                if (cheats == 0)
                {
                    Difficulty.Enabled = true;
                }
                lives = 5;
                LblLives.Text = lives.ToString();
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            user = TxtName.Text;
            labeluser.Text = user;
            clicky = clicky + 1;
            if (user == "SHOWMETHEcheats")
            {
                if (clicky == 3)
                {
                    if (cheats == 1)
                    {
                        menuStrip1.Enabled = false;
                        menuStrip1.Visible = false;
                        clicky = 0;
                        cheats = 0;

                    }
                    if (cheats == 0)
                    {
                        menuStrip1.Enabled = true;
                        menuStrip1.Visible = true;
                        clicky = 0;
                        cheats = 1;
                    }
                }
            }

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void highscore_Click(object sender, EventArgs e)
        {

        }

        private void Difficulty_Tick(object sender, EventArgs e)
        {
            maxrnd += 5;
            minrnd -= 5;
            Random rnd = new Random();
            int difficulty = rnd.Next(minrnd, maxrnd);
            maxspeed += difficulty;
            minspeed += difficulty;
            for (int i = 0; i <= 6; i++)
            {
                planetSpeed[i] = speed.Next(minspeed, maxspeed); //each planet has a random speed
            }
        }

        private void TxtName_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lives = lives + 100;
            LblLives.Text = lives.ToString();
        }

        private void infiniteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void boringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Difficulty.Enabled = false;
            for (int i = 0; i <= 6; i++)
            {
                planetSpeed[i] = speed.Next(1, 10); //each planet has a random speed
            }
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Difficulty.Enabled = false;
            for (int i = 0; i <= 6; i++)
            {
                planetSpeed[i] = speed.Next(20, 30); //each planet has a random speed
            }
        }

        private void decentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Difficulty.Enabled = false;
            for (int i = 0; i <= 6; i++)
            {
                planetSpeed[i] = speed.Next(40,50); //each planet has a random speed
            }
        }

        private void crazyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Difficulty.Enabled = false;
            for (int i = 0; i <= 6; i++)
            {
                planetSpeed[i] = speed.Next(60,80); //each planet has a random speed
            }
        }

        private void eXTREMEMEGAMADNESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Difficulty.Enabled = false;
            for (int i = 0; i <= 6; i++)
            {
                planetSpeed[i] = speed.Next(300, 600); //each planet has a random speed
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lives = lives + 1;
            LblLives.Text = lives.ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            lives = lives - 1;
            LblLives.Text = lives.ToString();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            score = score + 1;
            LblScore.Text = score.ToString();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            score = score + 10;
            LblScore.Text = score.ToString();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            score = score - 1;
            LblScore.Text = score.ToString();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            score = score - 10;
            LblScore.Text = score.ToString();
        }

        private void LblScore_Click(object sender, EventArgs e)
        {

        }

        private void fordaLOLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"\nvergonnagiveuup.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }

        private void TmrPlanetX_Tick(object sender, EventArgs e)
        {
            Random rad = new Random();
            int PlanetLeft = rad.Next(0, 1);
            int movmentsL= 0;
            int movmentsR = 0;
            LblLeft.Text = movmentsL.ToString();
            LblRight.Text = movmentsR.ToString();
            for (int i = 0; i <= 6; i++)
            {
                if (movmentsR == 3)
                {
                    area[i].X = area[i].X - 15;
                }
                if (movmentsL == 3)
                {
                    area[i].X = area[i].X + 15;
                }
            }
            if (PlanetLeft == 0)
            {
                movmentsL = movmentsL + 1;
                movmentsR = movmentsR - 1;
                for (int i = 0; i <= 6; i++)
                {
                    area[i].X = area[i].X + 5;
                }
            }
            if (PlanetLeft == 1)
            {
                movmentsR = movmentsR + 1;
                movmentsL = movmentsL - 1;
                for (int i = 0; i <= 6; i++)
                {
                    area[i].X = area[i].X + 5;
                }
            }

        }

        private void nOMOREINFINITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void laser_Tick(object sender, EventArgs e)
        {
            ly = ly - laserspeed;
            fireingmalaser.Y = ly;
        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            if ( firemylaser == true )
            {
                laser.Enabled = true;
            }
            if ( firemylaser == false)
            {
                laser.Enabled = false;
            }
            for (int i = 0; i <= 6; i++)
            {
                area[i].Y += planetSpeed[i];
                if (area[i].IntersectsWith(areaSpaceship))
                {
                    area[i].Y = 20;
                    lives -= 1; // reduce lives by 1
                                //display the number of lives on the form
                    LblLives.Text = lives.ToString();

                    CheckLives();
                }
                if (area[i].IntersectsWith(fireingmalaser))
                {
                    area[i].Y = -100;
                }


                if (area[i].Y > PnlGame.Height)
                {
                    score += 1; //add 1 to score
                    tillfire += 1;
                    LblScore.Text = score.ToString(); //display score on form

                    area[i].Y = 20;
                }
            }
            PnlGame.Invalidate();
        }


        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over " + user + " you scored a whooping score of "+score);
                if (score >= thehighscore)
                {
                    thehighscore = score;
                    highscore.Text = thehighscore.ToString();
                }
                button2.Enabled = true;
                confirm.Enabled = true;
                minrnd = 20;
                maxrnd = 30;
                minspeed = 0;
                maxspeed = 0;
                Difficulty.Enabled = false;
            }
        }


        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            g.DrawImage(malaser, fireingmalaser);
            g.DrawImage(spaceship, areaSpaceship);
            //use the DrawImage method to draw the spaceship on the panel
            //use the DrawImage method to draw the planet on the panel
            for (int i = 0; i <= 6; i++)
            {
                g.DrawImage(planet1, area[i]);
            }
        }
    }
}
