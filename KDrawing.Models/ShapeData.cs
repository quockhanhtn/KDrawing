using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KDrawing.Models
{
    public class ShapeData
    {
        [XmlElement(typeof(cCircle))]
        [XmlElement(typeof(cCurve))]
        [XmlElement(typeof(cEllipse))]
        [XmlElement(typeof(cFreehand))]
        [XmlElement(typeof(cGroup))]
        [XmlElement(typeof(cLine))]
        [XmlElement(typeof(cPolygon))]
        [XmlElement(typeof(cRectangle))]
        [XmlElement(typeof(cSquare))]
        [XmlElement(typeof(cText))]
        public List<cShape> ListShapes;

        [XmlElement(Type = typeof(XmlColor))]
        public Color BackColor { get; set; }

        public static void Serialize(ShapeData shapeData, string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShapeData));
                xmlSerializer.Serialize(fileStream, shapeData);
                fileStream.Close();
            }
        }

        public static ShapeData Deserialize(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShapeData));
                    ShapeData shapeData = xmlSerializer.Deserialize(fileStream) as ShapeData;
                    fileStream.Close();
                    return shapeData;
                }
                catch (Exception e)
                {
                    fileStream.Close();
                    MessageBox.Show(e.Message);
                }
            }
            return null;
        }
    }
}
