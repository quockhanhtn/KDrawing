using KDrawing.Enums;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class MyEllipse : MyShape, Interfaces.IFillableShape
    {
        #region Fields
        private static int index = 0;
        PointF begin;
        PointF end;
        #endregion

        #region Properties
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
        public bool IsFill { get; set; }
        [System.Xml.Serialization.XmlElement(Type = typeof(XmlColor))]
        public Color FillColor { get; set; }
        #endregion

        #region Constructor
        public MyEllipse() { }
        public MyEllipse(PointF begin, float lineWeight, Color color,DashStyle dashStyle)
        {
            this.Name = "Ellipse " + (index++).ToString();
            this.Begin = begin;
            this.LineWeight = lineWeight;
            this.Color = color;
            this.FillColor = Color.Transparent;
            this.DashStyle = dashStyle;
            this.IsCircle = false;
            this.Diameter = 0f;
        }
        #endregion

        #region Methods
        public override object Clone()
        {
            return new MyEllipse(this.Begin, this.LineWeight, this.Color, this.DashStyle)
            {
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name,
                IsCircle = this.IsCircle,
                Diameter = this.Diameter,
                FillColor = this.FillColor
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
                if (this.IsFill)
                {
                    using (Brush brush = new SolidBrush(this.FillColor))
                    {
                        graphics.FillPath(brush, path);
                    }
                }
            }
        }

        public override bool IsHit(PointF point)
        {
            bool result = false;
            using (GraphicsPath path = this.GraphicsPath)
            {
                if (!IsFill)
                {
                    using (Pen pen = new Pen(this.Color, this.LineWeight + 3))
                    {
                        result = path.IsOutlineVisible(point, pen);
                    }
                }
                else
                {
                    result = path.IsVisible(point);
                }
            }
            return result;
        }

        public override void Move(PointF distance)
        {
            Begin = new PointF(Begin.X + distance.X, Begin.Y + distance.Y);
            End = new PointF(End.X + distance.X, End.Y + distance.Y);
        }

        public override void Move(Direction direction, int movingOffset)
        {
            Begin = Utilities.MovePoint(Begin, direction, movingOffset);
            End = Utilities.MovePoint(End, direction, movingOffset);
        }

        public override void Rotate(int degree)
        {
            PointF midPoint = new PointF((Begin.X + End.X) / 2, (Begin.Y + End.Y) / 2);
            Begin = Utilities.RotatePoint(Begin, midPoint, degree);
            End = Utilities.RotatePoint(End, midPoint, degree);
        }

        public override void Scale(float percent)
        {
            float dX = (End.X - Begin.X) * percent;
            float dY = (End.Y - Begin.Y) * percent;
            End = new PointF(Begin.X + dX, Begin.Y + dY);
        }
        #endregion
    }
}
