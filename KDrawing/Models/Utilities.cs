using KDrawing.KControls;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace KDrawing.Models
{
    public class Utilities
    {
        public static string ConvertColorToHex(Color color)
        {
            return (color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2")).ToLower();
        }

        /// <summary>
        /// Rotates one point around another
        /// </summary>
        /// <param name="pointToRotate">The point to rotate.</param>
        /// <param name="centerPoint">The center point of rotation.</param>
        /// <param name="angleInDegrees">The rotation angle in degrees.</param>
        /// <returns>Rotated point</returns>
        public static PointF RotatePoint(PointF pointToRotate, PointF centerPoint, int angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);

            float x = (float)(cosTheta * (pointToRotate.X - centerPoint.X) - sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X);
            float y = (float)(sinTheta * (pointToRotate.X - centerPoint.X) + cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y);
            return new PointF(x, y);
        }

        public static PointF MovePoint(PointF pointToMove, Enums.Direction direction, int movingOffset)
        {
            float x = pointToMove.X;
            float y = pointToMove.Y;

            if (direction == Enums.Direction.Left) { x -= movingOffset; }
            else if (direction == Enums.Direction.Up) { y -= movingOffset; }
            else if (direction == Enums.Direction.Right) { x += movingOffset; }
            else if (direction == Enums.Direction.Down) { y += movingOffset; }

            return new PointF(x, y);
        }

        public static Font ChangeFontSize(Font font, float fontSize)
        {
            if (font != null)
            {
                float currentSize = font.Size;
                if (currentSize != fontSize)
                {
                    font = new Font(font.Name, fontSize, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
                }
            }
            return font;
        }

        /// <summary>
        /// Tạo bitmap từ các hình
        /// </summary>
        /// <param name="width">chiều rộng</param>
        /// <param name="heigth">chiều cao</param>
        /// <param name="backColor">màu nền</param>
        /// <param name="listShapes">các hình vẽ co1 IsHidden = false</param>
        /// <returns></returns>
        public static Bitmap CreateBimap(int width, int heigth, Color backColor, List<cShape> listShapes)
        {
            Bitmap bitmap = new Bitmap(width, heigth, System.Drawing.Imaging.PixelFormat.Format64bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(backColor);
            listShapes.FindAll(shape => !shape.IsHidden).ForEach(shape => shape.Draw(graphics));
            return bitmap;
        }
    }
}
