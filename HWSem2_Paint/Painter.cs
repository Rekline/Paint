using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSem2_Paint
{
    public enum ToolType
    {
        Pensil = 0,
        Eraser = 1,
        Palette = 2,
        Text = 3,
        Line = 4,
        Ellipse = 5,
        Rectangle = 6,
        Arrow = 7,
        Triangle = 8
    }

    public class Painter
    {
        private Image mainImage;
        private List<Tool> ins = new List<Tool>();

        public ToolType tt
        { get; set; }

        private Size imageSizeNow;

        private Size imageSize;
        public Size ImageSize
        {
            get => imageSize;
            set
            {
                imageSize = value;
                imageSizeNow = value;
                Image img = new Bitmap(imageSize.Width, imageSize.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Graphics.FromImage(img).Clear(Color.White);
                var imgGraphics = Graphics.FromImage(img);
                if (mainImage is not null)
                    imgGraphics.DrawImage(mainImage, 0, 0);
                mainImage = img;
            }
        }

        public Painter(Color toolColor, Color backgroundColor, int toolSize, Size containerSize)
        {
            ImageSize = containerSize;

            // Здесь добавляем свитч по объекту
            ins.Add(new Pencil(toolColor, toolSize));
            ins.Add(new Eraser(backgroundColor, toolSize));
            ins.Add(new Palette());
            ins.Add(new TText(toolColor, toolSize));
            ins.Add(new Line(toolColor, toolSize));
            ins.Add(new Ellipse(toolColor, toolSize));
            ins.Add(new TRectangle(toolColor, toolSize));
            ins.Add(new Arrow(toolColor, toolSize));
            ins.Add(new Triangle(toolColor, toolSize));

        }

        public void StartDrawing(Point eLocation, Color toolColor, Color backgroundColor, int toolSize)
        {
            ins[(int)tt].StartPoint = eLocation;
            ins[(int)tt].ToolColor = toolColor;
            ins[(int)tt].BackgroundColor = backgroundColor;
            ins[(int)tt].ToolSize = toolSize;
        }

        public void StopDrawing()
        {
            ins[(int)tt].StartPoint = null;
        }

        public void Draw(Graphics g, Point eLocation, bool isFillRequired, bool isShiftDown)
        {
            var ig = Graphics.FromImage(mainImage);
            ins[(int)tt].Draw(ig, eLocation, isFillRequired, isShiftDown);
            g.DrawImage(mainImage, 0, 0);
        }

        public Color GetPixel(Graphics g, Point eLocation)
        {
            Bitmap bm = new Bitmap(mainImage);
            Palette p = new Palette();
            p.StartPoint = eLocation;
            return p.GetPixelColor(bm);
        }

        public void PrintText(Graphics g, string text)
        {
            var ig = Graphics.FromImage(mainImage);
            TText t = (TText)ins[(int)tt];
            t.PrintText(ig, text);
            g.DrawImage(mainImage, 0, 0);
        }

        public void Paint(Graphics g)
        {
            g.DrawImage(mainImage, 0, 0);
        }

        public void Refresh(Size containerSize)
        {
            //Добавить формат пикселей
            imageSizeNow = containerSize;
            containerSize.Width = Math.Max(containerSize.Width, mainImage.Size.Width);
            containerSize.Height = Math.Max(containerSize.Height, mainImage.Size.Height);
            var img = new Bitmap(containerSize.Width, containerSize.Height);
            var ig = Graphics.FromImage(img);
            ig.Clear(Color.White);
            ig.DrawImage(mainImage, 0, 0);
            mainImage = img;
        }

        public void Preview(Graphics g, Point eLocation, bool isFillRequired, bool isShiftDown)
        {
            BufferedGraphics bg = BufferedGraphicsManager.Current.Allocate(g, Rectangle.Round(g.VisibleClipBounds));
            bg.Graphics.DrawImage(mainImage, 0, 0);
            ins[(int)tt].Draw(bg.Graphics, eLocation, isFillRequired, isShiftDown);
            bg.Render(g);
        }

        public void SaveImage(SaveFileDialog sfd)
        {
            sfd.FileName = "Безымянный";
            sfd.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = ((Bitmap)mainImage).Clone(new Rectangle(0, 0, imageSizeNow.Width,
                    imageSizeNow.Height), mainImage.PixelFormat);
                btm.Save(sfd.FileName);
            }
        }

        public void InsertImage(OpenFileDialog ofd)
        {
            ofd.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png"; 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var insertImage = Image.FromFile(ofd.FileName);
                imageSizeNow.Width = Math.Max(insertImage.Width, mainImage.Width);
                imageSizeNow.Height = Math.Max(insertImage.Height, mainImage.Height);
                var img = new Bitmap(imageSizeNow.Width, imageSizeNow.Height);
                var ig = Graphics.FromImage(img);
                ig.Clear(Color.White);
                ig.DrawImage(mainImage, 0, 0);
                mainImage = insertImage;
            }
        }
    }
}
