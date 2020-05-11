using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;

namespace KDrawing.Models
{
    public class cText : cShape, Interfaces.IFillableShape
    {
        #region Fields
        private Font myFont;
        #endregion

        #region Properties
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }
        public bool IsFill { get; set; }
        public string Text { get; set; }
        [XmlIgnore()]
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

        [Browsable(false)]
        public string FontSerialize
        {
            get { return FontSerializationHelper.ToString(myFont); }
            set { myFont = FontSerializationHelper.FromString(value); }
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

        [XmlElement(Type = typeof(XmlColor))]
        public Color FillColor { get; set; }
        #endregion

        #region Constructor
        public cText() { }
        public cText(PointF begin, string text, Font font, Color color, float lineWeight, DashStyle dashStyle, bool isFill)
        {
            this.Begin = begin;
            this.Text = text;
            this.MyFont = font;
            this.Color = color;
            this.FillColor = Color.Transparent;
            this.IsFill = isFill;
        }
        #endregion

        #region Methods
        public static cText Default()
        {
            return new cText(
                new PointF(0, 0),
                "Example text",
                new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                Color.Black,
                1f,
                DashStyle.Solid,
                false
                )
            { FillColor = Color.Transparent };
        }

        public override object Clone()
        {
            return new cText(Begin, Text, MyFont, Color, LineWeight, DashStyle, IsFill)
            {
                Name = this.Name,
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                FillColor = this.FillColor
            };
        }

        public override void Draw(Graphics graphics)
        {
            using (GraphicsPath path = this.GraphicsPath)
            {
                using (Pen pen = new Pen(this.Color, LineWeight) { DashStyle = this.DashStyle })
                {
                    graphics.DrawPath(pen, path);
                }
                if (this.IsFill)
                {
                    using (Brush brush = new SolidBrush(this.FillColor))
                    {
                        graphics.FillPath(brush, path);
                    }
                }
            }
        }

        public override bool IsHit(PointF point)
        {
            bool result = false;
            using (GraphicsPath path = this.GraphicsPath)
            {
                if (!this.IsFill)
                {
                    using (Pen pen = new Pen(this.Color, this.LineWeight + 3))
                    {
                        result = path.IsOutlineVisible(point, pen);
                    }
                }
                else
                {
                    result = path.IsVisible(point);
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

        public override void Rotate(int degree) { }

        public override void Scale(float percent)
        {
            float newFontSize = MyFont.Size * percent;
            MyFont = Utilities.ChangeFontSize(MyFont, newFontSize);
        }

        /// <summary>
        /// Get Text, MyFont, Color, Fill property form source to this
        /// </summary>
        /// <param name="source"></param>
        public void GetProperty(cText source)
        {
            this.Text = source.Text;
            this.MyFont = source.MyFont;
            this.Color = source.Color;
            this.IsFill = source.IsFill;
            this.FillColor = source.FillColor;
            this.LineWeight = source.LineWeight;
            this.DashStyle = source.DashStyle;
        }
        #endregion
    }
}
