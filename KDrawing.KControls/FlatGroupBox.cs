using System.Drawing;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    public class FlatGroupBox : GroupBox
    {
        #region Fields

        Color borderColor = Color.Black;
        float borderWidth = 2;

        #endregion

        #region Properties
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }
        public float BorderWidth { 
            get => borderWidth; 
            set { borderWidth = value; this.Invalidate();}
        }
        #endregion

        #region Constructor
        public FlatGroupBox()
        {
            this.DoubleBuffered = true;
            this.Paint += FlatGroupBox_Paint;
        }
        #endregion

        #region Event
        private void FlatGroupBox_Paint(object sender, PaintEventArgs e)
        {
            Brush textBrush = new SolidBrush(this.ForeColor);
            Brush borderBrush = new SolidBrush(borderColor);
            Pen borderPen = new Pen(borderBrush, borderWidth);
            SizeF strSize = e.Graphics.MeasureString(this.Text, this.Font);
            Rectangle rect = new Rectangle(this.ClientRectangle.X,
                                           this.ClientRectangle.Y + (int)(strSize.Height / 2),
                                           this.ClientRectangle.Width - 1,
                                           this.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Clear text and border
            e.Graphics.Clear(this.BackColor);

            // Draw text
            e.Graphics.DrawString(this.Text, this.Font, textBrush, this.Padding.Left + 5, -2);

            // Drawing Border
            //Left
            e.Graphics.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            //Right
            e.Graphics.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Bottom
            e.Graphics.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Top1
            e.Graphics.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + this.Padding.Left + 5, rect.Y));
            //Top2
            e.Graphics.DrawLine(borderPen, new Point(rect.X + this.Padding.Left + (int)(strSize.Width) + 10, rect.Y), new Point(rect.X + rect.Width, rect.Y));
        }
        #endregion
    }
}
