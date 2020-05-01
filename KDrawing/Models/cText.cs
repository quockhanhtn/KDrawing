using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDrawing.Models
{
    public class cText : cFillableShape
    {
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }

        public string Text { get; set; }
        public Font MyFont { get; set; }

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
                return path;
            }
        }
        public override object Clone()
        {
            return new cText(this.Begin, this.Text, this.MyFont, this.Color, Fill)
            {
                Name = this.Name
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
        }
    }
}
