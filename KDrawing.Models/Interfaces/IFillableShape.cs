namespace KDrawing.Models.Interfaces
{
    public interface IFillableShape
    {
        bool IsFill { get; set; }
        [System.Xml.Serialization.XmlElement(Type = typeof(Models.XmlColor))]
        System.Drawing.Color FillColor { get; set; }
    }
}
