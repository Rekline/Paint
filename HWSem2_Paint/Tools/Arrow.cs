using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSem2_Paint
{
    public class Arrow : Tool
    {
        public Arrow(Color toolColor, int toolSize)
        {
            ToolColor = toolColor;
            ToolSize = toolSize;
        }

        public override void Draw(Graphics g, Point endPoint, bool isFillRequired, bool isShiftDown)
        {
            if (StartPoint == null)
                return;
            Pen p = new Pen(ToolColor, ToolSize);
            p.StartCap = LineCap.Round;
            p.EndCap = LineCap.ArrowAnchor;
            g.SmoothingMode = SmoothingMode.HighQuality;
            if (isShiftDown)
            {
                DrawArrowWithShift(endPoint, g, p);
            }
            else
                g.DrawLine(p, (Point)StartPoint, endPoint);
        }


        private void DrawArrowWithShift(Point endPoint, Graphics g, Pen p)
        {
            int ac = (int)LenghtLine(endPoint, StartPoint.Value);
            Point b = new Point(StartPoint.Value.X, endPoint.Y);
            double angle = Math.Sin(Math.Abs(LenghtLine(StartPoint.Value, b) / LenghtLine(StartPoint.Value, endPoint)));
            double sin45 = Math.Sin(Math.PI / 4);
            var len = new Point(endPoint.X - StartPoint.Value.X, StartPoint.Value.Y - endPoint.Y);

            if (len.X > 0 && len.Y > 0)
            {
                if (angle >= 0 && angle <= 0.5)
                {
                    endPoint.Y = StartPoint.Value.Y;
                }
                if (angle > 0.5 && angle <= 0.8)
                {
                    endPoint.X = StartPoint.Value.X + (int)(ac * sin45);
                    endPoint.Y = StartPoint.Value.Y - (int)(ac * sin45);
                }
                if (angle > 0.8 && angle <= 1)
                {
                    endPoint.X = StartPoint.Value.X;
                }
            }
            if (len.X < 0 && len.Y > 0)
            {
                if (angle >= 0 && angle <= 0.5)
                {
                    endPoint.Y = StartPoint.Value.Y;
                }
                if (angle > 0.5 && angle <= 0.8)
                {
                    endPoint.X = StartPoint.Value.X - (int)(ac * sin45);
                    endPoint.Y = StartPoint.Value.Y - (int)(ac * sin45);
                }
                if (angle > 0.8 && angle <= 1)
                {
                    endPoint.X = StartPoint.Value.X;
                }
            }
            if (len.X > 0 && len.Y < 0)
            {
                if (angle >= 0 && angle <= 0.5)
                {
                    endPoint.Y = StartPoint.Value.Y;
                }
                if (angle >= 0.5 && angle <= 0.8)
                {
                    endPoint.X = StartPoint.Value.X + (int)(ac * sin45);
                    endPoint.Y = StartPoint.Value.Y + (int)(ac * sin45);
                }
                if (angle > 0.8 && angle <= 1)
                {
                    endPoint.X = StartPoint.Value.X;
                }
            }
            if (len.X < 0 && len.Y < 0)
            {
                if (angle >= 0 && angle <= 0.5)
                {
                    endPoint.Y = StartPoint.Value.Y;
                }
                if (angle >= 0.5 && angle <= 0.8)
                {
                    endPoint.X = StartPoint.Value.X - (int)(ac * sin45);
                    endPoint.Y = StartPoint.Value.Y + (int)(ac * sin45);
                }
                if (angle > 0.8 && angle <= 1)
                {
                    endPoint.X = StartPoint.Value.X;
                }
            }

            g.DrawLine(p, (Point)StartPoint, endPoint);
        }

        public static double LenghtLine(Point p1, Point p2)
                => Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}
