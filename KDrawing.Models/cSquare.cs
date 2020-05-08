using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class cSquare : cRectangle
    {
        #region Fields
        private static int index = 0;
        #endregion

        #region Constructor
        public cSquare() : base() { }
        public cSquare(PointF begin, float lineWeight, Color color, DashStyle dashStyle) : base(begin, lineWeight, color, dashStyle)
        {
            Name = "Square " + (index++).ToString();
        }
        #endregion

        #region Properties
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
                    path.AddRectangle(new RectangleF(new PointF(Begin.X, End.Y - Width), new SizeF(Width, Width)));
                }
                else
                {
                    path.AddRectangle(new RectangleF(Begin, new SizeF(Width, Width)));
                }

                return path;
            }
        }
        #endregion

        #region Methods
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
        #endregion
    }
}
