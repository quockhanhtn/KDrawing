using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;

namespace KDrawing.Models
{
    public abstract class cShape
    {
        [XmlElement(Type = typeof(XmlColor))]
        public Color Color { get; set; }
        /// <summary>
        /// Điểm đầu (trái trên)
        /// </summary>
        public abstract PointF Begin { get; set; }
        /// <summary>
        /// Điểm cuối (phải dưới)
        /// </summary>
        public abstract PointF End { get; set; }
        /// <summary>
        /// Độ đậm của nét vẽ
        /// </summary>
        public float LineWeight { get; set; }
        /// <summary>
        /// Cho biết hình có đang được chọn hay không
        /// </summary>
        public bool IsSelected { get; set; } = false;
        /// <summary>
        /// Cho biết hình có đang ẩn hay không
        /// </summary>
        public bool IsHidden { get; set; } = false;
        /// <summary>
        /// Tên của hình
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Kiểu nét vẽ
        /// </summary>
        public DashStyle DashStyle { get; set; } = DashStyle.Solid;
        protected abstract GraphicsPath GraphicsPath { get; }
        /// <summary>
        /// Kiểm tra con trỏ ở điểm "point" có đang chỉ vào hình không
        /// </summary>
        /// <param name="point">Vị trí con trỏ chuột</param>
        /// <returns></returns>
        public abstract bool IsHit(PointF point);
        /// <summary>
        /// Vẽ hình
        /// </summary>
        /// <param name="graphics"></param>
        public abstract void Draw(Graphics graphics);
        /// <summary>
        /// Di chuyển hình một khoảng distance.X theo chiều ngang và distance.Y theo chiều dọc
        /// </summary>
        /// <param name="distance"></param>
        public abstract void Move(PointF distance);
        /// <summary>
        /// Di chuyển hình về hướng theo một khoảng cách
        /// </summary>
        /// <param name="direction">Hướng di chuyển</param>
        /// <param name="movingOffset">Khoảng cách di chuyển</param>
        public abstract void Move(Enums.Direction direction, int movingOffset);
        public abstract object Clone();
        /// <summary>
        /// Phóng to hình theo tỉ lệ "percent"
        /// </summary>
        /// <param name="percent">Tỉ lệ phóng to</param>
        public abstract void Scale(float percent);
        /// <summary>
        /// Xoay hình một góc "degree" độ
        /// </summary>
        /// <param name="degree">Số độ xoay</param>
        public abstract void Rotate(int degree);
    }
}