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
            //create a font

            formGraphics.Clear(Color.Black);

            //draw spots
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 132, 40, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 232, 70, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 276, 98, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 300, 115, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 312, 122, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 377, 40, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 320, 135, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 372, 168, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 448, 172, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 437, 162, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 294, 138, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 270, 132, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 312, 122, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(drawBrush, 128, 129, 10, 10);
            
            //draw lines
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 139, 46, 232, 73);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 232, 73, 276, 100);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 276, 100, 300, 118);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 300, 118, 312, 125);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 315, 130, 383, 43);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 318, 130, 323, 140);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 320, 138, 372, 170);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 372, 173, 450, 177);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 450, 177, 440, 165);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 320, 140, 300, 143);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 300, 143, 270, 135);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 270, 136, 128, 133);

            //write text
            Font drawFont = new Font("Georage", 16, FontStyle.Bold);
            formGraphics.DrawString("TAURUS.", drawFont, drawBrush, 20, 20);
            formGraphics.DrawString("Those who are born between those dates have the following Taurus characteristics: ", drawFont, drawBrush, 20, 40);








        }
    }
}
