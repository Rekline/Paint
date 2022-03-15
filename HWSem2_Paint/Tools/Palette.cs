using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSem2_Paint
{
    public class Palette : Tool
    {
        public override void Draw(Graphics g, Point eLocation, bool isFillRequired, bool isShiftDown)
        {
        }

        public Color GetPixelColor(Bitmap img)
        {
            if (StartPoint != null)
                return img.GetPixel(StartPoint.Value.X, StartPoint.Value.Y);
            return ToolColor;
        }
    }
}
