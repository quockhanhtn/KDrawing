using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDrawing.KControls
{
    public static class GraphicsExtensions
    {
        public static void DrawRectangle(this Graphics g, Pen pen, RectangleF rect) =>
            g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
    }
}