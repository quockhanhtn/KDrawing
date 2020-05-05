using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDrawing.Models
{
    public class cFreehand : cShape
    {
        private static int index = 0;
        public List<PointF> Points { get; set; } = new List<PointF>();
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }

        public cFreehand() { }
        public cFreehand(float lineWeight, Color color, DashStyle dashStyle)
        {
            this.Name = "Free hand " + (index++).ToString();
            this.LineWeight = lineWeight;
            this.Color = color;
            this.DashStyle = dashStyle;
            this.Points = new List<PointF>();
        }
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

        public override object Clone()
        {
            return null;
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
            bool res = false;
            using (GraphicsPath path = GraphicsPath)
            {
                using (Pen pen = new Pen(Color, LineWeight + 3))
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
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new PointF(Points[i].X + distance.X, Points[i].Y + distance.Y);
            }
        }

        public override void Scale(float percent)
        {
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
    }
}
