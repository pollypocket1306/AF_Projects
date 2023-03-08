using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab2_P1_Joc_
{
    public class MyGraphics
    {
        PictureBox display;
        Bitmap bmp;
        public Graphics grp;
        Color bgColor = Color.Gainsboro;
        public int resX, resY;
        public void InitGraph(PictureBox display)
        {
            this.display = display;
            this.bmp = new Bitmap(display.Width, display.Height);
            this.grp = Graphics.FromImage(bmp);
            resX = display.Width;
            resY = display.Height;
        }

        public void ClearGraph()
        {
            grp.Clear(bgColor);
        }

        public void RefreshGraph()
        {
            this.display.Image = bmp;
        }
    }
}
