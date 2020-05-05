using System;
using System.ComponentModel;
using System.Drawing;

namespace KDrawing.Models
{
    [TypeConverter(typeof(FontConverter))]
    static public class FontSerializationHelper
    {
        static public Font FromString(string value)
        {
            var parts = value.Split(':');
            return new Font(
                parts[0],                                                   // FontFamily.Name
                float.Parse(parts[1]),                                      // Size
                EnumSerializationHelper.FromString<FontStyle>(parts[2]),    // Style
                EnumSerializationHelper.FromString<GraphicsUnit>(parts[3]), // Unit
                byte.Parse(parts[4]),                                       // GdiCharSet
                bool.Parse(parts[5])                                        // GdiVerticalFont
            );
        }

        static public string ToString(Font font)
        {
            return font.FontFamily.Name
                    + ":" + font.Size
                    + ":" + font.Style
                    + ":" + font.Unit
                    + ":" + font.GdiCharSet
                    + ":" + font.GdiVerticalFont
                    ;
        }
    }

    [TypeConverter(typeof(EnumConverter))]
    static public class EnumSerializationHelper
    {
        static public T FromString<T>(string value)
        {
            return (T)System.Enum.Parse(typeof(T), value, true);
        }
    }
}
