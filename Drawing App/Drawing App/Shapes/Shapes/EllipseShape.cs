using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing_App.Shapes.Shapes
{
    internal class EllipseShape : Shape
    {
        public EllipseShape(int x, int y, int width, int height, Color color, float penWidth)
            : base(x, y, width, height, color, penWidth)
        {
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, PenWidth))
            {
                graphics.DrawEllipse(pen, X, Y, Width, Height);
            }
        }

        public override bool ContainsPoint(Point point)
        {
            double a = Width / 2.0;
            double b = Height / 2.0;
            double centerX = X + a;
            double centerY = Y + b;

            return (((point.X - centerX) * (point.X - centerX)) / (a * a)) + (((point.Y - centerY) * (point.Y - centerY)) / (b * b)) <= 1;
        }
    }
}
