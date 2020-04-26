using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDrawing.Models
{
    public class cGroup : cShape, IEnumerable
    {
        private static int index = 0;
        private List<cShape> listShapes = new List<cShape>();

        public int Count => listShapes.Count;
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }
        public cGroup()
        {
            Name = "Group " + (index++).ToString();
        }

        public cShape this[int index]
        {
            get => listShapes[index];
            set => listShapes[index] = value;
        }

        public void Add(cShape shape)
        {
            listShapes.Add(shape);
        }

        private GraphicsPath[] GraphicsPaths
        {
            get
            {
                GraphicsPath[] paths = new GraphicsPath[listShapes.Count];

                for (int i = 0; i < listShapes.Count; i++)
                {
                    GraphicsPath path = new GraphicsPath();
                    if (listShapes[i] is cLine line)
                    {
                        path.AddLine(line.Begin, line.End);
                    }
                    else if (listShapes[i] is cRectangle rect)
                    {
                        if (rect is cSquare square)
                        {
                            float a = ((square.End.X - square.Begin.X) + (square.End.Y - square.Begin.Y)) / 2;
                            path.AddRectangle(new RectangleF(square.Begin.X, square.Begin.Y, a, a));
                        }
                        else
                        {
                            path.AddRectangle(new RectangleF(rect.Begin.X, rect.Begin.Y, rect.End.X - rect.Begin.X, rect.End.Y - rect.Begin.Y));
                        }
                    }
                    else if (listShapes[i] is cEllipse ellipse)
                    {
                        if (ellipse is cCircle circle)
                        {
                            float r = ((circle.End.X - circle.Begin.X) + (circle.End.Y - circle.Begin.Y)) / 2;
                            path.AddEllipse(new RectangleF(circle.Begin.X, circle.Begin.Y, r, r));
                        }
                        else
                        {
                            path.AddEllipse(new RectangleF(ellipse.Begin.X, ellipse.Begin.Y, ellipse.End.X - ellipse.Begin.X, ellipse.End.Y - ellipse.Begin.Y));
                        }
                    }
                    else if (listShapes[i] is cCurve curve)
                    {
                        path.AddCurve(curve.Points.ToArray());
                    }
                    else if (listShapes[i] is cPolygon polygon)
                    {
                        path.AddPolygon(polygon.Points.ToArray());
                    }
                    else if (listShapes[i] is cGroup group)
                    {
                        for (int j = 0; j < group.GraphicsPaths.Length; j++)
                        {
                            path.AddPath(group.GraphicsPaths[j], false);
                        }
                    }
                    paths[i] = path;
                }

                return paths;
            }
        }

        public override void Draw(Graphics graphics)
        {
            GraphicsPath[] paths = this.GraphicsPaths;
            for (int i = 0; i < paths.Length; i++)
            {
                using (GraphicsPath path = paths[i])
                {
                    if (listShapes[i] is cFillableShape shape)
                    {
                        if (shape.Fill)
                        {
                            using (Brush brush = new SolidBrush(shape.Color))
                            {
                                graphics.FillPath(brush, path);
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(shape.Color, shape.LineWeight) { DashStyle = shape.DashStyle })
                            {
                                graphics.DrawPath(pen, path);
                            }
                        }
                    }
                    else if (listShapes[i] is cGroup group)
                    {
                        group.Draw(graphics);
                    }
                    else
                    {
                        using (Pen pen = new Pen(listShapes[i].Color, listShapes[i].LineWeight) { DashStyle = listShapes[i].DashStyle })
                        {
                            graphics.DrawPath(pen, path);
                        }
                    }
                }
            }
        }

        public override bool IsHit(PointF point)
        {
            GraphicsPath[] paths = this.GraphicsPaths;
            for (int i = 0; i < paths.Length; i++)
            {
                using (GraphicsPath path = paths[i])
                {
                    if (listShapes[i] is cFillableShape shape)
                    {
                        if (shape.Fill)
                        {
                            using (Brush brush = new SolidBrush(shape.Color))
                            {
                                if (path.IsVisible(point)) { return true; }
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(shape.Color, shape.LineWeight + 3))
                            {
                                if (path.IsOutlineVisible(point, pen)) { return true; }
                            }
                        }
                    }
                    else if (!(listShapes[i] is cGroup))
                    {
                        using (Pen pen = new Pen(listShapes[i].Color, listShapes[i].LineWeight + 3))
                        {
                            if (path.IsOutlineVisible(point, pen)) { return true; }
                        }
                    }
                    else if (listShapes[i] is cGroup group) { return group.IsHit(point); }
                }
            }

            return false;
        }

        public override void Move(PointF distance)
        {
            for (int i = 0; i < listShapes.Count; i++)
            {
                if (listShapes[i] is cCurve curve)
                {
                    curve.Begin = new PointF(curve.Begin.X + distance.X, curve.Begin.Y + distance.Y);
                    curve.End = new PointF(curve.End.X + distance.X, curve.End.Y + distance.Y);

                    for (int j = 0; j < curve.Points.Count; j++)
                    {
                        curve.Points[j] = new PointF(curve.Points[j].X + distance.X, curve.Points[j].Y + distance.Y);
                    }
                }
                else if (listShapes[i] is cPolygon polygon)
                {
                    polygon.Begin = new PointF(polygon.Begin.X + distance.X, polygon.Begin.Y + distance.Y);
                    polygon.End = new PointF(polygon.End.X + distance.X, polygon.End.Y + distance.Y);

                    for (int j = 0; j < polygon.Points.Count; j++)
                    {
                        polygon.Points[j] = new PointF(polygon.Points[j].X + distance.X, polygon.Points[j].Y + distance.Y);
                    }
                }
                else if (listShapes[i] is cGroup group)
                {
                    group.Move(distance);
                }
                else
                {
                    listShapes[i].Begin = new PointF(listShapes[i].Begin.X + distance.X, listShapes[i].Begin.Y + distance.Y);
                    listShapes[i].End = new PointF(listShapes[i].End.X + distance.X, listShapes[i].End.Y + distance.Y);
                }
            }
            Begin = new PointF(Begin.X + distance.X, Begin.Y + distance.Y);
            End = new PointF(End.X + distance.X, End.Y + distance.Y);
        }

        public override object Clone()
        {
            cGroup group = new cGroup
            {
                Begin = this.Begin,
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name,
                Color = Color.FromName(Color.Name),
                LineWeight = LineWeight
            };
            for (int i = 0; i < listShapes.Count; i++)
            {
                group.listShapes.Add(listShapes[i].Clone() as cShape);
            }
            return group;
        }

        public override void Scale(float percent)
        {
            foreach (cShape shape in this.listShapes)
            {
                shape.Scale(percent);
            }
        }

        public override void Rotate(int degree)
        {
            foreach (cShape shape in this.listShapes)
            {
                shape.Rotate(degree);
            }
        }

        /// <summary>
        /// Tìm khung chứa group
        /// </summary>
        public void FindRegion()
        {
            float minX = float.MaxValue;
            float minY = float.MaxValue;
            float maxX = float.MinValue;
            float maxY = float.MinValue;

            for (int i = 0; i < this.Count; i++)
            {
                cShape shape = this[i];

                if (shape is cCurve curve)
                {
                    curve.FindRegion();
                }
                else if (shape is cPolygon polygon)
                {
                    polygon.FindRegion();
                }

                if (shape.Begin.X < minX)
                {
                    minX = shape.Begin.X;
                }
                if (shape.End.X < minX)
                {
                    minX = shape.End.X;
                }

                if (shape.Begin.Y < minY)
                {
                    minY = shape.Begin.Y;
                }
                if (shape.End.Y < minY)
                {
                    minY = shape.End.Y;
                }

                if (shape.Begin.X > maxX)
                {
                    maxX = shape.Begin.X;
                }
                if (shape.End.X > maxX)
                {
                    maxX = shape.End.X;
                }

                if (shape.Begin.Y > maxY)
                {
                    maxY = shape.Begin.Y;
                }
                if (shape.End.Y > maxY)
                {
                    maxY = shape.End.Y;
                }
            }

            this.Begin = new PointF(minX, minY);
            this.End = new PointF(maxX, maxY);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listShapes.GetEnumerator();
        }

        ///[Obsolete("Phương thức này bị thừa, không được xài")]
        protected override GraphicsPath GraphicsPath => null;
    }
}
