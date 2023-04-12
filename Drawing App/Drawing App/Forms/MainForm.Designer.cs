namespace Drawing_App
{
    partial class DrawingApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingApp));
            MenuStrip = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            SaveMenu = new ToolStripMenuItem();
            OpenMenu = new ToolStripMenuItem();
            ToolMenu = new ToolStripMenuItem();
            FillBucketMenu = new ToolStripMenuItem();
            PencilMenu = new ToolStripMenuItem();
            RotateReverseMenu = new ToolStripMenuItem();
            RotateMenu = new ToolStripMenuItem();
            EraserMenu = new ToolStripMenuItem();
            DeleteMenu = new ToolStripMenuItem();
            shapesToolStripMenuItem = new ToolStripMenuItem();
            LineMenu = new ToolStripMenuItem();
            CircleMenu = new ToolStripMenuItem();
            RectangleMenu = new ToolStripMenuItem();
            TriangleMenu = new ToolStripMenuItem();
            RightTriangleMenu = new ToolStripMenuItem();
            Panel = new Panel();
            Button_Move = new Button();
            Button_Clear = new Button();
            Label_Colors = new Label();
            Label_Shapes = new Label();
            Label_Tools = new Label();
            Button_Delete = new Button();
            Button_RotateReverseClock = new Button();
            Button_RotateClock = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Button_Line = new Button();
            Button_Circle = new Button();
            Button_Rectangle = new Button();
            Button_Triangle = new Button();
            Button_RightTriangle = new Button();
            panel1 = new Panel();
            Button_PurpleTwo = new Button();
            Button_PurpleOne = new Button();
            Button_BlueTwo = new Button();
            Button_BlueOne = new Button();
            Button_YellowTwo = new Button();
            Button_YellowOne = new Button();
            Button_Blue = new Button();
            Button_Purple = new Button();
            Button_Yellow = new Button();
            Button_RedTwo = new Button();
            Button_RedOne = new Button();
            Button_Red = new Button();
            Button_BrownTwo = new Button();
            Button_GreenTwo = new Button();
            Button_BrownOne = new Button();
            Button_GreenOne = new Button();
            Button_OrangeTwo = new Button();
            Button_WhiteTwo = new Button();
            Button_WhiteOne = new Button();
            Button_BlackTwo = new Button();
            Button_BlackOne = new Button();
            Button_OrangeOne = new Button();
            Button_Brown = new Button();
            Button_Green = new Button();
            Button_Orange = new Button();
            Button_White = new Button();
            Button_Black = new Button();
            Button_Eraser = new Button();
            Button_Pencil = new Button();
            Button_Fill = new Button();
            Button_Color = new Button();
            PictureBox_OutlineColor = new Button();
            PictureBox = new PictureBox();
            toolTip1 = new ToolTip(components);
            MenuStrip.SuspendLayout();
            Panel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(243, 243, 243);
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenu, ToolMenu, shapesToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(1154, 28);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "MenuStrip";
            // 
            // FileMenu
            // 
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { SaveMenu, OpenMenu });
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(46, 24);
            FileMenu.Text = "File";
            // 
            // SaveMenu
            // 
            SaveMenu.Image = (Image)resources.GetObject("SaveMenu.Image");
            SaveMenu.Name = "SaveMenu";
            SaveMenu.ShortcutKeyDisplayString = "Ctrl + S";
            SaveMenu.ShortcutKeys = Keys.Control | Keys.S;
            SaveMenu.Size = new Size(189, 26);
            SaveMenu.Text = "Save";
            SaveMenu.Click += SaveMenu_Click;
            // 
            // OpenMenu
            // 
            OpenMenu.Image = (Image)resources.GetObject("OpenMenu.Image");
            OpenMenu.Name = "OpenMenu";
            OpenMenu.ShortcutKeyDisplayString = "Ctrl + O";
            OpenMenu.ShortcutKeys = Keys.Control | Keys.O;
            OpenMenu.Size = new Size(189, 26);
            OpenMenu.Text = "Open";
            // 
            // ToolMenu
            // 
            ToolMenu.DropDownItems.AddRange(new ToolStripItem[] { FillBucketMenu, PencilMenu, RotateReverseMenu, RotateMenu, EraserMenu, DeleteMenu });
            ToolMenu.Name = "ToolMenu";
            ToolMenu.Size = new Size(58, 24);
            ToolMenu.Text = "Tools";
            // 
            // FillBucketMenu
            // 
            FillBucketMenu.Image = (Image)resources.GetObject("FillBucketMenu.Image");
            FillBucketMenu.Name = "FillBucketMenu";
            FillBucketMenu.Size = new Size(231, 26);
            FillBucketMenu.Text = "Fill Bucket";
            // 
            // PencilMenu
            // 
            PencilMenu.Image = Properties.Resources.Pencil_icon_original;
            PencilMenu.Name = "PencilMenu";
            PencilMenu.Size = new Size(231, 26);
            PencilMenu.Text = "Pencil";
            // 
            // RotateReverseMenu
            // 
            RotateReverseMenu.Image = (Image)resources.GetObject("RotateReverseMenu.Image");
            RotateReverseMenu.Name = "RotateReverseMenu";
            RotateReverseMenu.Size = new Size(231, 26);
            RotateReverseMenu.Text = "Rotate Reverse Clock";
            // 
            // RotateMenu
            // 
            RotateMenu.Image = (Image)resources.GetObject("RotateMenu.Image");
            RotateMenu.Name = "RotateMenu";
            RotateMenu.Size = new Size(231, 26);
            RotateMenu.Text = "Rotate Clock";
            // 
            // EraserMenu
            // 
            EraserMenu.Image = (Image)resources.GetObject("EraserMenu.Image");
            EraserMenu.Name = "EraserMenu";
            EraserMenu.Size = new Size(231, 26);
            EraserMenu.Text = "Eraser";
            // 
            // DeleteMenu
            // 
            DeleteMenu.Image = (Image)resources.GetObject("DeleteMenu.Image");
            DeleteMenu.Name = "DeleteMenu";
            DeleteMenu.Size = new Size(231, 26);
            DeleteMenu.Text = "Delete";
            // 
            // shapesToolStripMenuItem
            // 
            shapesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LineMenu, CircleMenu, RectangleMenu, TriangleMenu, RightTriangleMenu });
            shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            shapesToolStripMenuItem.Size = new Size(70, 24);
            shapesToolStripMenuItem.Text = "Shapes";
            // 
            // LineMenu
            // 
            LineMenu.Image = (Image)resources.GetObject("LineMenu.Image");
            LineMenu.Name = "LineMenu";
            LineMenu.Size = new Size(184, 26);
            LineMenu.Text = "Line";
            // 
            // CircleMenu
            // 
            CircleMenu.Image = (Image)resources.GetObject("CircleMenu.Image");
            CircleMenu.Name = "CircleMenu";
            CircleMenu.Size = new Size(184, 26);
            CircleMenu.Text = "Circle";
            // 
            // RectangleMenu
            // 
            RectangleMenu.Image = (Image)resources.GetObject("RectangleMenu.Image");
            RectangleMenu.Name = "RectangleMenu";
            RectangleMenu.Size = new Size(184, 26);
            RectangleMenu.Text = "Rectangle";
            // 
            // TriangleMenu
            // 
            TriangleMenu.Image = (Image)resources.GetObject("TriangleMenu.Image");
            TriangleMenu.Name = "TriangleMenu";
            TriangleMenu.Size = new Size(184, 26);
            TriangleMenu.Text = "Triangle";
            // 
            // RightTriangleMenu
            // 
            RightTriangleMenu.Image = (Image)resources.GetObject("RightTriangleMenu.Image");
            RightTriangleMenu.Name = "RightTriangleMenu";
            RightTriangleMenu.Size = new Size(184, 26);
            RightTriangleMenu.Text = "Right Triangle";
            // 
            // Panel
            // 
            Panel.BackColor = Color.FromArgb(249, 249, 249);
            Panel.Controls.Add(Button_Move);
            Panel.Controls.Add(Button_Clear);
            Panel.Controls.Add(Label_Colors);
            Panel.Controls.Add(Label_Shapes);
            Panel.Controls.Add(Label_Tools);
            Panel.Controls.Add(Button_Delete);
            Panel.Controls.Add(Button_RotateReverseClock);
            Panel.Controls.Add(Button_RotateClock);
            Panel.Controls.Add(panel2);
            Panel.Controls.Add(flowLayoutPanel1);
            Panel.Controls.Add(panel1);
            Panel.Controls.Add(Button_PurpleTwo);
            Panel.Controls.Add(Button_PurpleOne);
            Panel.Controls.Add(Button_BlueTwo);
            Panel.Controls.Add(Button_BlueOne);
            Panel.Controls.Add(Button_YellowTwo);
            Panel.Controls.Add(Button_YellowOne);
            Panel.Controls.Add(Button_Blue);
            Panel.Controls.Add(Button_Purple);
            Panel.Controls.Add(Button_Yellow);
            Panel.Controls.Add(Button_RedTwo);
            Panel.Controls.Add(Button_RedOne);
            Panel.Controls.Add(Button_Red);
            Panel.Controls.Add(Button_BrownTwo);
            Panel.Controls.Add(Button_GreenTwo);
            Panel.Controls.Add(Button_BrownOne);
            Panel.Controls.Add(Button_GreenOne);
            Panel.Controls.Add(Button_OrangeTwo);
            Panel.Controls.Add(Button_WhiteTwo);
            Panel.Controls.Add(Button_WhiteOne);
            Panel.Controls.Add(Button_BlackTwo);
            Panel.Controls.Add(Button_BlackOne);
            Panel.Controls.Add(Button_OrangeOne);
            Panel.Controls.Add(Button_Brown);
            Panel.Controls.Add(Button_Green);
            Panel.Controls.Add(Button_Orange);
            Panel.Controls.Add(Button_White);
            Panel.Controls.Add(Button_Black);
            Panel.Controls.Add(Button_Eraser);
            Panel.Controls.Add(Button_Pencil);
            Panel.Controls.Add(Button_Fill);
            Panel.Controls.Add(Button_Color);
            Panel.Controls.Add(PictureBox_OutlineColor);
            Panel.Dock = DockStyle.Top;
            Panel.Location = new Point(0, 28);
            Panel.Name = "Panel";
            Panel.Size = new Size(1154, 145);
            Panel.TabIndex = 1;
            // 
            // Button_Move
            // 
            Button_Move.Anchor = AnchorStyles.None;
            Button_Move.AutoSize = true;
            Button_Move.Cursor = Cursors.Hand;
            Button_Move.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Move.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Move.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Move.FlatStyle = FlatStyle.Flat;
            Button_Move.ForeColor = Color.White;
            Button_Move.Image = (Image)resources.GetObject("Button_Move.Image");
            Button_Move.Location = new Point(174, 14);
            Button_Move.Name = "Button_Move";
            Button_Move.Size = new Size(48, 48);
            Button_Move.TabIndex = 49;
            Button_Move.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Move, "Move");
            Button_Move.UseVisualStyleBackColor = true;
            Button_Move.Click += Button_Move_Click;
            // 
            // Button_Clear
            // 
            Button_Clear.Anchor = AnchorStyles.None;
            Button_Clear.AutoSize = true;
            Button_Clear.Cursor = Cursors.Hand;
            Button_Clear.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Clear.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Clear.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Clear.FlatStyle = FlatStyle.Flat;
            Button_Clear.ForeColor = Color.White;
            Button_Clear.Image = (Image)resources.GetObject("Button_Clear.Image");
            Button_Clear.Location = new Point(174, 68);
            Button_Clear.Name = "Button_Clear";
            Button_Clear.Size = new Size(48, 48);
            Button_Clear.TabIndex = 48;
            Button_Clear.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Clear, "Clear");
            Button_Clear.UseVisualStyleBackColor = true;
            Button_Clear.Click += Button_Clear_Click;
            // 
            // Label_Colors
            // 
            Label_Colors.Anchor = AnchorStyles.None;
            Label_Colors.AutoSize = true;
            Label_Colors.ForeColor = Color.FromArgb(64, 64, 64);
            Label_Colors.Location = new Point(885, 119);
            Label_Colors.Name = "Label_Colors";
            Label_Colors.Size = new Size(51, 20);
            Label_Colors.TabIndex = 46;
            Label_Colors.Text = "Colors";
            // 
            // Label_Shapes
            // 
            Label_Shapes.Anchor = AnchorStyles.None;
            Label_Shapes.AutoSize = true;
            Label_Shapes.ForeColor = Color.FromArgb(64, 64, 64);
            Label_Shapes.Location = new Point(413, 119);
            Label_Shapes.Name = "Label_Shapes";
            Label_Shapes.Size = new Size(56, 20);
            Label_Shapes.TabIndex = 45;
            Label_Shapes.Text = "Shapes";
            // 
            // Label_Tools
            // 
            Label_Tools.Anchor = AnchorStyles.None;
            Label_Tools.AutoSize = true;
            Label_Tools.ForeColor = Color.FromArgb(64, 64, 64);
            Label_Tools.Location = new Point(66, 119);
            Label_Tools.Name = "Label_Tools";
            Label_Tools.Size = new Size(44, 20);
            Label_Tools.TabIndex = 3;
            Label_Tools.Text = "Tools";
            // 
            // Button_Delete
            // 
            Button_Delete.Anchor = AnchorStyles.None;
            Button_Delete.AutoSize = true;
            Button_Delete.Cursor = Cursors.Hand;
            Button_Delete.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Delete.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Delete.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Delete.FlatStyle = FlatStyle.Flat;
            Button_Delete.ForeColor = Color.White;
            Button_Delete.Image = (Image)resources.GetObject("Button_Delete.Image");
            Button_Delete.Location = new Point(120, 68);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(48, 48);
            Button_Delete.TabIndex = 44;
            Button_Delete.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Delete, "Delete");
            Button_Delete.UseVisualStyleBackColor = true;
            Button_Delete.Click += Button_Delete_Click;
            // 
            // Button_RotateReverseClock
            // 
            Button_RotateReverseClock.Anchor = AnchorStyles.None;
            Button_RotateReverseClock.AutoSize = true;
            Button_RotateReverseClock.Cursor = Cursors.Hand;
            Button_RotateReverseClock.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_RotateReverseClock.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_RotateReverseClock.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_RotateReverseClock.FlatStyle = FlatStyle.Flat;
            Button_RotateReverseClock.ForeColor = Color.White;
            Button_RotateReverseClock.Image = (Image)resources.GetObject("Button_RotateReverseClock.Image");
            Button_RotateReverseClock.Location = new Point(66, 14);
            Button_RotateReverseClock.Name = "Button_RotateReverseClock";
            Button_RotateReverseClock.Size = new Size(48, 48);
            Button_RotateReverseClock.TabIndex = 43;
            Button_RotateReverseClock.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_RotateReverseClock, "Rotate Reverse Clock");
            Button_RotateReverseClock.UseVisualStyleBackColor = true;
            // 
            // Button_RotateClock
            // 
            Button_RotateClock.Anchor = AnchorStyles.None;
            Button_RotateClock.AutoSize = true;
            Button_RotateClock.Cursor = Cursors.Hand;
            Button_RotateClock.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_RotateClock.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_RotateClock.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_RotateClock.FlatStyle = FlatStyle.Flat;
            Button_RotateClock.ForeColor = Color.White;
            Button_RotateClock.Image = (Image)resources.GetObject("Button_RotateClock.Image");
            Button_RotateClock.Location = new Point(66, 68);
            Button_RotateClock.Name = "Button_RotateClock";
            Button_RotateClock.Size = new Size(48, 48);
            Button_RotateClock.TabIndex = 42;
            Button_RotateClock.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_RotateClock, "Rotate Clock");
            Button_RotateClock.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(243, 243, 243);
            panel2.Location = new Point(647, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 148);
            panel2.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(Button_Line);
            flowLayoutPanel1.Controls.Add(Button_Circle);
            flowLayoutPanel1.Controls.Add(Button_Rectangle);
            flowLayoutPanel1.Controls.Add(Button_Triangle);
            flowLayoutPanel1.Controls.Add(Button_RightTriangle);
            flowLayoutPanel1.Location = new Point(286, 14);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(231, 92);
            flowLayoutPanel1.TabIndex = 37;
            // 
            // Button_Line
            // 
            Button_Line.Anchor = AnchorStyles.None;
            Button_Line.AutoSize = true;
            Button_Line.Cursor = Cursors.Hand;
            Button_Line.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Line.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Line.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Line.FlatStyle = FlatStyle.Flat;
            Button_Line.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Line.Image = (Image)resources.GetObject("Button_Line.Image");
            Button_Line.Location = new Point(3, 3);
            Button_Line.Name = "Button_Line";
            Button_Line.Size = new Size(61, 58);
            Button_Line.TabIndex = 5;
            Button_Line.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Line, "Line");
            Button_Line.UseVisualStyleBackColor = true;
            Button_Line.Click += Button_Line_Click;
            // 
            // Button_Circle
            // 
            Button_Circle.Anchor = AnchorStyles.None;
            Button_Circle.AutoSize = true;
            Button_Circle.Cursor = Cursors.Hand;
            Button_Circle.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Circle.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Circle.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Circle.FlatStyle = FlatStyle.Flat;
            Button_Circle.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Circle.Image = (Image)resources.GetObject("Button_Circle.Image");
            Button_Circle.Location = new Point(70, 3);
            Button_Circle.Name = "Button_Circle";
            Button_Circle.Size = new Size(61, 58);
            Button_Circle.TabIndex = 6;
            Button_Circle.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Circle, "Circle");
            Button_Circle.UseVisualStyleBackColor = true;
            Button_Circle.Click += Button_Circle_Click;
            // 
            // Button_Rectangle
            // 
            Button_Rectangle.Anchor = AnchorStyles.None;
            Button_Rectangle.AutoSize = true;
            Button_Rectangle.Cursor = Cursors.Hand;
            Button_Rectangle.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Rectangle.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Rectangle.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Rectangle.FlatStyle = FlatStyle.Flat;
            Button_Rectangle.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Rectangle.Image = (Image)resources.GetObject("Button_Rectangle.Image");
            Button_Rectangle.Location = new Point(137, 3);
            Button_Rectangle.Name = "Button_Rectangle";
            Button_Rectangle.Size = new Size(61, 58);
            Button_Rectangle.TabIndex = 7;
            Button_Rectangle.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Rectangle, "Rectangle");
            Button_Rectangle.UseVisualStyleBackColor = true;
            Button_Rectangle.Click += Button_Rectangle_Click;
            // 
            // Button_Triangle
            // 
            Button_Triangle.Anchor = AnchorStyles.None;
            Button_Triangle.AutoSize = true;
            Button_Triangle.Cursor = Cursors.Hand;
            Button_Triangle.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Triangle.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Triangle.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Triangle.FlatStyle = FlatStyle.Flat;
            Button_Triangle.ForeColor = Color.White;
            Button_Triangle.Image = (Image)resources.GetObject("Button_Triangle.Image");
            Button_Triangle.Location = new Point(3, 67);
            Button_Triangle.Name = "Button_Triangle";
            Button_Triangle.Size = new Size(61, 58);
            Button_Triangle.TabIndex = 8;
            Button_Triangle.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Triangle, "Triangle");
            Button_Triangle.UseVisualStyleBackColor = true;
            Button_Triangle.Click += Button_Triangle_Click;
            // 
            // Button_RightTriangle
            // 
            Button_RightTriangle.Anchor = AnchorStyles.None;
            Button_RightTriangle.AutoSize = true;
            Button_RightTriangle.Cursor = Cursors.Hand;
            Button_RightTriangle.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_RightTriangle.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_RightTriangle.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_RightTriangle.FlatStyle = FlatStyle.Flat;
            Button_RightTriangle.ForeColor = Color.FromArgb(249, 249, 249);
            Button_RightTriangle.Image = (Image)resources.GetObject("Button_RightTriangle.Image");
            Button_RightTriangle.Location = new Point(70, 67);
            Button_RightTriangle.Name = "Button_RightTriangle";
            Button_RightTriangle.Size = new Size(61, 59);
            Button_RightTriangle.TabIndex = 9;
            Button_RightTriangle.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_RightTriangle, "Right Triangle");
            Button_RightTriangle.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(243, 243, 243);
            panel1.Location = new Point(242, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 148);
            panel1.TabIndex = 38;
            // 
            // Button_PurpleTwo
            // 
            Button_PurpleTwo.Anchor = AnchorStyles.None;
            Button_PurpleTwo.BackColor = Color.FromArgb(157, 83, 255);
            Button_PurpleTwo.Cursor = Cursors.Hand;
            Button_PurpleTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_PurpleTwo.FlatAppearance.BorderSize = 0;
            Button_PurpleTwo.FlatStyle = FlatStyle.Popup;
            Button_PurpleTwo.ForeColor = Color.Transparent;
            Button_PurpleTwo.Location = new Point(1057, 78);
            Button_PurpleTwo.Name = "Button_PurpleTwo";
            Button_PurpleTwo.Size = new Size(35, 25);
            Button_PurpleTwo.TabIndex = 36;
            Button_PurpleTwo.Tag = "ColorButton";
            Button_PurpleTwo.UseVisualStyleBackColor = false;
            // 
            // Button_PurpleOne
            // 
            Button_PurpleOne.Anchor = AnchorStyles.None;
            Button_PurpleOne.BackColor = Color.FromArgb(182, 125, 252);
            Button_PurpleOne.Cursor = Cursors.Hand;
            Button_PurpleOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_PurpleOne.FlatAppearance.BorderSize = 0;
            Button_PurpleOne.FlatStyle = FlatStyle.Popup;
            Button_PurpleOne.ForeColor = Color.Transparent;
            Button_PurpleOne.Location = new Point(1057, 47);
            Button_PurpleOne.Name = "Button_PurpleOne";
            Button_PurpleOne.Size = new Size(35, 25);
            Button_PurpleOne.TabIndex = 35;
            Button_PurpleOne.Tag = "ColorButton";
            Button_PurpleOne.UseVisualStyleBackColor = false;
            // 
            // Button_BlueTwo
            // 
            Button_BlueTwo.Anchor = AnchorStyles.None;
            Button_BlueTwo.BackColor = Color.FromArgb(72, 104, 231);
            Button_BlueTwo.Cursor = Cursors.Hand;
            Button_BlueTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BlueTwo.FlatAppearance.BorderSize = 0;
            Button_BlueTwo.FlatStyle = FlatStyle.Popup;
            Button_BlueTwo.ForeColor = Color.Transparent;
            Button_BlueTwo.Location = new Point(1098, 78);
            Button_BlueTwo.Name = "Button_BlueTwo";
            Button_BlueTwo.Size = new Size(35, 25);
            Button_BlueTwo.TabIndex = 34;
            Button_BlueTwo.Tag = "ColorButton";
            Button_BlueTwo.UseVisualStyleBackColor = false;
            // 
            // Button_BlueOne
            // 
            Button_BlueOne.Anchor = AnchorStyles.None;
            Button_BlueOne.BackColor = Color.FromArgb(120, 144, 239);
            Button_BlueOne.Cursor = Cursors.Hand;
            Button_BlueOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BlueOne.FlatAppearance.BorderSize = 0;
            Button_BlueOne.FlatStyle = FlatStyle.Popup;
            Button_BlueOne.ForeColor = Color.Transparent;
            Button_BlueOne.Location = new Point(1098, 47);
            Button_BlueOne.Name = "Button_BlueOne";
            Button_BlueOne.Size = new Size(35, 25);
            Button_BlueOne.TabIndex = 33;
            Button_BlueOne.Tag = "ColorButton";
            Button_BlueOne.UseVisualStyleBackColor = false;
            // 
            // Button_YellowTwo
            // 
            Button_YellowTwo.Anchor = AnchorStyles.None;
            Button_YellowTwo.BackColor = Color.FromArgb(252, 229, 97);
            Button_YellowTwo.Cursor = Cursors.Hand;
            Button_YellowTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_YellowTwo.FlatAppearance.BorderSize = 0;
            Button_YellowTwo.FlatStyle = FlatStyle.Popup;
            Button_YellowTwo.ForeColor = Color.Transparent;
            Button_YellowTwo.Location = new Point(1016, 78);
            Button_YellowTwo.Name = "Button_YellowTwo";
            Button_YellowTwo.Size = new Size(35, 25);
            Button_YellowTwo.TabIndex = 32;
            Button_YellowTwo.Tag = "ColorButton";
            Button_YellowTwo.UseVisualStyleBackColor = false;
            // 
            // Button_YellowOne
            // 
            Button_YellowOne.Anchor = AnchorStyles.None;
            Button_YellowOne.BackColor = Color.FromArgb(240, 227, 153);
            Button_YellowOne.Cursor = Cursors.Hand;
            Button_YellowOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_YellowOne.FlatAppearance.BorderSize = 0;
            Button_YellowOne.FlatStyle = FlatStyle.Popup;
            Button_YellowOne.ForeColor = Color.Transparent;
            Button_YellowOne.Location = new Point(1016, 47);
            Button_YellowOne.Name = "Button_YellowOne";
            Button_YellowOne.Size = new Size(35, 25);
            Button_YellowOne.TabIndex = 31;
            Button_YellowOne.Tag = "ColorButton";
            Button_YellowOne.UseVisualStyleBackColor = false;
            // 
            // Button_Blue
            // 
            Button_Blue.Anchor = AnchorStyles.None;
            Button_Blue.BackColor = Color.FromArgb(23, 53, 189);
            Button_Blue.Cursor = Cursors.Hand;
            Button_Blue.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Blue.FlatAppearance.BorderSize = 0;
            Button_Blue.FlatStyle = FlatStyle.Popup;
            Button_Blue.ForeColor = Color.Transparent;
            Button_Blue.Location = new Point(1098, 16);
            Button_Blue.Name = "Button_Blue";
            Button_Blue.Size = new Size(35, 25);
            Button_Blue.TabIndex = 30;
            Button_Blue.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Blue, "Blue");
            Button_Blue.UseVisualStyleBackColor = false;
            // 
            // Button_Purple
            // 
            Button_Purple.Anchor = AnchorStyles.None;
            Button_Purple.BackColor = Color.FromArgb(103, 34, 217);
            Button_Purple.Cursor = Cursors.Hand;
            Button_Purple.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Purple.FlatAppearance.BorderSize = 0;
            Button_Purple.FlatStyle = FlatStyle.Popup;
            Button_Purple.ForeColor = Color.Transparent;
            Button_Purple.Location = new Point(1057, 16);
            Button_Purple.Name = "Button_Purple";
            Button_Purple.Size = new Size(35, 25);
            Button_Purple.TabIndex = 29;
            Button_Purple.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Purple, "Purple");
            Button_Purple.UseVisualStyleBackColor = false;
            // 
            // Button_Yellow
            // 
            Button_Yellow.Anchor = AnchorStyles.None;
            Button_Yellow.BackColor = Color.FromArgb(255, 231, 0);
            Button_Yellow.Cursor = Cursors.Hand;
            Button_Yellow.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Yellow.FlatAppearance.BorderSize = 0;
            Button_Yellow.FlatStyle = FlatStyle.Popup;
            Button_Yellow.ForeColor = Color.Transparent;
            Button_Yellow.Location = new Point(1016, 16);
            Button_Yellow.Name = "Button_Yellow";
            Button_Yellow.Size = new Size(35, 25);
            Button_Yellow.TabIndex = 28;
            Button_Yellow.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Yellow, "Yellow");
            Button_Yellow.UseVisualStyleBackColor = false;
            // 
            // Button_RedTwo
            // 
            Button_RedTwo.Anchor = AnchorStyles.None;
            Button_RedTwo.BackColor = Color.FromArgb(255, 67, 89);
            Button_RedTwo.Cursor = Cursors.Hand;
            Button_RedTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_RedTwo.FlatAppearance.BorderSize = 0;
            Button_RedTwo.FlatStyle = FlatStyle.Popup;
            Button_RedTwo.ForeColor = Color.Transparent;
            Button_RedTwo.Location = new Point(975, 78);
            Button_RedTwo.Name = "Button_RedTwo";
            Button_RedTwo.Size = new Size(35, 25);
            Button_RedTwo.TabIndex = 27;
            Button_RedTwo.Tag = "ColorButton";
            Button_RedTwo.UseVisualStyleBackColor = false;
            // 
            // Button_RedOne
            // 
            Button_RedOne.Anchor = AnchorStyles.None;
            Button_RedOne.BackColor = Color.FromArgb(252, 115, 131);
            Button_RedOne.Cursor = Cursors.Hand;
            Button_RedOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_RedOne.FlatAppearance.BorderSize = 0;
            Button_RedOne.FlatStyle = FlatStyle.Popup;
            Button_RedOne.ForeColor = Color.Transparent;
            Button_RedOne.Location = new Point(975, 47);
            Button_RedOne.Name = "Button_RedOne";
            Button_RedOne.Size = new Size(35, 25);
            Button_RedOne.TabIndex = 26;
            Button_RedOne.Tag = "ColorButton";
            Button_RedOne.UseVisualStyleBackColor = false;
            // 
            // Button_Red
            // 
            Button_Red.Anchor = AnchorStyles.None;
            Button_Red.BackColor = Color.FromArgb(213, 23, 33);
            Button_Red.Cursor = Cursors.Hand;
            Button_Red.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Red.FlatAppearance.BorderSize = 0;
            Button_Red.FlatStyle = FlatStyle.Popup;
            Button_Red.ForeColor = Color.Transparent;
            Button_Red.Location = new Point(975, 16);
            Button_Red.Name = "Button_Red";
            Button_Red.Size = new Size(35, 25);
            Button_Red.TabIndex = 23;
            Button_Red.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Red, "Red");
            Button_Red.UseVisualStyleBackColor = false;
            // 
            // Button_BrownTwo
            // 
            Button_BrownTwo.Anchor = AnchorStyles.None;
            Button_BrownTwo.BackColor = Color.FromArgb(189, 150, 137);
            Button_BrownTwo.Cursor = Cursors.Hand;
            Button_BrownTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BrownTwo.FlatAppearance.BorderSize = 0;
            Button_BrownTwo.FlatStyle = FlatStyle.Popup;
            Button_BrownTwo.ForeColor = Color.Transparent;
            Button_BrownTwo.Location = new Point(934, 78);
            Button_BrownTwo.Name = "Button_BrownTwo";
            Button_BrownTwo.Size = new Size(35, 25);
            Button_BrownTwo.TabIndex = 21;
            Button_BrownTwo.Tag = "ColorButton";
            Button_BrownTwo.UseVisualStyleBackColor = false;
            // 
            // Button_GreenTwo
            // 
            Button_GreenTwo.Anchor = AnchorStyles.None;
            Button_GreenTwo.BackColor = Color.FromArgb(0, 130, 38);
            Button_GreenTwo.Cursor = Cursors.Hand;
            Button_GreenTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_GreenTwo.FlatAppearance.BorderSize = 0;
            Button_GreenTwo.FlatStyle = FlatStyle.Popup;
            Button_GreenTwo.ForeColor = Color.Transparent;
            Button_GreenTwo.Location = new Point(893, 78);
            Button_GreenTwo.Name = "Button_GreenTwo";
            Button_GreenTwo.Size = new Size(35, 25);
            Button_GreenTwo.TabIndex = 20;
            Button_GreenTwo.Tag = "ColorButton";
            Button_GreenTwo.UseVisualStyleBackColor = false;
            // 
            // Button_BrownOne
            // 
            Button_BrownOne.Anchor = AnchorStyles.None;
            Button_BrownOne.BackColor = Color.FromArgb(209, 179, 165);
            Button_BrownOne.Cursor = Cursors.Hand;
            Button_BrownOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BrownOne.FlatAppearance.BorderSize = 0;
            Button_BrownOne.FlatStyle = FlatStyle.Popup;
            Button_BrownOne.ForeColor = Color.Transparent;
            Button_BrownOne.Location = new Point(934, 47);
            Button_BrownOne.Name = "Button_BrownOne";
            Button_BrownOne.Size = new Size(35, 25);
            Button_BrownOne.TabIndex = 19;
            Button_BrownOne.Tag = "ColorButton";
            Button_BrownOne.UseVisualStyleBackColor = false;
            // 
            // Button_GreenOne
            // 
            Button_GreenOne.Anchor = AnchorStyles.None;
            Button_GreenOne.BackColor = Color.FromArgb(0, 158, 47);
            Button_GreenOne.Cursor = Cursors.Hand;
            Button_GreenOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_GreenOne.FlatAppearance.BorderSize = 0;
            Button_GreenOne.FlatStyle = FlatStyle.Popup;
            Button_GreenOne.ForeColor = Color.Transparent;
            Button_GreenOne.Location = new Point(893, 47);
            Button_GreenOne.Name = "Button_GreenOne";
            Button_GreenOne.Size = new Size(35, 25);
            Button_GreenOne.TabIndex = 18;
            Button_GreenOne.Tag = "ColorButton";
            Button_GreenOne.UseVisualStyleBackColor = false;
            // 
            // Button_OrangeTwo
            // 
            Button_OrangeTwo.Anchor = AnchorStyles.None;
            Button_OrangeTwo.BackColor = Color.FromArgb(181, 87, 0);
            Button_OrangeTwo.Cursor = Cursors.Hand;
            Button_OrangeTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_OrangeTwo.FlatAppearance.BorderSize = 0;
            Button_OrangeTwo.FlatStyle = FlatStyle.Popup;
            Button_OrangeTwo.ForeColor = Color.Transparent;
            Button_OrangeTwo.Location = new Point(852, 78);
            Button_OrangeTwo.Name = "Button_OrangeTwo";
            Button_OrangeTwo.Size = new Size(35, 25);
            Button_OrangeTwo.TabIndex = 17;
            Button_OrangeTwo.Tag = "ColorButton";
            Button_OrangeTwo.UseVisualStyleBackColor = false;
            // 
            // Button_WhiteTwo
            // 
            Button_WhiteTwo.Anchor = AnchorStyles.None;
            Button_WhiteTwo.BackColor = Color.FromArgb(191, 188, 191);
            Button_WhiteTwo.Cursor = Cursors.Hand;
            Button_WhiteTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_WhiteTwo.FlatAppearance.BorderSize = 0;
            Button_WhiteTwo.FlatStyle = FlatStyle.Popup;
            Button_WhiteTwo.ForeColor = Color.Transparent;
            Button_WhiteTwo.Location = new Point(811, 78);
            Button_WhiteTwo.Name = "Button_WhiteTwo";
            Button_WhiteTwo.Size = new Size(35, 25);
            Button_WhiteTwo.TabIndex = 16;
            Button_WhiteTwo.Tag = "ColorButton";
            Button_WhiteTwo.UseVisualStyleBackColor = false;
            // 
            // Button_WhiteOne
            // 
            Button_WhiteOne.Anchor = AnchorStyles.None;
            Button_WhiteOne.BackColor = Color.FromArgb(218, 215, 218);
            Button_WhiteOne.Cursor = Cursors.Hand;
            Button_WhiteOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_WhiteOne.FlatAppearance.BorderSize = 0;
            Button_WhiteOne.FlatStyle = FlatStyle.Popup;
            Button_WhiteOne.ForeColor = Color.Transparent;
            Button_WhiteOne.Location = new Point(811, 47);
            Button_WhiteOne.Name = "Button_WhiteOne";
            Button_WhiteOne.Size = new Size(35, 25);
            Button_WhiteOne.TabIndex = 15;
            Button_WhiteOne.Tag = "ColorButton";
            Button_WhiteOne.UseVisualStyleBackColor = false;
            // 
            // Button_BlackTwo
            // 
            Button_BlackTwo.Anchor = AnchorStyles.None;
            Button_BlackTwo.BackColor = Color.FromArgb(44, 44, 44);
            Button_BlackTwo.Cursor = Cursors.Hand;
            Button_BlackTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BlackTwo.FlatAppearance.BorderSize = 0;
            Button_BlackTwo.FlatStyle = FlatStyle.Popup;
            Button_BlackTwo.ForeColor = Color.Transparent;
            Button_BlackTwo.Location = new Point(770, 78);
            Button_BlackTwo.Name = "Button_BlackTwo";
            Button_BlackTwo.Size = new Size(35, 25);
            Button_BlackTwo.TabIndex = 14;
            Button_BlackTwo.Tag = "ColorButton";
            Button_BlackTwo.UseVisualStyleBackColor = false;
            // 
            // Button_BlackOne
            // 
            Button_BlackOne.Anchor = AnchorStyles.None;
            Button_BlackOne.BackColor = Color.FromArgb(101, 98, 101);
            Button_BlackOne.Cursor = Cursors.Hand;
            Button_BlackOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BlackOne.FlatAppearance.BorderSize = 0;
            Button_BlackOne.FlatStyle = FlatStyle.Popup;
            Button_BlackOne.ForeColor = Color.Transparent;
            Button_BlackOne.Location = new Point(770, 47);
            Button_BlackOne.Name = "Button_BlackOne";
            Button_BlackOne.Size = new Size(35, 25);
            Button_BlackOne.TabIndex = 13;
            Button_BlackOne.Tag = "ColorButton";
            Button_BlackOne.UseVisualStyleBackColor = false;
            // 
            // Button_OrangeOne
            // 
            Button_OrangeOne.Anchor = AnchorStyles.None;
            Button_OrangeOne.BackColor = Color.FromArgb(240, 160, 78);
            Button_OrangeOne.Cursor = Cursors.Hand;
            Button_OrangeOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_OrangeOne.FlatAppearance.BorderSize = 0;
            Button_OrangeOne.FlatStyle = FlatStyle.Popup;
            Button_OrangeOne.ForeColor = Color.Transparent;
            Button_OrangeOne.Location = new Point(852, 47);
            Button_OrangeOne.Name = "Button_OrangeOne";
            Button_OrangeOne.Size = new Size(35, 25);
            Button_OrangeOne.TabIndex = 12;
            Button_OrangeOne.Tag = "ColorButton";
            Button_OrangeOne.UseVisualStyleBackColor = false;
            // 
            // Button_Brown
            // 
            Button_Brown.Anchor = AnchorStyles.None;
            Button_Brown.BackColor = Color.FromArgb(142, 107, 94);
            Button_Brown.Cursor = Cursors.Hand;
            Button_Brown.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Brown.FlatAppearance.BorderSize = 0;
            Button_Brown.FlatStyle = FlatStyle.Popup;
            Button_Brown.ForeColor = Color.Transparent;
            Button_Brown.Location = new Point(934, 16);
            Button_Brown.Name = "Button_Brown";
            Button_Brown.Size = new Size(35, 25);
            Button_Brown.TabIndex = 11;
            Button_Brown.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Brown, "Light Brown");
            Button_Brown.UseVisualStyleBackColor = false;
            // 
            // Button_Green
            // 
            Button_Green.Anchor = AnchorStyles.None;
            Button_Green.BackColor = Color.FromArgb(0, 181, 54);
            Button_Green.Cursor = Cursors.Hand;
            Button_Green.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Green.FlatAppearance.BorderSize = 0;
            Button_Green.FlatStyle = FlatStyle.Popup;
            Button_Green.ForeColor = Color.Transparent;
            Button_Green.Location = new Point(893, 16);
            Button_Green.Name = "Button_Green";
            Button_Green.Size = new Size(35, 25);
            Button_Green.TabIndex = 10;
            Button_Green.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Green, "Green");
            Button_Green.UseVisualStyleBackColor = false;
            // 
            // Button_Orange
            // 
            Button_Orange.Anchor = AnchorStyles.None;
            Button_Orange.BackColor = Color.FromArgb(255, 128, 0);
            Button_Orange.Cursor = Cursors.Hand;
            Button_Orange.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Orange.FlatAppearance.BorderSize = 0;
            Button_Orange.FlatStyle = FlatStyle.Popup;
            Button_Orange.ForeColor = Color.Transparent;
            Button_Orange.Location = new Point(852, 16);
            Button_Orange.Name = "Button_Orange";
            Button_Orange.Size = new Size(35, 25);
            Button_Orange.TabIndex = 9;
            Button_Orange.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Orange, "Orange");
            Button_Orange.UseVisualStyleBackColor = false;
            // 
            // Button_White
            // 
            Button_White.Anchor = AnchorStyles.None;
            Button_White.BackColor = Color.White;
            Button_White.Cursor = Cursors.Hand;
            Button_White.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_White.FlatAppearance.BorderSize = 0;
            Button_White.FlatStyle = FlatStyle.Popup;
            Button_White.ForeColor = Color.Transparent;
            Button_White.Location = new Point(811, 16);
            Button_White.Name = "Button_White";
            Button_White.Size = new Size(35, 25);
            Button_White.TabIndex = 8;
            Button_White.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_White, "White");
            Button_White.UseVisualStyleBackColor = false;
            // 
            // Button_Black
            // 
            Button_Black.Anchor = AnchorStyles.None;
            Button_Black.BackColor = Color.Black;
            Button_Black.Cursor = Cursors.Hand;
            Button_Black.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Black.FlatAppearance.BorderSize = 0;
            Button_Black.FlatStyle = FlatStyle.Popup;
            Button_Black.ForeColor = Color.Transparent;
            Button_Black.Location = new Point(770, 16);
            Button_Black.Name = "Button_Black";
            Button_Black.Size = new Size(35, 25);
            Button_Black.TabIndex = 8;
            Button_Black.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Black, "Black");
            Button_Black.UseVisualStyleBackColor = false;
            // 
            // Button_Eraser
            // 
            Button_Eraser.Anchor = AnchorStyles.None;
            Button_Eraser.AutoSize = true;
            Button_Eraser.Cursor = Cursors.Hand;
            Button_Eraser.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Eraser.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Eraser.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Eraser.FlatStyle = FlatStyle.Flat;
            Button_Eraser.ForeColor = Color.White;
            Button_Eraser.Image = (Image)resources.GetObject("Button_Eraser.Image");
            Button_Eraser.Location = new Point(120, 14);
            Button_Eraser.Name = "Button_Eraser";
            Button_Eraser.Size = new Size(48, 48);
            Button_Eraser.TabIndex = 4;
            Button_Eraser.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Eraser, "Eraser");
            Button_Eraser.UseVisualStyleBackColor = true;
            Button_Eraser.Click += Button_Eraser_Click;
            // 
            // Button_Pencil
            // 
            Button_Pencil.Anchor = AnchorStyles.None;
            Button_Pencil.AutoSize = true;
            Button_Pencil.Cursor = Cursors.Hand;
            Button_Pencil.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Pencil.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Pencil.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Pencil.FlatStyle = FlatStyle.Flat;
            Button_Pencil.ForeColor = Color.White;
            Button_Pencil.Image = (Image)resources.GetObject("Button_Pencil.Image");
            Button_Pencil.Location = new Point(12, 68);
            Button_Pencil.Name = "Button_Pencil";
            Button_Pencil.Size = new Size(48, 48);
            Button_Pencil.TabIndex = 3;
            Button_Pencil.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Pencil, "Pencil");
            Button_Pencil.UseVisualStyleBackColor = true;
            Button_Pencil.Click += Button_Pencil_Click;
            // 
            // Button_Fill
            // 
            Button_Fill.Anchor = AnchorStyles.None;
            Button_Fill.AutoSize = true;
            Button_Fill.Cursor = Cursors.Hand;
            Button_Fill.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Fill.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Fill.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Fill.FlatStyle = FlatStyle.Flat;
            Button_Fill.ForeColor = Color.Black;
            Button_Fill.Image = (Image)resources.GetObject("Button_Fill.Image");
            Button_Fill.Location = new Point(12, 14);
            Button_Fill.Name = "Button_Fill";
            Button_Fill.Size = new Size(48, 48);
            Button_Fill.TabIndex = 2;
            Button_Fill.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Fill, "Fill Bucket");
            Button_Fill.UseVisualStyleBackColor = true;
            Button_Fill.Click += Button_Fill_Click;
            // 
            // Button_Color
            // 
            Button_Color.Anchor = AnchorStyles.None;
            Button_Color.AutoSize = true;
            Button_Color.BackColor = Color.FromArgb(249, 249, 249);
            Button_Color.Cursor = Cursors.Hand;
            Button_Color.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Color.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Color.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Color.FlatStyle = FlatStyle.Flat;
            Button_Color.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Color.Image = (Image)resources.GetObject("Button_Color.Image");
            Button_Color.Location = new Point(686, 82);
            Button_Color.Name = "Button_Color";
            Button_Color.Size = new Size(58, 58);
            Button_Color.TabIndex = 1;
            Button_Color.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Color, "Color Picker");
            Button_Color.UseVisualStyleBackColor = false;
            Button_Color.Click += Button_Color_Click;
            // 
            // PictureBox_OutlineColor
            // 
            PictureBox_OutlineColor.Anchor = AnchorStyles.None;
            PictureBox_OutlineColor.AutoSize = true;
            PictureBox_OutlineColor.BackColor = Color.Black;
            PictureBox_OutlineColor.Enabled = false;
            PictureBox_OutlineColor.FlatAppearance.BorderSize = 3;
            PictureBox_OutlineColor.Location = new Point(686, 14);
            PictureBox_OutlineColor.Margin = new Padding(4);
            PictureBox_OutlineColor.Name = "PictureBox_OutlineColor";
            PictureBox_OutlineColor.Size = new Size(60, 58);
            PictureBox_OutlineColor.TabIndex = 0;
            toolTip1.SetToolTip(PictureBox_OutlineColor, "Active Color");
            PictureBox_OutlineColor.UseVisualStyleBackColor = false;
            // 
            // PictureBox
            // 
            PictureBox.Anchor = AnchorStyles.None;
            PictureBox.BackColor = Color.White;
            PictureBox.Location = new Point(0, 173);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(1154, 531);
            PictureBox.TabIndex = 2;
            PictureBox.TabStop = false;
            PictureBox.Paint += PictureBox_Paint;
            PictureBox.MouseClick += PictureBox_MouseClick;
            PictureBox.MouseDoubleClick += PictureBox_MouseDoubleClick;
            PictureBox.MouseDown += PictureBox_MouseDown;
            PictureBox.MouseMove += PictureBox_MouseMove;
            PictureBox.MouseUp += PictureBox_MouseUp;
            // 
            // DrawingApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 704);
            Controls.Add(PictureBox);
            Controls.Add(Panel);
            Controls.Add(MenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Name = "DrawingApp";
            Text = "Drawing App ver 0.2";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem SaveMenu;
        private ToolStripMenuItem OpenMenu;
        private Panel Panel;
        private PictureBox PictureBox;
        private Button Button_Color;
        private Button PictureBox_OutlineColor;
        private ToolStripMenuItem ToolMenu;
        private ToolStripMenuItem FillBucketMenu;
        private ToolStripMenuItem RotateReverseMenu;
        private Button Button_Fill;
        private ToolStripMenuItem PencilMenu;
        private Button Button_Eraser;
        private Button Button_Pencil;
        private Button Button_White;
        private Button Button_Black;
        private Button Button_BrownTwo;
        private Button Button_GreenTwo;
        private Button Button_BrownOne;
        private Button Button_GreenOne;
        private Button Button_OrangeTwo;
        private Button Button_WhiteTwo;
        private Button Button_WhiteOne;
        private Button Button_BlackTwo;
        private Button Button_BlackOne;
        private Button Button_OrangeOne;
        private Button Button_Brown;
        private Button Button_Green;
        private Button Button_Orange;
        private Button Button_Red;
        private Button Button_PurpleTwo;
        private Button Button_PurpleOne;
        private Button Button_BlueTwo;
        private Button Button_BlueOne;
        private Button Button_YellowTwo;
        private Button Button_YellowOne;
        private Button Button_Blue;
        private Button Button_Purple;
        private Button Button_Yellow;
        private Button Button_RedTwo;
        private Button Button_RedOne;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Button_Line;
        private Panel panel1;
        private Panel panel2;
        private Button Button_Circle;
        private Button Button_Rectangle;
        private Button Button_Triangle;
        private Button Button_RightTriangle;
        private Button Button_RotateClock;
        private ToolTip toolTip1;
        private Button Button_Delete;
        private Button Button_RotateReverseClock;
        private Label Label_Tools;
        private Label Label_Colors;
        private Label Label_Shapes;
        private ToolStripMenuItem RotateMenu;
        private ToolStripMenuItem EraserMenu;
        private ToolStripMenuItem DeleteMenu;
        private ToolStripMenuItem shapesToolStripMenuItem;
        private ToolStripMenuItem LineMenu;
        private ToolStripMenuItem CircleMenu;
        private ToolStripMenuItem RectangleMenu;
        private ToolStripMenuItem TriangleMenu;
        private ToolStripMenuItem RightTriangleMenu;
        private Button Button_Move;
        private Button Button_Clear;
    }
}