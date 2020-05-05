using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class cSquare : cRectangle
    {
        private static int index = 0;

        public cSquare() : base() { }
        public cSquare(PointF begin, float lineWeight, Color color, DashStyle dashStyle) : base(begin, lineWeight, color, dashStyle)
        {
            Name = "Square " + (index++).ToString();
        }
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();

                Width = ((Math.Abs(End.X - Begin.X)) + Math.Abs((End.Y - Begin.Y))) / 2;

                if (End.X < Begin.X && End.Y < Begin.Y)
                {
                    path.AddRectangle(new RectangleF(new PointF(Begin.X - Width, Begin.Y - Width), new SizeF(Width, Width)));
                }
                else if (Begin.X > End.X && Begin.Y < End.Y)
                {
                    path.AddRectangle(new RectangleF(new PointF(Begin.X - Width, Begin.Y), new SizeF(Width, Width)));
                }
                else if (Begin.X < End.X && Begin.Y > End.Y)
                {
                    path.AddRectangle(new RectangleF(new PointF(Begin.X, End.Y), new SizeF(Width, Width)));
                }
                else
                {
                    path.AddRectangle(new RectangleF(Begin, new SizeF(Width, Width)));
                }

                return path;
            }
        }

        public override void Draw(Graphics graphics)
        {
            using (GraphicsPath path = this.GraphicsPath)
            {
                if (!this.Fill)
                {
                    using (Pen pen = new Pen(this.Color, this.LineWeight) { DashStyle = this.DashStyle })
                    {
                        graphics.DrawPath(pen, path);
                    }
                }
                else
                {
                    using (Brush brush = new SolidBrush(this.Color))
                    {
                        graphics.FillPath(brush, path);
                    }
                }
            }
        }

        public override bool IsHit(PointF point)
        {
            bool res = false;
            using (GraphicsPath path = this.GraphicsPath)
            {
                if (!Fill)
                {
                    using (Pen pen = new Pen(this.Color, this.LineWeight + 3))
                    {
                        res = path.IsOutlineVisible(point, pen);
                    }
                }
                else
                {
                    res = path.IsVisible(point);
                }
            }
            return res;
        }

        public override void Move(PointF distance)
        {
            this.Begin = new PointF(Begin.X + distance.X, Begin.Y + distance.Y);
            this.End = new PointF(End.X + distance.X, End.Y + distance.Y);
        }

        public override object Clone()
        {
            return new cSquare(this.Begin, this.LineWeight, this.Color, this.DashStyle)
            {
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name,
                Width = this.Width
            };
        }
    }
}
