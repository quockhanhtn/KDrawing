using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class MyCurve : MultiPointShape
    {
        #region Fields and Properties
        private static int index = 0;
        private static int indexBezier = 0;
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
        public MyCurve() { }
        public MyCurve(bool isBezier, float lineWeight, Color color, DashStyle dashStyle)
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
            MyCurve curve = new MyCurve(true, this.LineWeight, this.Color, this.DashStyle)
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
        #endregion
    }
}
