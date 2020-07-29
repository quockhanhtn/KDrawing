using KDrawing.Enums;
using KDrawing.Models.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class MyGroup : MyShape
    {
        #region Fields
        private static int index = 0;
        #endregion

        #region Properties
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }
        public List<MyShape> Shapes = new List<MyShape>();
        public int Count => Shapes.Count;
        public MyShape this[int index]
        {
            get => Shapes[index];
            set => Shapes[index] = value;
        }
        private GraphicsPath[] GraphicsPaths
        {
            get
            {
                GraphicsPath[] paths = new GraphicsPath[Shapes.Count];

                for (int i = 0; i < Shapes.Count; i++)
                {
                    GraphicsPath path = new GraphicsPath();
                    if (Shapes[i] is MyLine line)
                    {
                        path.AddLine(line.Begin, line.End);
                    }
                    else if (Shapes[i] is MyRectangle rect)
                    {
                        path.AddRectangle(new RectangleF(rect.Begin.X, rect.Begin.Y, rect.End.X - rect.Begin.X, rect.End.Y - rect.Begin.Y));
                    }
                    else if (Shapes[i] is MyEllipse ellipse)
                    {
                        if (ellipse is MyCircle circle)
                        {
                            float r = ((circle.End.X - circle.Begin.X) + (circle.End.Y - circle.Begin.Y)) / 2;
                            path.AddEllipse(new RectangleF(circle.Begin.X, circle.Begin.Y, r, r));
                        }
                        else
                        {
                            path.AddEllipse(new RectangleF(ellipse.Begin.X, ellipse.Begin.Y, ellipse.End.X - ellipse.Begin.X, ellipse.End.Y - ellipse.Begin.Y));
                        }
                    }
                    else if (Shapes[i] is MyCurve curve)
                    {
                        path.AddCurve(curve.Points.ToArray());
                    }
                    else if (Shapes[i] is MyPolygon polygon)
                    {
                        path.AddPolygon(polygon.Points.ToArray());
                    }
                    else if (Shapes[i] is MyFreehand freehand)
                    {
                        for (int j = 0; j < freehand.Points.Count - 1; j++)
                        {
                            path.AddLine(freehand.Points[j], freehand.Points[j + 1]);
                        }
                    }
                    else if (Shapes[i] is MyText text)
                    {
                        path.AddString(text.Text, text.MyFont.FontFamily, (int)text.MyFont.Style, text.MyFont.Size, text.Begin, StringFormat.GenericDefault);
                    }
                    else if (Shapes[i] is MyGroup group)
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

        ///[Obsolete("Phương thức này bị thừa, không được xài")]
        protected override GraphicsPath GraphicsPath => null;
        #endregion

        #region Constructor
        public MyGroup() { Name = "Group " + (index++).ToString(); }
        #endregion

        #region Methods
        public void Add(MyShape shape) { Shapes.Add(shape); }

        public override void Draw(Graphics graphics)
        {
            GraphicsPath[] paths = this.GraphicsPaths;
            for (int i = 0; i < paths.Length; i++)
            {
                using (GraphicsPath path = paths[i])
                {
                    if (Shapes[i] is IFillableShape fillableShape)
                    {
                        if (fillableShape.IsFill)
                        {
                            using (Brush brush = new SolidBrush(fillableShape.FillColor))
                            {
                                graphics.FillPath(brush, path);
                            }
                            using (Pen pen = new Pen(Shapes[i].Color, Shapes[i].LineWeight) { DashStyle = Shapes[i].DashStyle })
                            {
                                graphics.DrawPath(pen, path);
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(Shapes[i].Color, Shapes[i].LineWeight) { DashStyle = Shapes[i].DashStyle })
                            {
                                graphics.DrawPath(pen, path);
                            }
                        }
                    }
                    else if (Shapes[i] is MyGroup group)
                    {
                        group.Draw(graphics);
                    }
                    else
                    {
                        using (Pen pen = new Pen(Shapes[i].Color, Shapes[i].LineWeight) { DashStyle = Shapes[i].DashStyle })
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
                    if (Shapes[i] is IFillableShape fillableShape)
                    {
                        if (fillableShape.IsFill)
                        {
                            using (Brush brush = new SolidBrush(Shapes[i].Color))
                            {
                                if (path.IsVisible(point)) { return true; }
                            }
                        }
                        else
                        {
                            using (Pen pen = new Pen(Shapes[i].Color, Shapes[i].LineWeight + 3))
                            {
                                if (path.IsOutlineVisible(point, pen)) { return true; }
                            }
                        }
                    }
                    else if (!(Shapes[i] is MyGroup))
                    {
                        using (Pen pen = new Pen(Shapes[i].Color, Shapes[i].LineWeight + 3))
                        {
                            if (path.IsOutlineVisible(point, pen)) { return true; }
                        }
                    }
                    else if (Shapes[i] is MyGroup group) { return group.IsHit(point); }
                }
            }

            return false;
        }

        public override void Move(PointF distance)
        {
            for (int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Move(distance);
            }
            Begin = new PointF(Begin.X + distance.X, Begin.Y + distance.Y);
            End = new PointF(End.X + distance.X, End.Y + distance.Y);
        }

        public override void Move(Direction direction, int movingOffset)
        {
            for (int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Move(direction, movingOffset);
            }
            Begin = Utilities.MovePoint(Begin, direction, movingOffset);
            End = Utilities.MovePoint(End, direction, movingOffset);
        }

        public override object Clone()
        {
            MyGroup group = new MyGroup
            {
                Begin = this.Begin,
                End = this.End,
                IsSelected = this.IsSelected,
                IsHidden = this.IsHidden,
                Name = this.Name,
                Color = Color.FromName(Color.Name),
                LineWeight = LineWeight
            };
            for (int i = 0; i < Shapes.Count; i++)
            {
                group.Shapes.Add(Shapes[i].Clone() as MyShape);
            }
            return group;
        }

        public override void Rotate(int degree)
        {
            foreach (MyShape shape in this.Shapes) { shape.Rotate(degree); }
        }

        public override void Scale(float percent)
        {
            foreach (MyShape shape in this.Shapes) { shape.Scale(percent); }
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
                MyShape shape = this[i];

                if (shape is MyCurve curve)
                {
                    curve.FindRegion();
                }
                else if (shape is MyPolygon polygon)
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
        #endregion
    }
}
