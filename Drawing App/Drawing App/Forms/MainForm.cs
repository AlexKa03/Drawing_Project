using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Drawing_App.Shapes;
using Drawing_App.Shapes.Shapes;
using Drawing_App.Forms;
using System.Reflection;

namespace Drawing_App
{
    public partial class DrawingApp : Form
    {

        public DrawingApp()
        {
            InitializeComponent();
            Icon myIcon = LoadIconFromResources("Drawing_App.icon.ico");

            Width = 1172;
            Height = 751;

            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            PictureBox.Image = bitmap;

            this.Load += ColorButtons_Load;
        }
        private Icon LoadIconFromResources(string icon)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(icon))
            {
                if (stream != null)
                {
                    return new Icon(stream);
                }
                else
                {
                    throw new ArgumentException($"Resource '{icon}' not found.");
                }
            }
        }

        //---------------------------------- Variables ---------------------------------
        List<Shape> shapes = new List<Shape>();
        Shape selectedShape = null;
        Graphics graphics;
        Bitmap bitmap;
        Point pointX, pointY;
        Pen pencil = new Pen(Color.Black, 25);
        int xOne, yOne, xTwo, yTwo, xThree, yThree = 0;
        bool isPainting = false;
        string whatToDo = string.Empty;
        ColorDialog colorDialog = new ColorDialog();
        Color newColor;
        Color fillColor;
        //------------------------------------------------------------------------------


        //--------------------------------- Menu Strip ---------------------------------
        private void SaveMenu_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image(*.png)|*.png|(*.*|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = bitmap.Clone(new Rectangle(0, 0, PictureBox.Width, PictureBox.Height), bitmap.PixelFormat);
                bm.Save(saveFileDialog.FileName, ImageFormat.Png);

                MessageBox.Show("Image Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //------------------------------------------------------------------------------


        //-------------------------- Preview what is drawing ---------------------------
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Smoothing(e);

            Pen previewPencil = new Pen(Color.FromArgb(100, 101, 98, 101), 4);
            previewPencil.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            previewPencil.DashPattern = new float[] { 3.3F, 1.6F, 0.8F, 2.2F };

            // Create a bitmap for the custom pattern
            Bitmap patternBitmap = new Bitmap(10, 10);
            using (Graphics patternGraphics = Graphics.FromImage(patternBitmap))
            {
                patternGraphics.Clear(Color.Transparent);
                using (Pen customPatternPen = new Pen(Color.FromArgb(100, 101, 98, 101), 2))
                {
                    customPatternPen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                    customPatternPen.DashPattern = new float[] { 4F, 2F, 1F, 3F };
                    patternGraphics.DrawLine(customPatternPen, 0, 0, 10, 10);
                }
            }

            if (isPainting)
            {
                if (whatToDo == "line".ToLower())
                {
                    graphics.DrawLine(previewPencil, xThree, yThree, xOne, yOne);
                }
                else if (whatToDo == "circle".ToLower())
                {
                    graphics.DrawEllipse(previewPencil, xThree, yThree, xTwo, yTwo);

                    // Create a TextureBrush using the pattern bitmap
                    using (TextureBrush textureBrush = new TextureBrush(patternBitmap))
                    {
                        // Fill the ellipse with the custom pattern
                        graphics.FillEllipse(textureBrush, xThree, yThree, xTwo, yTwo);
                    }
                }
                else if (whatToDo == "rectangle".ToLower())
                {
                    graphics.DrawRectangle(previewPencil, xThree, yThree, xTwo, yTwo);

                    // Create a TextureBrush using the pattern bitmap
                    using (TextureBrush textureBrush = new TextureBrush(patternBitmap))
                    {
                        // Fill the ellipse with the custom pattern
                        graphics.FillRectangle(textureBrush, xThree, yThree, xTwo, yTwo);
                    }
                }
                else if (whatToDo == "triangle".ToLower())
                {


                    Point[] trianglePoints = new Point[]
                    {
                    new Point(xThree, yThree + yTwo),
                    new Point(xThree + xTwo, yThree + yTwo),
                    new Point(xThree + xTwo / 2, yThree)
                    };

                    graphics.DrawPolygon(previewPencil, trianglePoints);

                    // Create a TextureBrush using the pattern bitmap
                    using (TextureBrush textureBrush = new TextureBrush(patternBitmap))
                    {
                        // Fill the ellipse with the custom pattern
                        graphics.FillPolygon(textureBrush, trianglePoints);
                    }
                }
            }
        }
        //------------------------------------------------------------------------------

        //---------------------------------- Tools -------------------------------------
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            DialogResult isCleared = MessageBox.Show("You are going to clear the drawing board and loose everything.\nDo you want to continue?", "Clearing Drawing Board", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (isCleared == DialogResult.Yes)
            {
                graphics.Clear(Color.White);
                PictureBox.Image = bitmap;

                for (int i = 0; i < shapes.Count; i++)
                {
                    shapes.Remove(shapes[i]);
                }
                whatToDo = string.Empty;
            }
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            whatToDo = "delete";
        }
        private void Button_Pencil_Click(object sender, EventArgs e)
        {
            whatToDo = "pencil";
        }
        private void Button_Eraser_Click(object sender, EventArgs e)
        {
            whatToDo = "eraser";
        }
        private void Button_Fill_Click(object sender, EventArgs e)
        {
            whatToDo = "fill";
        }
        private void Button_Move_Click(object sender, EventArgs e)
        {
            whatToDo = "move";
        }
        //------------------------------------------------------------------------------


        //---------------------------------- Shapees -----------------------------------
        private void Button_Line_Click(object sender, EventArgs e)
        {
            whatToDo = "line";
        }
        private void Button_Circle_Click(object sender, EventArgs e)
        {
            whatToDo = "circle";
        }
        private void Button_Rectangle_Click(object sender, EventArgs e)
        {
            whatToDo = "rectangle";
        }
        private void Button_Triangle_Click(object sender, EventArgs e)
        {
            whatToDo = "triangle";
        }
        //------------------------------------------------------------------------------

        //---------------------------------- Colors ------------------------------------
        private void Button_Color_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            newColor = colorDialog.Color;
            SetTheNewColor(newColor);
        }
        //------------------------------------------------------------------------------

        //---------------------------------- Drawing -----------------------------------
        private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point clickPoint = SetPoint(PictureBox, e.Location);

            Shape clickedShape = shapes.FirstOrDefault(shape => shape.ContainsPoint(clickPoint));

            

            if (clickedShape != null)
            {
                string shapeType = clickedShape.GetType().Name;

                ShapeProperties shapeInformation = new ShapeProperties(shapeType, 0, clickedShape.Width);

                if (shapeType == "RectangleShape")
                {
                    int height = clickedShape.Height;

                    shapeInformation = new ShapeProperties(shapeType, height, clickedShape.Width);
                    //shapeInformation.ShowDialog();
                }

                //ShapeProperties shapeInformation = new ShapeProperties(clickedShape, shapeType, shapes);
                shapeInformation.ShowDialog();
            }
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pointY = e.Location;
            isPainting = true;

            xThree = e.X;
            yThree = e.Y;

            if (whatToDo == "move")
            {
                selectedShape = shapes.FirstOrDefault(s => s.ContainsPoint(new Point(e.X, e.Y)));
            }
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (whatToDo == "fill".ToLower())
            {
                Point point = SetPoint(PictureBox, e.Location);
                FillMethod(bitmap, point.X, point.Y, newColor);
            }

            if (whatToDo == "delete".ToLower())
            {
                if (selectedShape != null)
                {
                    shapes.Remove(selectedShape);
                    graphics.Clear(Color.White);

                    foreach (var shape in shapes)
                    {
                        shape.Draw(graphics);
                    }

                    PictureBox.Refresh();
                    selectedShape = null;
                }
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPainting && whatToDo == "pencil".ToLower())
            {
                pointX = e.Location;
                graphics.DrawLine(pencil, pointX, pointY);
                pointY = pointX;
            }
            else if (isPainting && whatToDo == "eraser".ToLower())
            {
                SolidBrush eraser = new SolidBrush(Color.White);
                int eraserSize = 50;

                graphics.FillRectangle(eraser, e.X - eraserSize / 2, e.Y - eraserSize / 2, eraserSize, eraserSize);
            }

            xOne = e.X;
            yOne = e.Y;
            xTwo = e.X - xThree;
            yTwo = e.Y - yThree;

            if (isPainting && whatToDo == "move" && selectedShape != null)
            {
                int deltaX = e.X - xThree;
                int deltaY = e.Y - yThree;

                selectedShape.Move(deltaX, deltaY);

                xThree = e.X;
                yThree = e.Y;

                // Redraw all shapes
                graphics.Clear(Color.White);
                foreach (var shape in shapes)
                {
                    shape.Draw(graphics);
                }
            }

            PictureBox.Refresh();
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;

            xTwo = xOne - xThree;
            yTwo = yOne - yThree;

            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (whatToDo == "line".ToLower())
            {
                LineShape line = new LineShape(xThree, yThree, xOne, yOne, pencil.Color, pencil.Width);
                line.Draw(graphics);
                shapes.Add(line);

                //graphics.DrawLine(pencil, xThree, yThree, xOne, yOne);
            }
            else if (whatToDo == "circle".ToLower())
            {
                EllipseShape circle = new EllipseShape(xThree, yThree, xTwo, yTwo, pencil.Color, pencil.Width);
                circle.Draw(graphics);
                shapes.Add(circle);

                //Just drawn
                //graphics.DrawEllipse(pencil, xThree, yThree, xTwo, yTwo);
            }
            else if (whatToDo == "rectangle".ToLower())
            {
                RectangleShape rectangle = new RectangleShape(xThree, yThree, xTwo, yTwo, pencil.Color, pencil.Width);
                rectangle.Draw(graphics);
                shapes.Add(rectangle);

                //Just drawn
                //graphics.DrawRectangle(pencil, xThree, yThree, xTwo, yTwo);
            }
            else if (whatToDo == "triangle".ToLower())
            {
                TriangleShape triangle = new TriangleShape(xThree, yThree, xTwo, yTwo, pencil.Color, pencil.Width);
                triangle.Draw(graphics);
                shapes.Add(triangle);

                //Point[] trianglePoints = new Point[]
                //{
                //    new Point(xThree, yThree + yTwo), // bottom left
                //    new Point(xThree + xTwo, yThree + yTwo), // bottom right
                //    new Point(xThree + xTwo / 2, yThree) // midpoint top line
                //};
                //graphics.DrawPolygon(pencil, trianglePoints);
            }

            if (whatToDo == "move")
            {
                selectedShape = null;
            }
            else
            {
                // Update shape selection on mouse up for delete operation
                Point clickPoint = new Point(e.X, e.Y);
                selectedShape = shapes.FirstOrDefault(shape => shape.ContainsPoint(clickPoint));
            }
        }
        //------------------------------------------------------------------------------


        //------------------------------ Event Handler ---------------------------------
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            newColor = clickedButton.BackColor;
            SetTheNewColor(newColor);
        }
        private void ColorButtons_Load(object sender, EventArgs e)
        {
            foreach (var control in Panel.Controls
                             .Cast<Control>()
                             .Where(c => object.Equals(c.Tag, "ColorButton")))
            {
                Button_Black.Click += Button_Click;
                Button_BlackOne.Click += Button_Click;
                Button_BlackTwo.Click += Button_Click;

                Button_White.Click += Button_Click;
                Button_WhiteOne.Click += Button_Click;
                Button_WhiteTwo.Click += Button_Click;

                Button_Orange.Click += Button_Click;
                Button_OrangeOne.Click += Button_Click;
                Button_OrangeTwo.Click += Button_Click;

                Button_Green.Click += Button_Click;
                Button_GreenOne.Click += Button_Click;
                Button_GreenTwo.Click += Button_Click;

                Button_Brown.Click += Button_Click;
                Button_BrownOne.Click += Button_Click;
                Button_BrownTwo.Click += Button_Click;

                Button_Red.Click += Button_Click;
                Button_RedOne.Click += Button_Click;
                Button_RedTwo.Click += Button_Click;

                Button_Yellow.Click += Button_Click;
                Button_YellowOne.Click += Button_Click;
                Button_YellowTwo.Click += Button_Click;

                Button_Purple.Click += Button_Click;
                Button_PurpleOne.Click += Button_Click;
                Button_PurpleTwo.Click += Button_Click;

                Button_Blue.Click += Button_Click;
                Button_BlueOne.Click += Button_Click;
                Button_BlueTwo.Click += Button_Click;
            }
        }
        //------------------------------------------------------------------------------


        //---------------------------------- Methods -----------------------------------
        private void SetTheNewColor(Color newColor)
        {
            pencil.Color = newColor;
            PictureBox_OutlineColor.BackColor = newColor;
        }

        private void Smoothing(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System
                        .Drawing
                        .Drawing2D
                        .SmoothingMode
                        .AntiAlias;
        }

        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pointX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pointY = 1f * pictureBox.Image.Height / pictureBox.Height;

            return new Point((int)(pointX * point.X), (int)(pointY * point.Y));
        }
        private void ValidatePixel(Bitmap bitMap, Stack<Point> pixel, int x, int y, Color oldColor, Color newColor)
        {
            Color currentPixel = bitMap.GetPixel(x, y);

            if (currentPixel == oldColor)
            {
                pixel.Push(new Point(x, y));
                bitMap.SetPixel(x, y, newColor);
            }
        }
        public void FillMethod(Bitmap bitMap, int x, int y, Color newColor)
        {
            Color oldColor = bitMap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitMap.SetPixel(x, y, newColor);

            if (oldColor == newColor)
            {
                return;
            }

            while (pixel.Count > 0)
            {
                Point point = (Point)pixel.Pop();

                if (point.X > 0 &&
                    point.Y > 0 &&
                    point.X < bitMap.Width - 1 &&
                    point.Y < bitMap.Height - 1)
                {
                    ValidatePixel(bitMap, pixel, point.X - 1, point.Y, oldColor, newColor);
                    ValidatePixel(bitMap, pixel, point.X + 1, point.Y, oldColor, newColor);
                    ValidatePixel(bitMap, pixel, point.X, point.Y - 1, oldColor, newColor);
                    ValidatePixel(bitMap, pixel, point.X, point.Y + 1, oldColor, newColor);
                }
            }
        }
        //------------------------------------------------------------------------------
    }
}