using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class cLine : cShape
    {
        #region Fields
        private static int index = 0;
        #endregion

        #region Properties
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddLine(Begin, End);
                return path;
            }
        }
        #endregion

        #region Constructor
        public cLine() { }
        public cLine(PointF begin, float lineWeight, Color color, DashStyle dashStyle)
        {
            this.Name = "Line " + (index++).ToString();
            this.Begin = begin;
            this.LineWeight = lineWeight;
            this.Color = color;
            this.DashStyle = dashStyle;
        }
        #endregion

        #region Methods
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
            bool result = false;
            using (GraphicsPath path = this.GraphicsPath)
            {
                using (Pen pen = new Pen(this.Color, this.LineWeight + 3))
                {
                    result = path.IsOutlineVisible(point, pen);
                }
            }
            return result;
        }

        public override void Move(PointF distance)
        {
            Begin = new PointF(Begin.X + distance.X, Begin.Y + distance.Y);
            End = new PointF(End.X + distance.X, End.Y + distance.Y);
        }

        public override void Move(KDrawing.Enums.Direction direction, int movingOffset)
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
