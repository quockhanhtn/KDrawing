using KDrawing.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KDrawing.Boxs
{
    public partial class fTextEditor : Form
    {
        cText myctext = new cText(new PointF(10, 10), "Example text", new Font("Segoe UI Semibold", 20F), Color.Black, true);
        Font myFont;
        
        public Font MyFont { 
            get => myFont;
            set
            {
                myFont = value;
                myctext.MyFont = value;
                lblFontFamily.Text = value.FontFamily.Name;
                lblFontStyle.Text = value.Style.ToString();
                lblFontSize.Text = value.Size.ToString();
                this.btnColor.BackColor = fontDialog.Color;
                psfDemo.Invalidate();
            }
        }

        public fTextEditor()
        {
            InitializeComponent();
            MyFont = new Font("Segoe UI Semibold", 20F);
        }

        private void fTextEditor_Shown(object sender, EventArgs e)
        {
            txtText.Text = myctext.Text;
            txtText.Focus();
            txtText.Select(0, txtText.Text.Length);
        }

        public static cText Show(Form form, PointF location)
        {
            using (fTextEditor formTextEditor = new fTextEditor())
            {
                formTextEditor.myctext.Begin = location;
                if (formTextEditor.ShowDialog(form) == DialogResult.OK)
                {
                    return formTextEditor.myctext;
                }
            }
            return null;
        }

        public static void Show(Form form, cText text)
        {
            using (fTextEditor formTextEditor = new fTextEditor())
            {
                if (formTextEditor.ShowDialog(form) == DialogResult.OK)
                {
                    text = formTextEditor.myctext;
                }
            }
        }

        public static void Show(Form form, List<cShape> listShape)
        {
            using (fTextEditor formTextEditor = new fTextEditor())
            {
                if (formTextEditor.ShowDialog(form) == DialogResult.OK)
                {
                    listShape.FindAll(shape => shape.IsSelected && shape is cText).ForEach(text => { text = formTextEditor.myctext; });
                }
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = MyFont;
            fontDialog.Color = btnColor.BackColor;
            fontDialog.ShowDialog();
            MyFont = fontDialog.Font;
            btnColor.BackColor = fontDialog.Color;
        }

        private void btnColor_BackColorChanged(object sender, EventArgs e)
        {
            myctext.Color = btnColor.BackColor;
            btnColor.FlatAppearance.MouseOverBackColor = btnColor.BackColor;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Vendors.ColorPickerDialog.Show(this, btn.BackColor);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            myctext.MyFont = this.MyFont;
            myctext.Color = btnColor.BackColor;
            myctext.Fill = btnIsFill.ToggleStage;
            myctext.Text = txtText.Text;
            myctext.Name = myctext.Text;
        }

        private void psfDemo_Paint(object sender, PaintEventArgs e)
        {
            PointF worldLocation = myctext.Begin;
            myctext.Begin = new PointF(5, 5);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            myctext.Draw(e.Graphics);

            myctext.Begin = worldLocation;
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            myctext.MyFont = this.MyFont;
            myctext.Color = btnColor.BackColor;
            myctext.Fill = btnIsFill.ToggleStage;
            myctext.Text = txtText.Text;
            myctext.Name = myctext.Text;
            psfDemo.Invalidate();
        }

        private void btnIsFill_Click(object sender, EventArgs e)
        {
            myctext.Fill = btnIsFill.ToggleStage;
            psfDemo.Invalidate();
        }
    }
}
