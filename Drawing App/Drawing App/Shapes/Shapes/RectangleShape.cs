using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drawing_App.Shapes;
using Drawing_App.Shapes.Shapes;

namespace Drawing_App.Shapes.Shapes
{
    internal class RectangleShape : Shape
    {
        public RectangleShape(int x, int y, int width, int height, Color color, float penWidth)
            : base(x, y, width, height, color, penWidth)
        {
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, PenWidth))
            {
                graphics.DrawRectangle(pen, X, Y, Width, Height);
            }
        }

        public override bool ContainsPoint(Point point)
        {
            Rectangle rectangle = new Rectangle(X, Y, Width, Height);
            return rectangle.Contains(point);
        }
    }
}
