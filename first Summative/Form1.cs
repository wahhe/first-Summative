using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace first_Summative
{
    public partial class TAURUS : Form
    {
        public TAURUS()
        {
            InitializeComponent();//
        }

        private void startbutton1_Click(object sender, EventArgs e)
        {
            startbutton1.Hide();
            taurusTitleLabel.Hide();
            this.BackgroundImage = null;
           
            Refresh();

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Gold, 1);
            SolidBrush drawBrush = new SolidBrush(Color.Gold);

            formGraphics.Clear(Color.Black);

            //draw spots
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 132, 40, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 232, 70, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 276, 98, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 300, 115, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 312, 122, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 377, 40, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 320, 135, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 372, 168, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 448, 172, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 437, 162, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 294, 138, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 270, 132, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 312, 122, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(drawBrush, 128, 129, 10, 10);
            
            //draw lines
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 139, 46, 232, 73);
            formGraphics.DrawLine(drawPen, 232, 73, 276, 100);
            formGraphics.DrawLine(drawPen, 276, 100, 300, 118);
            formGraphics.DrawLine(drawPen, 300, 118, 312, 125);
            formGraphics.DrawLine(drawPen, 312, 125, 377, 43);






        }
    }
}
