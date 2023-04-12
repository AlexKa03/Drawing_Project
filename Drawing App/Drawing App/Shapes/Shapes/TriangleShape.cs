using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Drawing_App.Shapes;
using Drawing_App.Shapes.Shapes;

namespace Drawing_App.Shapes.Shapes
{
    internal class TriangleShape : Shape
    {
        public Point Center { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public TriangleShape(int x, int y, int width, int height, Color borderColor, float borderWidth)
            : base(x, y, width, height, borderColor, borderWidth)
        {
            Center = new Point(x + width / 2, y + height / 2);
            Width = width;
            Height = height;
        }

        private Point[] CalculateVertices()
        {
            Point vertex1 = new Point(Center.X, Center.Y - Height / 2);
            Point vertex2 = new Point(Center.X - Width / 2, Center.Y + Height / 2);
            Point vertex3 = new Point(Center.X + Width / 2, Center.Y + Height / 2);

            return new[] { vertex1, vertex2, vertex3 };
        }

        public override void Draw(Graphics graphics)
        {
            if (graphics == null)
            {
                throw new ArgumentNullException(nameof(graphics));
            }

            Point[] vertices = CalculateVertices();

            using (var pen = new Pen(Color, PenWidth))
            {
                graphics.DrawLine(pen, vertices[0], vertices[1]);
                graphics.DrawLine(pen, vertices[1], vertices[2]);
                graphics.DrawLine(pen, vertices[2], vertices[0]);
            }
        }

        public override void Move(int deltaX, int deltaY)
        {
            Center = new Point(Center.X + deltaX, Center.Y + deltaY);
        }

        public override bool ContainsPoint(Point point)
        {
            // This is a basic implementation that checks if the point is within the bounding rectangle.
            // A more precise method would check if the point is inside the triangle itself.
            return point.X >= Center.X - Width / 2 && point.X <= Center.X + Width / 2 &&
                   point.Y >= Center.Y - Height / 2 && point.Y <= Center.Y + Height / 2;
        }
    }
}
