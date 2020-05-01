using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class cText : cFillableShape
    {
        private Font myFont;
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }

        public Font MyFont
        {
            get
            {
                return myFont;
            }
            set
            {
                myFont = value; 
                LineWeight = 1f;
            }
        }
        public string Text { get; set; }

        public cText(PointF begin)
        {
            this.Begin = begin;
        }

        public cText(PointF begin, string text, Font font, Color color, bool isFill)
        {
            this.Name = text;
            this.Begin = begin;
            this.Text = text;
            this.MyFont = font;
            this.Color = color;
            this.Fill = isFill;
        }

        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddString(Text, MyFont.FontFamily, (int)MyFont.Style, MyFont.Size, Begin, StringFormat.GenericDefault);

                var rec = Rectangle.Round(path.GetBounds());
                var xLoc = rec.Width + 2 * rec.Location.X - Begin.X;
                var yLoc = rec.Height + 2 * rec.Location.Y - Begin.Y;
                End = new PointF(xLoc, yLoc);

                return path;
            }
        }

        public override object Clone()
        {
            return new cText(this.Begin, this.Text, this.MyFont, this.Color, Fill)
            {
                Name = this.Name,
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden
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
        }

        public override void Rotate(int degree)
        {
        }

        public override void Scale(float percent)
        {
            float newFontSize = MyFont.Size * percent;
            MyFont = Utilities.ChangeFontSize(MyFont, newFontSize);
        }
    }
}
