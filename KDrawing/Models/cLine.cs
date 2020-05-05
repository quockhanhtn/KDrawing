using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace KDrawing.Models
{
    public class cLine : cShape
    {
        private static int index = 0;
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }
        public cLine() { }
        public cLine(PointF begin, float lineWeight, Color color, DashStyle dashStyle)
        {
            this.Name = "Line " + (index++).ToString();
            this.Begin = begin;
            this.LineWeight = lineWeight;
            this.Color = color;
            this.DashStyle = dashStyle;
        }

        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddLine(Begin, End);
                return path;
            }
        }

        public override object Clone()
        {
            return new cLine(this.Begin, this.LineWeight, this.Color, this.DashStyle)
            {
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name
            };
        }

        public override void Draw(Graphics graphics)
        {
            using (GraphicsPath path = this.GraphicsPath)
            {
                using (Pen pen = new Pen(this.Color, this.LineWeight) { DashStyle = this.DashStyle })
                {
                    graphics.DrawPath(pen, path);
                }
            }
        }

        public override bool IsHit(PointF point)
        {
            bool res = false;
            using (GraphicsPath path = this.GraphicsPath)
            {
                using (Pen pen = new Pen(this.Color, this.LineWeight + 3))
                {
                    res = path.IsOutlineVisible(point, pen);
                }
            }
            return res;
        }

        public override void Move(PointF distance)
        {
            this.Begin = new PointF(Begin.X + distance.X, Begin.Y + distance.Y);
            this.End = new PointF(End.X + distance.X, End.Y + distance.Y);
        }

        public override void Scale(float percent)
        {
            float dX = End.X - Begin.X;
            float dY = End.Y - Begin.Y;

            dX *= percent;
            dY *= percent;

            End = new PointF(Begin.X + dX, Begin.Y + dY);
        }

        public override void Rotate(int degree)
        {
            PointF midPoint = new PointF((Begin.X + End.X) / 2, (Begin.Y + End.Y) / 2);
            Begin = Utilities.RotatePoint(Begin, midPoint, degree);
            End = Utilities.RotatePoint(End, midPoint, degree);
        }
    }
}
