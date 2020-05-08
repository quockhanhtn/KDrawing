using System;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    public class SelectColorButton : FlatButton
    {
        public SelectColorButton()
        {
            this.BackColorChanged += ButtonSelectColor_BackColorChanged;
        }

        private void ButtonSelectColor_BackColorChanged(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
        }
    }
}
