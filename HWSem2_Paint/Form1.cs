using System.Drawing.Drawing2D;

namespace HWSem2_Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            painter = new Painter(MainColor, BackgroundColor, ToolSize, canvas.Size);
        }

        private Painter painter;
        private bool isBtnPressed = false;
        private bool isPreviewRequired = false;
        private bool isFillRequired = false;
        private bool isShiftDown = false;
        private Color MainColor
        {
            get => btnMainColor.BackColor;
            set => btnMainColor.BackColor = value;
        }
        private Color BackgroundColor
        {
            get => btnBackgroundColor.BackColor;
            set => btnBackgroundColor.BackColor = value;
        }
        private int ToolSize
        {
            get => toolSizeBar.Value;
            set => toolSizeBar.Value = value;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isBtnPressed = true;
            painter.StartDrawing(e.Location, MainColor, BackgroundColor, ToolSize);
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isBtnPressed = false;
            if (isPreviewRequired)
            {
                
                painter.Draw(canvas.CreateGraphics(), e.Location, isFillRequired, isShiftDown);
            }
            painter.StopDrawing();
            isShiftDown = ModifierKeys == Keys.Shift;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isBtnPressed) return;
            isShiftDown = ModifierKeys == Keys.Shift;
            if (isPreviewRequired)
            {
                painter.Preview(canvas.CreateGraphics(), e.Location, isFillRequired, isShiftDown);
            }
            else
            {
                painter.Draw(canvas.CreateGraphics(), e.Location, isFillRequired, isShiftDown);
            }

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            painter.Paint(e.Graphics);
        }

        private void canvas_Resize(object sender, EventArgs e)
        {
            painter.Refresh(canvas.Size);
            canvas.Refresh();
        }

        private void btnPensil_Click(object sender, EventArgs e)
        {
            painter.tt = ToolType.Pensil;
            isPreviewRequired = false;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            painter.tt = ToolType.Eraser;
            isPreviewRequired = false;
        }

        private void btnPalette_Click(object sender, EventArgs e)
        {
            painter.tt = ToolType.Palette;
            isPreviewRequired = false;
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            painter.tt = ToolType.Text;
            isPreviewRequired = false;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            painter.tt = ToolType.Line;
            isPreviewRequired = true;

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            painter.tt = ToolType.Rectangle;
            isPreviewRequired = true;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            painter.tt = ToolType.Ellipse;
            isPreviewRequired = true;
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            painter.tt = ToolType.Arrow;
            isPreviewRequired = true;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            painter.tt = ToolType.Triangle;
            isPreviewRequired = true;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch(painter.tt)
            {
                case ToolType.Text:
                    painter.StartDrawing(e.Location, MainColor, BackgroundColor, ToolSize);
                    string text;
                    FormToText ft = new FormToText();
                    ft.ShowDialog();
                    text = ft.ftText;
                    painter.PrintText(canvas.CreateGraphics(), text);
                    painter.StopDrawing();
                    break;
                case ToolType.Palette:
                    painter.StartDrawing(e.Location, MainColor, BackgroundColor, ToolSize);
                    Color c = painter.GetPixel(canvas.CreateGraphics(), e.Location);
                    if (e.Button == MouseButtons.Left)
                    {
                        MainColor = c;
                    }
                    else if(e.Button == MouseButtons.Right)
                    {
                        BackgroundColor = c;
                    }
                    painter.StopDrawing();
                    break;
            }
        }

        private void btnColorBlack_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorBlack.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorBlack.BackColor;
            }
        }
        private void btnColorWhite_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorWhite.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorWhite.BackColor;
            }
        }
        private void btnColorGray_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorGray.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorGray.BackColor;
            }
        }
        private void btnColorDarkRed_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorDarkRed.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorDarkRed.BackColor;
            }
        }
        private void btnColorOrange_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorOrange.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorOrange.BackColor;
            }
        }
        private void btnColorYellow_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorYellow.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorYellow.BackColor;
            }
        }
        private void btnColorRed_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorRed.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorRed.BackColor;
            }
        }
        private void btnColorAqua_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorAqua.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorAqua.BackColor;
            }
        }
        private void btnColorBrown_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorBrown.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorBrown.BackColor;
            }
        }
        private void btnColorIndigo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorIndigo.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorIndigo.BackColor;
            }
        }
        private void btnColorGreen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorGreen.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorGreen.BackColor;
            }
        }
        private void btnColorBlue_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorBlue.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorBlue.BackColor;
            }
        }
        private void btnColorPink_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorPink.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorPink.BackColor;
            }
        }
        private void btnColorGold_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorGold.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorGold.BackColor;
            }
        }
        private void btnColorYellowGreen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorYellowGreen.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorYellowGreen.BackColor;
            }
        }
        private void btnColorMediumPurple_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainColor = btnColorMediumPurple.BackColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                BackgroundColor = btnColorMediumPurple.BackColor;
            }
        }

        private void btnMainColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                MainColor = colorDialog1.Color;
        }

        private void btnBackgroundColor_MouseClick(object sender, MouseEventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                BackgroundColor = colorDialog1.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            painter.SaveImage(saveFileDialog1);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            painter.InsertImage(openFileDialog1);
            painter.Refresh(canvas.Size);
            canvas.Refresh();
        }

        private void chBoxFillFigure_CheckedChanged(object sender, EventArgs e)
        {
            isFillRequired = chBoxFillFigure.Checked ? true : false;
        }

    }
}