namespace KDrawing.Enums
{
    public enum DrawingStage
    {
        /// <summary>
        /// Khác
        /// </summary>
        Orther,
        /// <summary>
        /// Đang vẽ tự do
        /// </summary>
        IsFreehand,
        /// <summary>
        /// Đang vẽ đường cong
        /// </summary>
        IsDrawCurve,
        /// <summary>
        /// Đang vẽ đa giác
        /// </summary>
        IsDrawPolygon,
        /// <summary>
        /// Đang vẽ đường cong bezier
        /// </summary>
        IsDrawBezier,
        /// <summary>
        /// Đang di chuyển hình
        /// </summary>
        IsMovingShape,
        /// <summary>
        /// Đang dùng chuột tạo vùng chọn
        /// </summary>
        IsMouseSelect,
    }
}
