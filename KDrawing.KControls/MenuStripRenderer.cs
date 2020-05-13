using System.Drawing;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    /// <summary>
    /// Thay đổi hover color MenuStrip
    /// </summary>
    public class MenuStripRenderer : ToolStripProfessionalRenderer
    {
        #region Properties
        public int MyProperty { get; set; }
        public Color MouseHoverColor { get; set; }
        #endregion

        #region Constructor
        public MenuStripRenderer(Color mouseHoverColor) : base()
        {
            this.MouseHoverColor = mouseHoverColor;
        }
        #endregion

        #region Event
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs myMenu)
        {
            if (!myMenu.Item.Selected)
            {
                base.OnRenderMenuItemBackground(myMenu);
            }
            else
            {
                Rectangle menuRectangle = new Rectangle(Point.Empty, myMenu.Item.Size);
                //Fill Color
                myMenu.Graphics.FillRectangle(new SolidBrush(MouseHoverColor), menuRectangle);
                // Border Color
                //myMenu.Graphics.DrawRectangle(Pens.White, 1, 0, menuRectangle.Width - 2, menuRectangle.Height - 1);
            }
        }
        #endregion
    }
}
