using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class MyCircle : MyEllipse
    {
        #region Fields
        private static int index = 0;
        #endregion

        #region Constructor
        public MyCircle() : base() { }
        public MyCircle(PointF begin, float lineWeight, Color color, DashStyle dashStyle) : base(begin, lineWeight, color, dashStyle)
        {
            this.Name = "Circle " + (index++).ToString();
        }
        #endregion

        #region Properties
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();

                Diameter = ((End.X - Begin.X) + (End.Y - Begin.Y)) / 2;

                path.AddEllipse(new RectangleF(Begin.X, Begin.Y, Diameter, Diameter));

                return path;
            }
        }
        #endregion

        #region Methods
        public override object Clone()
        {
            return new MyCircle(this.Begin, this.LineWeight, this.Color, this.DashStyle)
            {
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name,
                Diameter = this.Diameter
            };
        }

        public override void Draw(Graphics graphics)
        {
            using (GraphicsPath path = this.GraphicsPath)
            {
                if (!this.IsFill)
                {
                    using (Pen pen = new Pen(this.Color, this.LineWeight) { DashStyle = this.DashStyle })
                    {
                        graphics.DrawPath(pen, path);
                    }
                }
                else
                {
                    using (Brush brush = new SolidBrush(Color))
                    {
                        graphics.FillPath(brush, path);
                    }
                }
            }
        }
        #endregion
    }
}
