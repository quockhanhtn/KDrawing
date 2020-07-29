using System.Collections.Generic;
using System.Drawing;

namespace KDrawing.KControls
{
    public static class GraphicsExtensions
    {
        public static void DrawRectangle(this Graphics g, Pen pen, RectangleF rect) =>
            g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

        public static void DrawSelectPoints(Graphics graphics, Brush brush, Brush brushShadow, PointF point0, PointF point1)
        {
            graphics.FillEllipse(brushShadow, new RectangleF(point0.X - 5, point0.Y - 5, 10, 10));
            graphics.FillEllipse(brushShadow, new RectangleF(point1.X - 5, point1.Y - 5, 10, 10));
            graphics.FillEllipse(brush, new RectangleF(point0.X - 4, point0.Y - 4, 8, 8));
            graphics.FillEllipse(brush, new RectangleF(point1.X - 4, point1.Y - 4, 8, 8));
        }

        public static void DrawSelectPoints(Graphics graphics, Brush brush, Brush brushShadow, List<PointF> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                graphics.FillEllipse(brush, new RectangleF(points[i].X - 5, points[i].Y - 5, 10, 10));
                graphics.FillEllipse(brushShadow, new RectangleF(points[i].X - 4, points[i].Y - 4, 8, 8));
            }
        }

        public static void DrawSelectFrame(Graphics graphics, Pen framePen,Pen framePenShadow, RectangleF selectZone)
        {
            graphics.DrawRectangle(framePenShadow, selectZone);
            graphics.DrawRectangle(framePen, selectZone);
        }
    }
}