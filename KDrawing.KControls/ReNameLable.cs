using System;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    public class RenameLable : Label
    {
        #region Constructor
        public RenameLable()
        {
            this.DoubleClick += RenameLable_DoubleClick;

            toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.InitialDelay = 0;
            toolTip.SetToolTip(this, this.Text);
        }
        #endregion

        #region Events
        private void RenameLable_DoubleClick(object sender, EventArgs e)
        {
            FlatTextBox txtRename = new FlatTextBox()
            {
                Location = this.Location,
                Font = this.Font,
                BackColor = this.Parent.BackColor,
                BorderColor = this.Parent.BackColor,
                Text = this.Text,
                Width = this.Width,
            };
            txtRename.TextChanged += TxtRename_TextChanged;
            txtRename.MouseLeave += TxtRename_MouseLeave;
            this.Parent.Controls.Add(txtRename);
            this.Visible = false;
            txtRename.Focus();
            txtRename.Select(0, txtRename.Text.Length);
        }

        private void TxtRename_TextChanged(object sender, EventArgs e)
        {
            (sender as FlatTextBox).Focus();
        }

        private void TxtRename_MouseLeave(object sender, EventArgs e)
        {
            var flatTxt = sender as FlatTextBox;
            this.Text = flatTxt.Text;
            flatTxt.Dispose();
            this.Visible = true;

            toolTip.SetToolTip(this, this.Text);
        }
        #endregion

        #region Field

        ToolTip toolTip;

        #endregion
    }
}
