using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSem2_Paint
{
    public class Pencil : Tool
    {
        public Pencil(Color toolColor, int toolSize)
        {
            ToolColor = toolColor;
            ToolSize = toolSize;
        }

        public override void Draw(Graphics g, Point endPoint, bool isFillRequired, bool isShiftDown)
        {
            if (StartPoint == null)
                return;
            Pen p = new Pen(ToolColor, ToolSize);
            p.StartCap = p.EndCap = LineCap.Round;
            g.SmoothingMode = SmoothingMode.HighQuality;
            // Для стрелки можно из телефона взять
            g.DrawLine(p, (Point)StartPoint, endPoint);
            StartPoint = endPoint;
        }
    }
}
