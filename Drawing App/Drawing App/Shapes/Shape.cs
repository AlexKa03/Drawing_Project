using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_App.Shapes
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public float PenWidth { get; set; }
        public bool IsSelected { get; set; }

        protected Shape(int x, int y, int width, int height, Color color, float penWidth)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
            PenWidth = penWidth;
            IsSelected = false;
        }

        public abstract void Draw(Graphics graphics);
        public abstract bool ContainsPoint(Point point);
        public virtual void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
    }
}
