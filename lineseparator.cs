using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesDoctorantsV2
{
    public partial class lineseparator : UserControl
    {
       
        public lineseparator()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(lineseparator_Paint);
            //this.MaximumSize = new Size(2000, 2);
            //this.MinimumSize = new Size(0, 2);
            //this.Width = 350;
        }

        private void lineseparator_Paint(object sender, PaintEventArgs e)
        {
           // Pen greenPen = new Pen(Color.Green, 3);
           // Graphics g = e.Graphics;
           // //g.DrawLine(Pens.DarkGray, x1, y1, x2, y2);
           //// g.DrawLine(Pens.DarkGray, new Point(0, 0), new Point(this.Width, this.Height));
           //// g.DrawLine(Pens.White, new Point(1, 0), new Point(this.Width, 1));
           // Graphics g = e.Graphics;
            //g.DrawLine(Pens.DarkGray, new Point(20, 20), new Point(this.Width, this.Height));
            //g.DrawLine(Pens.White, new Point(0, 1), new Point(this.Width, 1));
           
            Pen greenPen = new Pen(Color.DarkGray, 1);


            // Draw line using Point structure
            Point p1 = new Point(20, 20);
            Point p2 = new Point(20, 400);
            e.Graphics.DrawLine(greenPen, p1, p2);

            greenPen.Dispose();
           
        }

        
    }
}
