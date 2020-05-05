using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KDrawing.Models
{
    public class cEllipse : cFillableShape
    {
        private static int index = 0;
        PointF begin;
        PointF end;
        public override PointF Begin
        {
            get => begin;
            set
            {
                begin = value;
                TopRight = new PointF(end.X, begin.Y);
                BottomLeft = new PointF(begin.X, end.Y);
            }
        }
        public override PointF End
        {
            get => end;
            set
            {
                end = value;
                TopRight = new PointF(end.X, begin.Y);
                BottomLeft = new PointF(begin.X, end.Y);
            }
        }
        public PointF TopRight { get; set; }
        public PointF BottomLeft { get; set; }
        public bool IsCircle { get; set; }
        public float Diameter { get; set; }

        public cEllipse() { }

        public cEllipse(PointF begin, float lineWeight, Color color, DashStyle dashStyle)
        {
            this.Name = "Ellipse " + (index++).ToString();
            this.Begin = begin;
            this.LineWeight = lineWeight;
            this.Color = color;
            this.DashStyle = dashStyle;
            this.IsCircle = false;
            this.Diameter = 0f;
        }

        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (IsCircle)
                {
                    Diameter = ((End.X - Begin.X) + (End.Y - Begin.Y)) / 2;
                    path.AddEllipse(new RectangleF(Begin.X, Begin.Y, Diameter, Diameter));

                    End = new PointF(Begin.X + Diameter, Begin.Y + Diameter);
                }
                else
                {
                    path.AddEllipse(new RectangleF(Begin.X, Begin.Y, End.X - Begin.X, End.Y - Begin.Y));
                }
                return path;
            }
        }

        public override object Clone()
        {
            return new cEllipse(this.Begin, this.LineWeight, this.Color, this.DashStyle)
            {
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name,
                IsCircle = this.IsCircle,
                Diameter =this.Diameter
            };
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
