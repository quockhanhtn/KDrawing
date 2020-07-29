using KDrawing.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.Models
{
    public class MultiPointShape : MyShape
    {
        public List<PointF> Points { get; set; } = new List<PointF>();
        public override PointF Begin { get; set; }
        public override PointF End { get; set; }

        protected MultiPointShape() { }

        protected override GraphicsPath GraphicsPath => throw new NotImplementedException();

        public override object Clone() { throw new NotImplementedException(); }

        public override void Draw(Graphics graphics) { throw new NotImplementedException(); }

        public override bool IsHit(PointF point) { throw new NotImplementedException(); }

        public override void Move(PointF distance)
        {
            Begin = new PointF(Begin.X + distance.X, Begin.Y + distance.Y);
            End = new PointF(End.X + distance.X, End.Y + distance.Y);
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new PointF(Points[i].X + distance.X, Points[i].Y + distance.Y);
            }
        }

        public override void Move(Direction direction, int movingOffset)
        {
            Begin = Utilities.MovePoint(Begin, direction, movingOffset);
            End = Utilities.MovePoint(End, direction, movingOffset);
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = Utilities.MovePoint(Points[i], direction, movingOffset);
            }
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
            this.FindRegion();
        }

        public override void Scale(float percent) 
        {
            float dX = (End.X - Begin.X) * percent;
            float dY = (End.Y - Begin.Y) * percent;

            End = new PointF(Begin.X + dX, Begin.Y + dY);

            for (int i = 0; i < Points.Count; i++)
            {
                float _dX = (Points[i].X - Begin.X) * percent;
                float _dY = (Points[i].Y - Begin.Y) * percent;

                Points[i] = new PointF(Begin.X + _dX, Begin.Y + _dY);
            }
            this.FindRegion();
        }

        public void FindRegion()
        {
            float minX = float.MaxValue;
            float minY = float.MaxValue;
            float maxX = float.MinValue;
            float maxY = float.MinValue;

            this.Points.ForEach(p =>
            {
                if (minX > p.X) { minX = p.X; }
                if (minY > p.Y) { minY = p.Y; }
                if (maxX < p.X) { maxX = p.X; }
                if (maxY < p.Y) { maxY = p.Y; }
            });
            Begin = new PointF(minX, minY);
            End = new PointF(maxX, maxY);
        }
    }
}
