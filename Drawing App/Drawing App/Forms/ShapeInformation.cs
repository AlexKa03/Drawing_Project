using Drawing_App.Shapes.Shapes;
using Drawing_App.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Drawing_App.Forms
{
    public partial class ShapeProperties : Form
    {
        private string _shapeType;
        private int _width;
        private int _height;

        public ShapeProperties(string shapeType, int height, int width)
        {
            InitializeComponent();
            Icon myIcon = LoadIconFromResources("Drawing_App.icon.ico");

            _shapeType = shapeType;
            _width = width;
            _height = height;

            CreateLabelsBasedOnShapeType(_shapeType, _height, _width);
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

        private void CreateLabelsBasedOnShapeType(string shapeType, int height, int width)
        {
            Label label = new Label();
            label.AutoSize = true;

            switch (shapeType)
            {
                case nameof(LineShape):
                    Text = "Line Properties";
                    label.Text = $"This is a line. Lenght: ";
                    break;

                case nameof(EllipseShape):
                    Text = "Circle Properties";
                    label.Text = "This is an ellipse.";
                    break;

                case nameof(RectangleShape):
                    Text = "Rectangle Properties";

                    // Height
                    Label labelHeight = new Label();
                    labelHeight.AutoSize = true;
                    labelHeight.Text = $"Height";
                    labelHeight.Location = new Point(12, 9);
                    labelHeight.Size = new Size(49, 20);
                    Controls.Add(labelHeight);

                    TextBox textBoxHeight = new TextBox();
                    textBoxHeight.AutoSize = true;
                    textBoxHeight.Text = height.ToString();
                    textBoxHeight.Location = new Point(12, 32);
                    textBoxHeight.Size = new Size(125, 27);
                    Controls.Add(textBoxHeight);

                    //Width
                    Label labelWidth = new Label();
                    labelWidth.AutoSize = true;
                    labelWidth.Text = $"Width";
                    labelWidth.Location = new Point(12, 83);
                    labelWidth.Size = new Size(49, 20);
                    Controls.Add(labelWidth);

                    TextBox textBoxWidth = new TextBox();
                    textBoxWidth.AutoSize = true;
                    textBoxWidth.Name = width.ToString();
                    textBoxWidth.Location = new Point(12, 106);
                    textBoxWidth.Size = new Size(125, 27);
                    Controls.Add(textBoxWidth);

                    //Perimeter
                    Label labelPerimeter = new Label();
                    labelPerimeter.AutoSize = true;
                    labelPerimeter.Text = $"Perimeter";
                    labelPerimeter.Location = new Point(207, 9);
                    labelPerimeter.Size = new Size(49, 20);
                    Controls.Add(labelPerimeter);

                    TextBox textBoxPerimeter = new TextBox();
                    textBoxPerimeter.AutoSize = true;
                    textBoxPerimeter.Text = (2 * (height + width)).ToString();
                    textBoxPerimeter.Location = new Point(207, 32);
                    textBoxPerimeter.Size = new Size(125, 27);
                    Controls.Add(textBoxPerimeter);

                    //Area
                    Label labelArea = new Label();
                    labelArea.AutoSize = true;
                    labelArea.Text = "Area";
                    labelArea.Location = new Point(207, 83);
                    labelArea.Size = new Size(49, 20);
                    Controls.Add(labelArea);

                    TextBox textBoxArea = new TextBox();
                    textBoxArea.AutoSize = true;
                    textBoxArea.Text = (width * height).ToString();
                    textBoxArea.Location = new Point(207, 106);
                    textBoxArea.Size = new Size(125, 27);
                    Controls.Add(textBoxArea);

                    break;

                case nameof(TriangleShape):
                    Text = "Triangle Properties";
                    label.Text = "This is a triangle.";
                    break;

                default:
                    PictureBox pictureBox1 = new PictureBox();
                    LoadGifAndFillForm();
                    Text = "Unvalid shape";
                    break;
            }

            label.Location = new Point(10, 50);
            this.Controls.Add(label);
        }

        //---------------------------------- Methods -----------------------------------
        private void LoadGifAndFillForm()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox.Image = Properties.Resources._404;

            this.Controls.Add(pictureBox);
            this.Controls.SetChildIndex(pictureBox, 0);
        }
        //------------------------------------------------------------------------------
    }
}
