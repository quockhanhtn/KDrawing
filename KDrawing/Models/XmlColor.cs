using System;
using System.Drawing;
using System.Xml.Serialization;

namespace KDrawing.Models
{
    public class XmlColor
    {
        #region Properties
        [XmlAttribute]
        public string Web
        {
            get { return ColorTranslator.ToHtml(color); }
            set
            {
                try
                {
                    if (Alpha == 0xFF) // preserve named color value if possible
                    {
                        color = ColorTranslator.FromHtml(value);
                    }
                    else
                    {
                        color = Color.FromArgb(Alpha, ColorTranslator.FromHtml(value));
                    }
                }
                catch (Exception)
                {
                    color = Color.Black;
                }
            }
        }

        [XmlAttribute]
        public byte Alpha
        {
            get { return color.A; }
            set
            {
                if (value != color.A) // avoid hammering named color if no alpha change
                {
                    color = Color.FromArgb(value, color);
                }
            }
        }

        public Color ToColor() { return color; }

        public bool ShouldSerializeAlpha() { return Alpha < 0xFF; }
        #endregion

        #region Fields
        private Color color = Color.Black;
        #endregion

        #region Constructor
        public XmlColor() { }
        public XmlColor(Color color) { this.color = color; }
        #endregion

        #region Methods
        public void FromColor(Color color) { this.color = color; }

        public static implicit operator Color(XmlColor xmlColor) { return xmlColor.ToColor(); }

        public static implicit operator XmlColor(Color color) { return new XmlColor(color); }
        #endregion
    }
}
