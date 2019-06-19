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
        Random speed = new Random();
        Random speed2 = new Random();
        Random speed3 = new Random();
        Image platform = Image.FromFile(Application.StartupPath + @"\platform.jpg");
        Image platform2 = Image.FromFile(Application.StartupPath + @"\platform.jpg");
        Image platform3 = Image.FromFile(Application.StartupPath + @"\platform.jpg");
        int x1 = 200, y = 100;
        int x2 = 200, y2 = 300;
        int x3 = 200, y3 = 200;
        int gap = 300;
        int gap2 = 300;
        int gap3 = 300;
        int[] platformSpeed = new int[3];
        int[] platform2Speed = new int[3];
        int[] platform3Speed = new int[3];
        int check = 0;

        private void TmrPlatform_Tick(object sender, EventArgs e)
        {
            check = check + 1;
            LblCheck.Text = check.ToString();
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
        }

        public Form1()
        {
            Random rndgap = new Random();
            int gap = rndgap.Next(300, 300);
            Random rndgap2 = new Random();
            int gap2 = rndgap2.Next(300, 300);
            Random rndgap3 = new Random();
            int gap3 = rndgap3.Next(300, 300);
            for (int i = 0; i <= 2; i++)
            {
                platformSpeed[i] = speed.Next(10, 20); //each platform has a random speed
                area[i] = new Rectangle(x1 + gap * i, y, 150, 40);
            }
            for (int o = 0; o <= 2; o++)
            {
                platform2Speed[o] = speed2.Next(10, 20); //each platform has a random speed
                area2[o] = new Rectangle(x2 + gap2 * o, y2, 150, 40);
            }
            for (int p = 0; p <= 2; p++)
            {
                platform3Speed[p] = speed3.Next(10, 20);
                area3[p] = new Rectangle(x3 + gap3 * p, y3, 150, 40);
            }
            InitializeComponent();
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
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
    }
}
