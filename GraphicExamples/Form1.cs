using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Graphics Objects
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 25, FontStyle.Bold);

            //Shapes and lines
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawRectangle(drawPen, 80, 80, 360, 200);
            g.FillRectangle(drawBrush, 80, 80, 360, 200);
            g.DrawEllipse(drawPen, 80, 80, 200, 200);
            g.DrawEllipse(drawPen, 160, 80, 200, 200);
            g.DrawEllipse(drawPen, 240, 80, 200, 200);
            //g.DrawArc(drawPen, 200, 20, 500, 50, 90, 180);
            g.DrawPie(drawPen, 300, 20, 50, 50, 330, 60);

            //Strings
            g.DrawString("Hello", drawFont, drawBrush, 500, 300);
        }
    }
}
