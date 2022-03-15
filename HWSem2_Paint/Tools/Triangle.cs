using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSem2_Paint
{
    public class Triangle : Tool
    {
        public Triangle(Color toolColor, int toolSize)
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

            var p1 = new Point(StartPoint.Value.X, StartPoint.Value.Y);
            var p2 = new Point(endPoint.X, StartPoint.Value.Y);
            var p3 = new Point(endPoint.X, endPoint.Y);

            //if (isShiftDown)
            //{
            //    var len = Math.Min(endPoint.X - StartPoint.Value.X,
            //        endPoint.Y - StartPoint.Value.Y);
            //    // Добавить разные плоскости
            //    if ()
            //    {

            //    }
            //    p2 = new(StartPoint.Value.X + len, StartPoint.Value.Y);
            //    p3 = new(StartPoint.Value.X + len, StartPoint.Value.Y + len);
            //}

            Point[] trianglePoints = new Point[]{p1, p2, p3};

            g.DrawPolygon(p, trianglePoints);
            if (isFillRequired)
            {
                Brush b = new SolidBrush(BackgroundColor);
                g.FillPolygon(b, trianglePoints);
            }
        }
    }
}
