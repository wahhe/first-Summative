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
using System.Media;

//creat by WAH HE, 20160926, first summative
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
            
            //graphics objects
            Graphics formGraphics = this.CreateGraphics();
            Pen linePen = new Pen(Color.Lime, 2);
            SolidBrush goldBrush = new SolidBrush(Color.Gold);
            Font tittleFont = new Font("Trajan Pro", 22, FontStyle.Bold);
            SolidBrush yellowBrush = new SolidBrush(Color.LightGoldenrodYellow);
            Font bodyFont = new Font("Georage", 16, FontStyle.Bold);
            

            formGraphics.Clear(Color.Black);

            //draw spots
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 132, 40, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 232, 70, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 276, 98, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 300, 115, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 312, 122, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 377, 40, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 320, 135, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 372, 168, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 448, 172, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 437, 162, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 294, 138, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 270, 132, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 312, 122, 10, 10);
            Thread.Sleep(400);
            formGraphics.FillEllipse(goldBrush, 128, 129, 10, 10);
            
            //draw lines
            Thread.Sleep(500);
            formGraphics.DrawLine(linePen, 139, 46, 232, 73);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 232, 73, 276, 100);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 276, 100, 300, 118);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 300, 118, 312, 125);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 315, 130, 383, 43);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 318, 130, 323, 140);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 320, 138, 372, 170);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 372, 173, 450, 177);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 450, 177, 440, 165);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 320, 140, 300, 143);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 300, 143, 270, 135);
            Thread.Sleep(300);
            formGraphics.DrawLine(linePen, 270, 136, 128, 133);

            //write text part
            //add title to the descripitions

            formGraphics.DrawString("TAURUS", tittleFont, yellowBrush,250, 220);
            
            //add subtittle text
            Thread.Sleep(100);
            formGraphics.DrawString("Governing element: Earth", bodyFont, goldBrush, 50, 260);
            Thread.Sleep(100);
            formGraphics.DrawString("Ruling planet: Venus", bodyFont, goldBrush, 50, 290);
            Thread.Sleep(100);
            formGraphics.DrawString("Quality: Fixed", bodyFont, goldBrush, 50, 320);
            Thread.Sleep(100);
            formGraphics.DrawString("Polarity: Negative", bodyFont, goldBrush, 50, 350);
            Thread.Sleep(100);
            formGraphics.DrawString("Period of Birth: (New Date)May 13 – June 21", bodyFont, goldBrush, 50, 380);
            Thread.Sleep(100);
            formGraphics.DrawString("Compatible Signs: Cancer, Virgo, Scorpio, Pisces", bodyFont, goldBrush, 50, 410);
            Thread.Sleep(100);
            formGraphics.DrawString("Incompatible Signs: Gemini, Leo, Libra, ", bodyFont, goldBrush, 50, 440);
            Thread.Sleep(100);
            formGraphics.DrawString("Variably compatible Signs: Scorpio", bodyFont, goldBrush, 50, 470);

            











        }
    }
}
