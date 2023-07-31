using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sierpinski_Triangle
{
    public partial class Sierpinski : Form
    {
        public Sierpinski()
        {
            InitializeComponent();
        }

        int randomX = 0;
        int randomY = 0;
        private void Sierpinski_Load(object sender, EventArgs e)
        {

        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            //line 29 to 41 draws the three inial ellipses at their static location
            int x1 = pnlDraw.Width / 2;
            int y1 = 10;
            e.Graphics.FillEllipse(Brushes.Red, x1, y1, 2, 2);

            int y2 = pnlDraw.Height - 10;
            int x2 = 10;
            e.Graphics.FillEllipse(Brushes.Blue, x2, y2, 2, 2);


            int x3 = pnlDraw.Width - 10;
            int y3 = pnlDraw.Height - 10;
            e.Graphics.FillEllipse(Brushes.Green, x3, y3, 2, 2);

            //the initial ellipse in the middle of the panel
            randomX = pnlDraw.Width / 2;
            randomY = pnlDraw.Height / 2;

            e.Graphics.FillEllipse(Brushes.DeepPink, randomX, randomY, 2, 2);

            Random rand = new Random();

            for (int i = 0; i <= 1000000; i++)
            {
                //Random number to determine the location of the next ellipses
                int number = rand.Next(0, 3);

                //depending on the number between 0,1 and 2. Move half way between the current location and the point determined by randomX and random
                if (number == 0)
                {
                    randomX = (randomX + x1) / 2;
                    randomY = (randomY + y1) / 2;
                }
                else if (number == 1)
                {
                    randomX = (randomX + x2) / 2;
                    randomY = (randomY + y2) / 2;
                }
                else
                {
                    randomX = (randomX + x3) / 2;
                    randomY = (randomY + y3) / 2;
                }

                //Color of the dots(ellipse of width and height of 2)
                e.Graphics.FillEllipse(Brushes.Black, randomX, randomY,2 ,2);
            }
        }
    }
}
