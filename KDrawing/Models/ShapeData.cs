using System;
using System.Collections.Generic;
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

        public static void Serialize(List<cShape> cShapes, string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                ShapeData shapeData = new ShapeData() { ListShapes = cShapes };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShapeData));
                xmlSerializer.Serialize(fileStream, shapeData);
                fileStream.Close();
            }
        }

        public static List<cShape> Deserialize(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShapeData));
                        ShapeData shapeData = xmlSerializer.Deserialize(fileStream) as ShapeData;
                        fileStream.Close();
                        return shapeData.ListShapes;
                    }
                    catch (Exception e)
                    {
                        fileStream.Close();
                        MessageBox.Show(e.Message);
                    }
                }
            }
            return new List<cShape>();
        }
    }
}
