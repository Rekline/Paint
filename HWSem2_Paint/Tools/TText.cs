using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSem2_Paint
{
    public class TText : Tool
    {
        public TText(Color toolColor, int toolSize)
        {
            ToolColor = toolColor;
            ToolSize = toolSize;
        }

        public override void Draw(Graphics g, Point eLocation, bool isFillRequired, bool isShiftDown)
        {
        }

        public void PrintText(Graphics g, string text)
        {
            if (StartPoint == null)
                return;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            Brush b = new SolidBrush(ToolColor);
            g.DrawString(text, new Font("Times New Roman", ToolSize+10), b, (Point)StartPoint);
            //g.Flush();
        }
    }
}
