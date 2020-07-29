using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class MyFreehand : MultiPointShape
    {
        #region Fields and Properties
        private static int index = 0;
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
        public MyFreehand() { }
        public MyFreehand(float lineWeight, Color color, DashStyle dashStyle)
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
            MyFreehand freehand = new MyFreehand()
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
        #endregion
    }
}
