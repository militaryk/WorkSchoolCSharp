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
        Rectangle[] area = new Rectangle[3];//area[0] to area[6]
        Rectangle[] area2 = new Rectangle[3];//area[0] to area[6]
        Rectangle[] area3 = new Rectangle[3];//area[0] to area[6]
        Image platform = Image.FromFile(Application.StartupPath + @"\platform.jpg");
        Image platform2 = Image.FromFile(Application.StartupPath + @"\platform.jpg");
        Image platform3 = Image.FromFile(Application.StartupPath + @"\platform.jpg");
        int x1 = 200, y = 100;
        int x2 = 200, y2 = 300;
        int x3 = 200, y3 = 200;
        int gap = 300;
        int gap2 = 300;
        int gap3 = 300;

        public Form1()
        {
            Random rndgap = new Random();
            int gap = rndgap.Next(150, 300);
            Random rndgap2 = new Random();
            int gap2 = rndgap2.Next(150, 300);
            Random rndgap3 = new Random();
            int gap3 = rndgap3.Next(150, 300);
            for (int i = 0; i <= 2; i++)
            {
                area[i] = new Rectangle(x1 + gap * i, y, 150, 40);
            }
            for (int i = 0; i <= 2; i++)
            {
                area2[i] = new Rectangle(x2 + gap2 * i, y2, 150, 40);
            }
            for (int i = 0; i <= 2; i++)
            {
                area3[i] = new Rectangle(x3 + gap3 * i, y3, 150, 40);
            }
            InitializeComponent();
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the spaceship on the panel
            //use the DrawImage method to draw the planet on the panel
            for (int i = 0; i <= 2; i++)
            {
                g.DrawImage(platform, area[i]);
            }
            for (int i = 0; i <= 2; i++)
            {
                g.DrawImage(platform2, area2[i]);
            }
            for (int i = 0; i <= 2; i++)
            {
                g.DrawImage(platform3, area3[i]);
            }
        }
    }
}
