using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSem2_Paint
{
    public class TRectangle : Tool
    {
        public TRectangle(Color toolColor, int toolSize)
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
            
            var coord = new Point(endPoint.X - StartPoint.Value.X, StartPoint.Value.Y - endPoint.Y);
            var p1X = coord.X > 0 ? StartPoint.Value.X : StartPoint.Value.X + coord.X;
            var p1Y = coord.Y > 0 ? StartPoint.Value.Y - coord.Y : StartPoint.Value.Y;

            if(isShiftDown)
            {
                Rectangle rect = CalcPosition(endPoint);
                g.DrawRectangle(p, rect);
            }
            else
                g.DrawRectangle(p, p1X, p1Y, Math.Abs(coord.X), Math.Abs(coord.Y));
            
            if (isFillRequired)
            {
                Brush b = new SolidBrush(BackgroundColor);
                if (isShiftDown)
                {
                    Rectangle rect = CalcPosition(endPoint);
                    g.FillRectangle(b, rect); 
                }
                else {
                g.FillRectangle(b, p1X, p1Y, Math.Abs(coord.X), Math.Abs(coord.Y)); }
            }
        }

        private Rectangle CalcPosition(Point endPoint)
        {
            Rectangle rect;
            var dP = new Point(endPoint.X - StartPoint.Value.X, endPoint.Y - StartPoint.Value.Y);
            
                if (dP.X > 0 && dP.Y > 0)
                    rect = new(StartPoint.Value.X, StartPoint.Value.Y, Math.Min(dP.X, dP.Y), Math.Min(dP.X, dP.Y));
                else if (dP.X > 0 && dP.Y < 0)
                {
                    var pX = StartPoint.Value.X;
                    int pY = Math.Abs(dP.X) > Math.Abs(dP.Y) ? endPoint.Y : StartPoint.Value.Y - dP.X;
                    var len = Math.Min(Math.Abs(dP.X), Math.Abs(dP.Y));
                    rect = new(pX, pY, len, len);
                }
                else if (dP.X < 0 && dP.Y > 0)
                {
                    var pX = Math.Abs(dP.X) > Math.Abs(dP.Y) ? StartPoint.Value.X - dP.Y : endPoint.X;
                    int pY = StartPoint.Value.Y;
                    var len = Math.Min(Math.Abs(dP.X), Math.Abs(dP.Y));
                    rect = new(pX, pY, len, len);
                }
                else
                {
                    var pX = Math.Abs(dP.X) > Math.Abs(dP.Y) ? StartPoint.Value.X - Math.Abs(dP.Y) : endPoint.X;
                    int pY = Math.Abs(dP.X) > Math.Abs(dP.Y) ? endPoint.Y : StartPoint.Value.Y - Math.Abs(dP.X);
                    var len = Math.Min(Math.Abs(dP.X), Math.Abs(dP.Y));
                    rect = new(pX, pY, len, len);
                }
            return rect;
        }
    }
}
