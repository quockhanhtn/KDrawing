﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KDrawing.Models;

namespace KDrawing.MyUserControls
{
    public partial class ShapeLayer : UserControl
    {
        cShape shapeShow;
        public fMain FormMain { get => this.FindForm() as fMain; }
        public cShape ShapeShow { get => shapeShow; set => shapeShow = value; }
        public ShapeLayer(cShape shape)
        {
            InitializeComponent();
            ShapeShow = shape;
            txtShapeName.Text = shape.Name;
            chkIsSelected.Checked = shape.IsSelected;
            tmrUpdate.Start();

            txtShapeName.DataBindings.Add("BackColor", this, "BackColor");
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            if (ShapeShow.IsHidden)
            {
                btnHidden.BackgroundImage = Properties.Resources.eye_off_black;
                this.BackColor = Color.FromArgb(230, 255, 255);
            }
            else
            {
                ShapeShow.IsSelected = false;
                chkIsSelected.Checked = false;
                btnHidden.BackgroundImage = Properties.Resources.eye_black;
                this.BackColor = Color.LightGray;
            }

            ShapeShow.IsHidden = !ShapeShow.IsHidden;
            FormMain.ReDraw();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tmrUpdate.Stop();
            FormMain.ListShapes.Remove(this.ShapeShow);
            FormMain.ReDraw();
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