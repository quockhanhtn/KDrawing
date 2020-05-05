﻿using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class cPolygon : cMultiPointShape, Interfaces.IFillableShape
    {
        #region Fields and Properties
        private static int index = 0;
        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (Points.Count < 3)
                {
                    path.AddLine(Points[0], Points[1]);
                }
                else
                {
                    path.AddPolygon(Points.ToArray());
                }

                return path;
            }
        }
        public bool IsFill { get; set; }
        #endregion

        #region Constructor
        public cPolygon() { }
        public cPolygon(float lineWeight, Color color, DashStyle dashStyle)
        {
            this.Name = "Polygon " + (index++).ToString();
            this.LineWeight = lineWeight;
            this.Color = color;
            this.DashStyle = dashStyle;
        }
        #endregion

        #region Methods
        public override object Clone()
        {
            cPolygon polygon = new cPolygon(this.LineWeight, this.Color, this.DashStyle)
            {
                Begin = this.Begin,
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name,
            };
            Points.ForEach(point => polygon.Points.Add(point));
            return polygon;
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
                        if (Points.Count < 3)
                        {
                            using (Pen pen = new Pen(this.Color, this.LineWeight))
                            {
                                graphics.DrawPath(pen, path);
                            }
                        }
                        else
                        {
                            graphics.FillPath(brush, path);
                        }
                    }
                }
            }
        }

        public override bool IsHit(PointF point)
        {
            bool result = false;
            using (GraphicsPath path = this.GraphicsPath)
            {
                if (!IsFill)
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
        #endregion
    }
}
