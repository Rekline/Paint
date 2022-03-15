namespace HWSem2_Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.canvas = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPensil = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPalette = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnArrow = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.chBoxFillFigure = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMainColor = new System.Windows.Forms.Button();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnColorBrown = new System.Windows.Forms.Button();
            this.btnColorGreen = new System.Windows.Forms.Button();
            this.btnColorMediumPurple = new System.Windows.Forms.Button();
            this.btnColorWhite = new System.Windows.Forms.Button();
            this.btnColorYellowGreen = new System.Windows.Forms.Button();
            this.btnColorGold = new System.Windows.Forms.Button();
            this.btnColorPink = new System.Windows.Forms.Button();
            this.btnColorIndigo = new System.Windows.Forms.Button();
            this.btnColorAqua = new System.Windows.Forms.Button();
            this.btnColorYellow = new System.Windows.Forms.Button();
            this.btnColorOrange = new System.Windows.Forms.Button();
            this.btnColorBlack = new System.Windows.Forms.Button();
            this.btnColorRed = new System.Windows.Forms.Button();
            this.btnColorDarkRed = new System.Windows.Forms.Button();
            this.btnColorGray = new System.Windows.Forms.Button();
            this.btnColorBlue = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolSizeBar = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolSizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.canvas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.50758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.49242F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 609);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(3, 121);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1156, 485);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            this.canvas.Resize += new System.EventHandler(this.canvas_Resize);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FloralWhite;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.075044F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.55458F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.41485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.96507F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.550218F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.25764F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1156, 112);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnInsert, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(98, 104);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(3, 55);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 46);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Вставить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 46);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnPensil, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEraser, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPalette, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnText, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(109, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(196, 104);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnPensil
            // 
            this.btnPensil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPensil.Location = new System.Drawing.Point(3, 3);
            this.btnPensil.Name = "btnPensil";
            this.btnPensil.Size = new System.Drawing.Size(92, 46);
            this.btnPensil.TabIndex = 0;
            this.btnPensil.Text = "Карандаш";
            this.btnPensil.UseVisualStyleBackColor = true;
            this.btnPensil.Click += new System.EventHandler(this.btnPensil_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEraser.Location = new System.Drawing.Point(101, 3);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(92, 46);
            this.btnEraser.TabIndex = 1;
            this.btnEraser.Text = "Ластик";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnPalette
            // 
            this.btnPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPalette.Location = new System.Drawing.Point(3, 55);
            this.btnPalette.Name = "btnPalette";
            this.btnPalette.Size = new System.Drawing.Size(92, 46);
            this.btnPalette.TabIndex = 2;
            this.btnPalette.Text = "Пипетка";
            this.btnPalette.UseVisualStyleBackColor = true;
            this.btnPalette.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnText
            // 
            this.btnText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnText.Location = new System.Drawing.Point(101, 55);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(92, 46);
            this.btnText.TabIndex = 3;
            this.btnText.Text = "Текст";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btnLine, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnRectangle, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnEllipse, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnArrow, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnTriangle, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.chBoxFillFigure, 2, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(312, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(286, 104);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // btnLine
            // 
            this.btnLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLine.Location = new System.Drawing.Point(3, 3);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(89, 46);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRectangle.Location = new System.Drawing.Point(98, 3);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(89, 46);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Прямоугольник";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEllipse.Location = new System.Drawing.Point(193, 3);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(90, 46);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Text = "Овал";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnArrow
            // 
            this.btnArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArrow.Location = new System.Drawing.Point(3, 55);
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(89, 46);
            this.btnArrow.TabIndex = 3;
            this.btnArrow.Text = "Стрелка";
            this.btnArrow.UseVisualStyleBackColor = true;
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTriangle.Location = new System.Drawing.Point(98, 55);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(89, 46);
            this.btnTriangle.TabIndex = 4;
            this.btnTriangle.Text = "Треугольник";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // chBoxFillFigure
            // 
            this.chBoxFillFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chBoxFillFigure.AutoSize = true;
            this.chBoxFillFigure.Location = new System.Drawing.Point(193, 55);
            this.chBoxFillFigure.Name = "chBoxFillFigure";
            this.chBoxFillFigure.Size = new System.Drawing.Size(90, 46);
            this.chBoxFillFigure.TabIndex = 5;
            this.chBoxFillFigure.Text = "Заливка";
            this.chBoxFillFigure.UseVisualStyleBackColor = true;
            this.chBoxFillFigure.CheckedChanged += new System.EventHandler(this.chBoxFillFigure_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.btnMainColor, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnBackgroundColor, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(743, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(69, 104);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // btnMainColor
            // 
            this.btnMainColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainColor.BackColor = System.Drawing.Color.Black;
            this.btnMainColor.Location = new System.Drawing.Point(3, 3);
            this.btnMainColor.Name = "btnMainColor";
            this.btnMainColor.Size = new System.Drawing.Size(63, 46);
            this.btnMainColor.TabIndex = 0;
            this.btnMainColor.UseVisualStyleBackColor = false;
            this.btnMainColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMainColor_MouseClick);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackgroundColor.BackColor = System.Drawing.Color.White;
            this.btnBackgroundColor.Location = new System.Drawing.Point(3, 55);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(63, 46);
            this.btnBackgroundColor.TabIndex = 1;
            this.btnBackgroundColor.UseVisualStyleBackColor = false;
            this.btnBackgroundColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBackgroundColor_MouseClick);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Controls.Add(this.btnColorBrown, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.btnColorGreen, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.btnColorMediumPurple, 3, 3);
            this.tableLayoutPanel8.Controls.Add(this.btnColorWhite, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnColorYellowGreen, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.btnColorGold, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.btnColorPink, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.btnColorIndigo, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.btnColorAqua, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnColorYellow, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnColorOrange, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnColorBlack, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnColorRed, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnColorDarkRed, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnColorGray, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnColorBlue, 3, 2);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(819, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(333, 104);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // btnColorBrown
            // 
            this.btnColorBrown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorBrown.BackColor = System.Drawing.Color.Brown;
            this.btnColorBrown.Location = new System.Drawing.Point(3, 55);
            this.btnColorBrown.Name = "btnColorBrown";
            this.btnColorBrown.Size = new System.Drawing.Size(77, 20);
            this.btnColorBrown.TabIndex = 21;
            this.btnColorBrown.UseVisualStyleBackColor = false;
            this.btnColorBrown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorBrown_MouseUp);
            // 
            // btnColorGreen
            // 
            this.btnColorGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorGreen.BackColor = System.Drawing.Color.Green;
            this.btnColorGreen.Location = new System.Drawing.Point(169, 55);
            this.btnColorGreen.Name = "btnColorGreen";
            this.btnColorGreen.Size = new System.Drawing.Size(77, 20);
            this.btnColorGreen.TabIndex = 11;
            this.btnColorGreen.UseVisualStyleBackColor = false;
            this.btnColorGreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorGreen_MouseUp);
            // 
            // btnColorMediumPurple
            // 
            this.btnColorMediumPurple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorMediumPurple.BackColor = System.Drawing.Color.MediumPurple;
            this.btnColorMediumPurple.Location = new System.Drawing.Point(252, 81);
            this.btnColorMediumPurple.Name = "btnColorMediumPurple";
            this.btnColorMediumPurple.Size = new System.Drawing.Size(78, 20);
            this.btnColorMediumPurple.TabIndex = 29;
            this.btnColorMediumPurple.UseVisualStyleBackColor = false;
            this.btnColorMediumPurple.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorMediumPurple_MouseUp);
            // 
            // btnColorWhite
            // 
            this.btnColorWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorWhite.BackColor = System.Drawing.Color.White;
            this.btnColorWhite.Location = new System.Drawing.Point(86, 3);
            this.btnColorWhite.Name = "btnColorWhite";
            this.btnColorWhite.Size = new System.Drawing.Size(77, 20);
            this.btnColorWhite.TabIndex = 19;
            this.btnColorWhite.UseVisualStyleBackColor = false;
            this.btnColorWhite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorWhite_MouseUp);
            // 
            // btnColorYellowGreen
            // 
            this.btnColorYellowGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorYellowGreen.BackColor = System.Drawing.Color.YellowGreen;
            this.btnColorYellowGreen.Location = new System.Drawing.Point(169, 81);
            this.btnColorYellowGreen.Name = "btnColorYellowGreen";
            this.btnColorYellowGreen.Size = new System.Drawing.Size(77, 20);
            this.btnColorYellowGreen.TabIndex = 27;
            this.btnColorYellowGreen.UseVisualStyleBackColor = false;
            this.btnColorYellowGreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorYellowGreen_MouseUp);
            // 
            // btnColorGold
            // 
            this.btnColorGold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorGold.BackColor = System.Drawing.Color.Gold;
            this.btnColorGold.Location = new System.Drawing.Point(86, 81);
            this.btnColorGold.Name = "btnColorGold";
            this.btnColorGold.Size = new System.Drawing.Size(77, 20);
            this.btnColorGold.TabIndex = 25;
            this.btnColorGold.UseVisualStyleBackColor = false;
            this.btnColorGold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorGold_MouseUp);
            // 
            // btnColorPink
            // 
            this.btnColorPink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorPink.BackColor = System.Drawing.Color.Pink;
            this.btnColorPink.Location = new System.Drawing.Point(3, 81);
            this.btnColorPink.Name = "btnColorPink";
            this.btnColorPink.Size = new System.Drawing.Size(77, 20);
            this.btnColorPink.TabIndex = 23;
            this.btnColorPink.UseVisualStyleBackColor = false;
            this.btnColorPink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorPink_MouseUp);
            // 
            // btnColorIndigo
            // 
            this.btnColorIndigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorIndigo.BackColor = System.Drawing.Color.Indigo;
            this.btnColorIndigo.Location = new System.Drawing.Point(86, 55);
            this.btnColorIndigo.Name = "btnColorIndigo";
            this.btnColorIndigo.Size = new System.Drawing.Size(77, 20);
            this.btnColorIndigo.TabIndex = 17;
            this.btnColorIndigo.UseVisualStyleBackColor = false;
            this.btnColorIndigo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorIndigo_MouseUp);
            // 
            // btnColorAqua
            // 
            this.btnColorAqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorAqua.BackColor = System.Drawing.Color.Aqua;
            this.btnColorAqua.Location = new System.Drawing.Point(252, 29);
            this.btnColorAqua.Name = "btnColorAqua";
            this.btnColorAqua.Size = new System.Drawing.Size(78, 20);
            this.btnColorAqua.TabIndex = 13;
            this.btnColorAqua.UseVisualStyleBackColor = false;
            this.btnColorAqua.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorAqua_MouseUp);
            // 
            // btnColorYellow
            // 
            this.btnColorYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnColorYellow.Location = new System.Drawing.Point(86, 29);
            this.btnColorYellow.Name = "btnColorYellow";
            this.btnColorYellow.Size = new System.Drawing.Size(77, 20);
            this.btnColorYellow.TabIndex = 9;
            this.btnColorYellow.UseVisualStyleBackColor = false;
            this.btnColorYellow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorYellow_MouseUp);
            // 
            // btnColorOrange
            // 
            this.btnColorOrange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorOrange.BackColor = System.Drawing.Color.Orange;
            this.btnColorOrange.Location = new System.Drawing.Point(3, 29);
            this.btnColorOrange.Name = "btnColorOrange";
            this.btnColorOrange.Size = new System.Drawing.Size(77, 20);
            this.btnColorOrange.TabIndex = 7;
            this.btnColorOrange.UseVisualStyleBackColor = false;
            this.btnColorOrange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorOrange_MouseUp);
            // 
            // btnColorBlack
            // 
            this.btnColorBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorBlack.BackColor = System.Drawing.Color.Black;
            this.btnColorBlack.Location = new System.Drawing.Point(3, 3);
            this.btnColorBlack.Name = "btnColorBlack";
            this.btnColorBlack.Size = new System.Drawing.Size(77, 20);
            this.btnColorBlack.TabIndex = 0;
            this.btnColorBlack.UseVisualStyleBackColor = false;
            this.btnColorBlack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorBlack_MouseUp);
            // 
            // btnColorRed
            // 
            this.btnColorRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorRed.BackColor = System.Drawing.Color.Red;
            this.btnColorRed.Location = new System.Drawing.Point(169, 29);
            this.btnColorRed.Name = "btnColorRed";
            this.btnColorRed.Size = new System.Drawing.Size(77, 20);
            this.btnColorRed.TabIndex = 5;
            this.btnColorRed.UseVisualStyleBackColor = false;
            this.btnColorRed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorRed_MouseUp);
            // 
            // btnColorDarkRed
            // 
            this.btnColorDarkRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorDarkRed.BackColor = System.Drawing.Color.DarkRed;
            this.btnColorDarkRed.Location = new System.Drawing.Point(252, 3);
            this.btnColorDarkRed.Name = "btnColorDarkRed";
            this.btnColorDarkRed.Size = new System.Drawing.Size(78, 20);
            this.btnColorDarkRed.TabIndex = 1;
            this.btnColorDarkRed.UseVisualStyleBackColor = false;
            this.btnColorDarkRed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorDarkRed_MouseUp);
            // 
            // btnColorGray
            // 
            this.btnColorGray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorGray.BackColor = System.Drawing.Color.Gray;
            this.btnColorGray.Location = new System.Drawing.Point(169, 3);
            this.btnColorGray.Name = "btnColorGray";
            this.btnColorGray.Size = new System.Drawing.Size(77, 20);
            this.btnColorGray.TabIndex = 3;
            this.btnColorGray.UseVisualStyleBackColor = false;
            this.btnColorGray.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorGray_MouseUp);
            // 
            // btnColorBlue
            // 
            this.btnColorBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorBlue.BackColor = System.Drawing.Color.Blue;
            this.btnColorBlue.Location = new System.Drawing.Point(252, 55);
            this.btnColorBlue.Name = "btnColorBlue";
            this.btnColorBlue.Size = new System.Drawing.Size(78, 20);
            this.btnColorBlue.TabIndex = 15;
            this.btnColorBlue.UseVisualStyleBackColor = false;
            this.btnColorBlue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColorBlue_MouseUp);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.toolSizeBar, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(605, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(131, 104);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер инструмента";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolSizeBar
            // 
            this.toolSizeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolSizeBar.Location = new System.Drawing.Point(3, 55);
            this.toolSizeBar.Maximum = 30;
            this.toolSizeBar.Minimum = 3;
            this.toolSizeBar.Name = "toolSizeBar";
            this.toolSizeBar.Size = new System.Drawing.Size(125, 46);
            this.toolSizeBar.TabIndex = 5;
            this.toolSizeBar.Value = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1171, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolSizeBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel canvas;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnInsert;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnPensil;
        private Button btnEraser;
        private Button btnPalette;
        private Button btnText;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnLine;
        private Button btnRectangle;
        private Button btnEllipse;
        private Button btnArrow;
        private Button btnTriangle;
        private CheckBox chBoxFillFigure;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnMainColor;
        private Button btnBackgroundColor;
        private ColorDialog colorDialog1;
        private TrackBar toolSizeBar;
        private TableLayoutPanel tableLayoutPanel8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnColorMediumPurple;
        private Button btnColorYellowGreen;
        private Button btnColorGold;
        private Button btnColorPink;
        private Button btnColorBrown;
        private Button btnColorWhite;
        private Button btnColorIndigo;
        private Button btnColorBlue;
        private Button btnColorAqua;
        private Button btnColorGreen;
        private Button btnColorYellow;
        private Button btnColorOrange;
        private Button btnColorRed;
        private Button btnColorGray;
        private Button btnColorBlack;
        private Button btnColorDarkRed;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}