using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSem2_Paint
{
    public abstract class Tool
    {
        private Point? startPoint;
        private Color toolColor;
        private Color backgroundColor;
        private int toolSize;

        public Point? StartPoint
        {
            get => startPoint;
            set => startPoint = value;
        }
        public Color ToolColor
        {
            get => toolColor; set => toolColor = value;
        }
        public Color BackgroundColor
        {
            get => backgroundColor; set => backgroundColor = value;
        }
        public int ToolSize
        {
            get => toolSize; set => toolSize = value;
        }

        public abstract void Draw(Graphics g, Point eLocation, bool isFillRequired, bool isShiftDown);
    }
}
