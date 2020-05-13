using System.Drawing;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    public class DragMovePanel : Panel
    {
        #region Fields
        private Point oldLocation;
        private Point distanceMoved;
        #endregion

        #region Propertie
        private Point DistanceMoved
        {
            get => distanceMoved;
            set
            {
                distanceMoved = value;
                int parentXLoc = this.FindForm().Location.X + distanceMoved.X - oldLocation.X;
                int parentYLoc = this.FindForm().Location.Y + distanceMoved.Y - oldLocation.Y;
                this.FindForm().Location = new Point(parentXLoc, parentYLoc);
            }
        }
        #endregion

        #region Constructor
        public DragMovePanel()
        {
            this.MouseDown += DragMovePanel_MouseDown;
            this.MouseMove += DragMovePanel_MouseMove;
            this.MouseUp += DragMovePanel_MouseUp;
        }
        #endregion

        #region Events
        private void DragMovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.SizeAll;
                this.oldLocation = e.Location;
            }
        }

        private void DragMovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Cursor == Cursors.SizeAll)
            {
                DistanceMoved = e.Location;
            }
        }

        private void DragMovePanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        #endregion
    }
}
