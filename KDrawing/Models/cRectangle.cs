using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class cRectangle : cFillableShape
    {
        private static int index = 0;
        PointF begin;
        PointF end;
        public override PointF Begin
        {
            get => begin;
            set
            {
                begin = value;
                TopRight = new PointF(end.X, begin.Y);
                BottomLeft = new PointF(begin.X, end.Y);
            }
        }
        public override PointF End
        {
            get => end;
            set
            {
                end = value;
                TopRight = new PointF(end.X, begin.Y);
                BottomLeft = new PointF(begin.X, end.Y);
            }
        }
        public PointF TopRight { get; set; }
        public PointF BottomLeft { get; set; }
        public bool IsSquare { get; set; }
        public float Width { get; set; }
        public cRectangle(PointF begin, float lineWeight, Color color, DashStyle dashStyle)
        {
            this.Name = "Rectangle " + (index++).ToString();
            this.Begin = begin;
            this.LineWeight = lineWeight;
            this.Color = color;
            this.DashStyle = dashStyle;
            this.IsSquare = false;
            this.Width = 0f;
        }

        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (IsSquare)
                {
                    Width = ((Math.Abs(End.X - Begin.X)) + Math.Abs((End.Y - Begin.Y))) / 2;

                    if (End.X < Begin.X && End.Y < Begin.Y)
                    {
                        path.AddRectangle(new RectangleF(new PointF(Begin.X - Width, Begin.Y - Width), new SizeF(Width, Width)));
                        End = new PointF(Begin.X - Width, Begin.Y - Width);
                    }
                    else if (Begin.X > End.X && Begin.Y < End.Y)
                    {
                        path.AddRectangle(new RectangleF(new PointF(Begin.X - Width, Begin.Y), new SizeF(Width, Width)));
                        End = new PointF(Begin.X - Width, Begin.Y + Width);
                    }
                    else if (Begin.X < End.X && Begin.Y > End.Y)
                    {
                        path.AddRectangle(new RectangleF(new PointF(Begin.X, End.Y), new SizeF(Width, Width)));
                        End = new PointF(Begin.X + Width, Begin.Y - Width);
                    }
                    else
                    {
                        path.AddRectangle(new RectangleF(Begin, new SizeF(Width, Width)));
                        End = new PointF(Begin.X + Width, Begin.Y + Width);
                    }
                }
                else
                {
                    PointF[] pointFs = new PointF[] { Begin, TopRight, End, BottomLeft };

                    if (End.X < Begin.X && End.Y < Begin.Y)
                    {

                        path.AddPolygon(pointFs);
                        //path.AddRectangle(new RectangleF(End, new SizeF(Begin.X - End.X, Begin.Y - End.Y)));
                    }
                    else if (Begin.X > End.X && Begin.Y < End.Y)
                    {
                        path.AddPolygon(pointFs);
                        //path.AddRectangle(new RectangleF(new PointF(End.X, Begin.Y), new SizeF(Begin.X - End.X, End.Y - Begin.Y)));
                    }
                    else if (Begin.X < End.X && Begin.Y > End.Y)
                    {
                        path.AddPolygon(pointFs);
                        //path.AddRectangle(new RectangleF(new PointF(Begin.X, End.Y), new SizeF(End.X - Begin.X, Begin.Y - End.Y)));
                    }
                    else
                    {
                        path.AddPolygon(pointFs);
                        //path.AddRectangle(new RectangleF(Begin, new SizeF(End.X - Begin.X, End.Y - Begin.Y)));
                    }
                }

                return path;
            }
        }

        public override object Clone()
        {
            return new cRectangle(this.Begin,this.LineWeight,this.Color,this.DashStyle)
            {
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name,
                IsSquare = this.IsSquare,
                Width = this.Width
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
            this.End = new PointF(End.X + distance.X, End.Y + distance.Y);
        }

        public override void Scale(float percent)
        {
            float dX = End.X - Begin.X;
            float dY = End.Y - Begin.Y;

            dX *= percent;
            dY *= percent;

            End = new PointF(Begin.X + dX, Begin.Y + dY);
        }

        public override void Rotate(int degree)
        {
            PointF midPoint = new PointF((Begin.X + End.X) / 2, (Begin.Y + End.Y) / 2);
            begin = Utilities.RotatePoint(begin, midPoint, degree);
            end = Utilities.RotatePoint(end, midPoint, degree);
            TopRight = Utilities.RotatePoint(TopRight, midPoint, degree);
            BottomLeft = Utilities.RotatePoint(BottomLeft, midPoint, degree);
        }
    }
}
