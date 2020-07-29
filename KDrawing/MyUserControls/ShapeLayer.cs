using System;
using System.Drawing;
using System.Windows.Forms;
using KDrawing.Models;

namespace KDrawing.MyUserControls
{
    public partial class ShapeLayer : UserControl
    {
        public fMain FormMain { get => this.FindForm() as fMain; }
        public MyShape ShapeShow { get; set; }
        public ShapeLayer(MyShape shape)
        {
            InitializeComponent();
            ShapeShow = shape;
            txtShapeName.Text = shape.Name;
            chkIsSelected.Checked = shape.IsSelected;

            txtShapeName.DataBindings.Add(new Binding("Text", ShapeShow, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            txtShapeName.DataBindings.Add(new Binding("BackColor", this, "BackColor", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            if (ShapeShow.IsHidden)
            {
                btnHidden.BackgroundImage = Properties.Resources.eye_off_black;
                this.BackColor = Color.FromArgb(230, 255, 255);
                chkIsSelected.Enabled = true;
            }
            else
            {
                ShapeShow.IsSelected = false;
                chkIsSelected.Checked = false;
                btnHidden.BackgroundImage = Properties.Resources.eye_black;
                this.BackColor = Color.LightGray;
                chkIsSelected.Enabled = false;
            }

            ShapeShow.IsHidden = !ShapeShow.IsHidden;
            FormMain.ReDraw();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tmrUpdate.Stop();
            FormMain.ListShapes.Remove(this.ShapeShow);
            FormMain.ReDraw();
            this.Dispose();
        }

        private void chkIsSelected_CheckedChanged(object sender, EventArgs e)
        {
            ShapeShow.IsSelected = chkIsSelected.Checked;
            if (FormMain != null) { FormMain.ReDraw(); }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            chkIsSelected.Checked = ShapeShow.IsSelected;
            if (FormMain != null && FormMain.ListShapes.Contains(ShapeShow) == false) { this.Dispose(); }
        }
    }
}
