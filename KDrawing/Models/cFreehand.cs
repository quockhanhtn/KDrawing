using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class cFreehand : cShape
    {
        #region Fields
        private static int index = 0;
        #endregion

        #region Properties
        public List<PointF> Points { get; set; } = new List<PointF>();
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    path.AddLine(Points[i], Points[i + 1]);
                }
                return path;
            }
        }
        #endregion

        #region Constructor
        public cFreehand() { }
        public cFreehand(float lineWeight, Color color, DashStyle dashStyle)
        {
            this.Name = "Free hand " + (index++).ToString();
            this.LineWeight = lineWeight;
            this.Color = color;
            this.DashStyle = dashStyle;
            this.Points = new List<PointF>();
        }
        #endregion

        #region Methods
        public override object Clone()
        {
            cFreehand freehand = new cFreehand()
            {
                Name = this.Name,
                Begin = this.Begin,
                End = this.End,
                Color = this.Color,
                LineWeight = this.LineWeight,
                DashStyle = this.DashStyle,
                IsHidden = this.IsHidden,
                IsSelected = this.IsSelected,
            };
            Points.ForEach(point => freehand.Points.Add(point));
            return freehand;
        }

        public override void Draw(Graphics graphics)
        {
            using (GraphicsPath path = GraphicsPath)
            {
                using (Pen pen = new Pen(Color, LineWeight) { DashStyle = DashStyle })
                {
                    pen.StartCap = pen.EndCap = LineCap.Round;
                    graphics.DrawPath(pen, path);
                }
            }
        }

        public override bool IsHit(PointF point)
        {
            bool result = false;
            using (GraphicsPath path = GraphicsPath)
            {
                using (Pen pen = new Pen(Color, LineWeight + 3))
                {
                    result = path.IsOutlineVisible(point, pen);
                }
            }
            return result;
        }

        public override void Move(PointF distance)
        {
            this.Begin = new PointF(Begin.X + distance.X, Begin.Y + distance.Y);
            this.End = new PointF(End.X + distance.X, End.Y + distance.Y);
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new PointF(Points[i].X + distance.X, Points[i].Y + distance.Y);
            }
        }

        public override void Rotate(int degree)
        {
            PointF midPoint = new PointF((Begin.X + End.X) / 2, (Begin.Y + End.Y) / 2);
            Begin = Utilities.RotatePoint(Begin, midPoint, degree);
            End = Utilities.RotatePoint(End, midPoint, degree);
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = Utilities.RotatePoint(Points[i], midPoint, degree);
            }
        }

        public override void Scale(float percent)
        {
        }

        public void FindRegion()
        {
            float minX = float.MaxValue;
            float minY = float.MaxValue;
            float maxX = float.MinValue;
            float maxY = float.MinValue;

            this.Points.ForEach(p =>
            {
                if (minX > p.X)
                {
                    minX = p.X;
                }
                if (minY > p.Y)
                {
                    minY = p.Y;
                }
                if (maxX < p.X)
                {
                    maxX = p.X;
                }
                if (maxY < p.Y)
                {
                    maxY = p.Y;
                }
            });
            this.Begin = new PointF(minX, minY);
            this.End = new PointF(maxX, maxY);
        }
        #endregion
    }
}
