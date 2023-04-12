using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Drawing_App.Shapes;
using Drawing_App.Shapes.Shapes;

namespace Drawing_App.Shapes.Shapes
{
    internal class LineShape : Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public LineShape(int xStart, int yStart, int xEnd, int yEnd, Color color, float penWidth)
            : base(xStart, yStart, xEnd, yEnd, color, penWidth)
        {
            StartPoint = new Point(xStart, yStart);
            EndPoint = new Point(xEnd, yEnd);
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, PenWidth))
            {
                graphics.DrawLine(pen, StartPoint, EndPoint);
            }
        }

        public override bool ContainsPoint(Point point)
        {
            const int proximityThreshold = 5;
            double distance = DistanceToSegment(point, StartPoint, EndPoint);
            return distance < proximityThreshold;
        }

        private double DistanceToSegment(Point point, Point p1, Point p2)
        {
            float dy = p2.Y - p1.Y;
            float dx = p2.X - p1.X;
            float lengthSquared = dx * dx + dy * dy;

            if (lengthSquared == 0)
            {
                return Distance(point, p1);
            }

            float t = ((point.X - p1.X) * dx + (point.Y - p1.Y) * dy) / lengthSquared;
            t = Math.Max(0, Math.Min(1, t));

            Point projection = new Point((int)(p1.X + t * dx), (int)(p1.Y + t * dy));
            return Distance(point, projection);
        }

        private double Distance(Point p1, Point p2)
        {
            float dy = p2.Y - p1.Y;
            float dx = p2.X - p1.X;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }
    }
}
