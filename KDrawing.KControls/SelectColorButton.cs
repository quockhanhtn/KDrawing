using System;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    public class SelectColorButton : FlatButton
    {
        #region Constructor
        public SelectColorButton()
        {
            this.BackColorChanged += ButtonSelectColor_BackColorChanged;
            this.Click += SelectColorButton_Click;

            ButtonSelectColor_BackColorChanged(this, null);
        }
        #endregion

        #region Events
        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = fColorPicker.Show(this.FindForm(), btn.BackColor);
        }

        private void ButtonSelectColor_BackColorChanged(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
        }
        #endregion
    }
}
