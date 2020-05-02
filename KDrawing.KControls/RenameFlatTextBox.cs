using System;
using System.Drawing;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    public class RenameFlatTextBox : FlatTextBox
    {
        public RenameFlatTextBox()
        {
            ReadOnly = true;
            this.DataBindings.Add(new Binding("BorderColor", this, "BackColor", true, DataSourceUpdateMode.OnPropertyChanged));

            this.DoubleClick += RenameFlatTextBox_DoubleClick;
            this.TextChanged += RenameFlatTextBox_TextChanged;
            this.PreviewKeyDown += RenameFlatTextBox_PreviewKeyDown;
        }

        private void RenameFlatTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
            {
                this.ReadOnly = true;
            }
        }

        private void RenameFlatTextBox_DoubleClick(object sender, EventArgs e)
        {
            this.ReadOnly = false;
            //this.Focus();
            this.Select(0, this.Text.Length);
        }

        private void RenameFlatTextBox_TextChanged(object sender, EventArgs e)
        {
            //this.Focus();
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (!this.Focused)
        //    {
        //        PostMessage(this.Handle, msg.Msg, msg.WParam, msg.LParam);
        //        this.Focus();
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr PostMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}
