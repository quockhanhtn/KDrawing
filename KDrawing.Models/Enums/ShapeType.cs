namespace KDrawing.Models.Enums
{
    public enum ShapeType
    {
        /// <summary>
        /// Không vẽ
        /// </summary>
        NoDrawing,
        /// <summary>
        /// Chữ
        /// </summary>
        Text,
        /// <summary>
        /// Vẽ tự do
        /// </summary>
        Freehand,
        /// <summary>
        /// Vẽ đường thẳng
        /// </summary>
        Line,
        /// <summary>
        /// Vẽ hình chữ nhật
        /// </summary>
        Rectangle,
        /// <summary>
        /// Vẽ hình vuông
        /// </summary>
        Square,
        /// <summary>
        /// Vẽ đường elip
        /// </summary>
        Ellipse,
        /// <summary>
        /// Vẽ đường tròn
        /// </summary>
        Circle,
        /// <summary>
        /// Vẽ đường cong
        /// </summary>
        Curve,
        /// <summary>
        /// Vẽ đường cong bezier (có 4 điểm)
        /// </summary>
        Bezier,
        /// <summary>
        /// Vẽ đa giác
        /// </summary>
        Polygon,
    }
}
