using System.Drawing;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    public partial class PaintSurface : Panel
    {
        #region Propertie
        public Bitmap MyBitmap { get; set; }
        #endregion

        #region Constructor
        public PaintSurface() : base()
        {
            DoubleBuffered = true;
            this.Resize += PaintSurface_Resize;
            MyBitmap = new Bitmap((int)this.Width, (int)this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        #endregion

        #region Events
        private void PaintSurface_Resize(object sender, System.EventArgs e)
        {
            MyBitmap.Dispose();
            MyBitmap = new Bitmap((int)this.Width, (int)this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        #endregion
    }
}
