using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public abstract class cShape
    {
        public abstract PointF Begin { get; set; }
        public abstract PointF End { get; set; }
        public Color Color { get; set; }
        public float LineWeight { get; set; }
        public bool IsSelected { get; set; } = false;
        public bool IsHidden { get; set; } = false;
        public string Name { get; set; }
        public DashStyle DashStyle { get; set; } = DashStyle.Solid;
        protected abstract GraphicsPath GraphicsPath { get; }
        public abstract bool IsHit(PointF point);
        public abstract void Draw(Graphics graphics);
        public abstract void Move(PointF distance);
        public abstract object Clone();
        public abstract void Scale(float percent);
        public abstract void Rotate(int degree);
    }
}