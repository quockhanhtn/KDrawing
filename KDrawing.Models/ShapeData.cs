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
        [XmlElement(typeof(MyCircle))]
        [XmlElement(typeof(MyCurve))]
        [XmlElement(typeof(MyEllipse))]
        [XmlElement(typeof(MyFreehand))]
        [XmlElement(typeof(MyGroup))]
        [XmlElement(typeof(MyLine))]
        [XmlElement(typeof(MyPolygon))]
        [XmlElement(typeof(MyRectangle))]
        [XmlElement(typeof(MySquare))]
        [XmlElement(typeof(MyText))]
        public List<MyShape> ListShapes;

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
