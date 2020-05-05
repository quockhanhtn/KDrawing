using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class cCurve : cShape
    {
        #region Fields
        private static int index = 0;
        private static int indexBezier = 0;
        #endregion

        #region Properties
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }
        public List<PointF> Points { get; set; } = new List<PointF>();
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                if (Points.Count < 2) { return null; }
                GraphicsPath path = new GraphicsPath();
                path.AddCurve(Points.ToArray());
                return path;
            }
        }
        #endregion

        #region Constructor
        public cCurve() { }
        public cCurve(bool isBezier, float lineWeight, Color color, DashStyle dashStyle)
        {
            this.Name = isBezier ? "Bezier " + (indexBezier++).ToString() : "Curve " + (index++).ToString();
            this.LineWeight = lineWeight;
            this.Color = color;
            this.DashStyle = dashStyle;
        }
        #endregion

        #region Methods
        public override object Clone()
        {
            cCurve curve = new cCurve(true, this.LineWeight, this.Color, this.DashStyle)
            {
                Begin = this.Begin,
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name,
            };
            Points.ForEach(point => curve.Points.Add(point));
            return curve;
        }

        public override void Draw(Graphics graphics)
        {
            if (GraphicsPath == null) { return; }
            using (GraphicsPath path = GraphicsPath)
            {
                using (Pen pen = new Pen(Color, LineWeight) { DashStyle = DashStyle })
                {
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
            Begin = new PointF(Begin.X + distance.X, Begin.Y + distance.Y);
            End = new PointF(End.X + distance.X, End.Y + distance.Y);
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

        /// <summary>
        /// Tìm khung chứa đường cong
        /// </summary>
        public void FindRegion()
        {
            float minX = float.MaxValue;
            float minY = float.MaxValue;
            float maxX = float.MinValue;
            float maxY = float.MinValue;

            this.Points.ForEach(p =>
            {
                if (minX > p.X) { minX = p.X; }
                if (minY > p.Y) { minY = p.Y; }
                if (maxX < p.X) { maxX = p.X; }
                if (maxY < p.Y) { maxY = p.Y; }
            });
            this.Begin = new PointF(minX, minY);
            this.End = new PointF(maxX, maxY);
        }
        #endregion
    }
}
