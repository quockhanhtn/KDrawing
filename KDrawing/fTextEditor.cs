using KDrawing.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KDrawing
{
    public partial class fTextEditor : Form
    {

        private cText myText;

        public cText MyText 
        {
            get
            {
                if (myText == null) { myText = cText.Default(); }
                return myText;
            }
            set
            {
                myText = value;
                btnFillColor.BackColor = value.FillColor;
                nudLineWeight.Value = (decimal)value.LineWeight;
                psfDemo.Invalidate();
            }
        }

        public fTextEditor()
        {
            InitializeComponent();
        }

        private void fTextEditor_Shown(object sender, EventArgs e)
        {
            lblFontFamily.Text = MyText.MyFont.FontFamily.Name;
            lblFontStyle.Text = MyText.MyFont.Style.ToString();
            lblFontSize.Text = MyText.MyFont.Size.ToString();

            nudLineWeight.Value = (decimal)MyText.LineWeight;
            btnFillColor.BackColor = MyText.FillColor;
            btnIsFill.ToggleStage = MyText.IsFill;
            btnColor.BackColor = MyText.Color;

            txtText.Text = MyText.Text;
            txtText.Focus();
            txtText.Select(0, txtText.Text.Length);
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {
            MyText.MyFont = fontDialog.Font;
            MyText.LineWeight = (float)nudLineWeight.Value;
            btnColor.BackColor = fontDialog.Color;
            lblFontFamily.Text = fontDialog.Font.FontFamily.Name;
            lblFontStyle.Text = fontDialog.Font.Style.ToString();
            lblFontSize.Text = fontDialog.Font.Size.ToString();
           
            psfDemo.Invalidate();
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = MyText.MyFont;
            fontDialog.Color = MyText.Color;

            // Save the existing font.
            Font oldFont = this.Font;

            //Show the dialog, and get the result
            DialogResult result = fontDialog.ShowDialog();

            // If the OK button in the Font dialog box is clicked, 
            // set all the controls' fonts to the chosen font by calling
            // the fontDialog_Apply method.
            if (result == DialogResult.OK)
            {
                fontDialog_Apply(sender, new EventArgs());
            }
            // If Cancel is clicked, set the font back to
            // the original font.
            else if (result == DialogResult.Cancel)
            {
                this.Font = oldFont;
                foreach (Control containedControl in this.Controls)
                {
                    containedControl.Font = oldFont;
                }
            }
        }

        private void btnIsFill_Click(object sender, EventArgs e)
        {
            MyText.IsFill = btnIsFill.ToggleStage;
            if (MyText.IsFill)
            {
                MyText.FillColor = btnFillColor.BackColor;
            }
            psfDemo.Invalidate();
        }

        private void btnFillColor_BackColorChanged(object sender, EventArgs e)
        {
            MyText.FillColor = btnFillColor.BackColor;
            psfDemo.Invalidate();
        }

        private void btnColor_BackColorChanged(object sender, EventArgs e)
        {
            MyText.Color = btnColor.BackColor;
            psfDemo.Invalidate();
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            MyText.Text = txtText.Text;
            psfDemo.Invalidate();
        }

        private void psfDemo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            PointF worldLocation = MyText.Begin;
            MyText.Begin = new PointF(0, 0);
            MyText.Draw(e.Graphics);
            MyText.Begin = worldLocation;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MyText.Name = MyText.Text;
        }

        public static cText Show(Form parrentForm, PointF textLocation, float lineWeight)
        {
            using (fTextEditor formTextEditor = new fTextEditor())
            {
                if (formTextEditor.ShowDialog(parrentForm) == DialogResult.OK)
                {
                    formTextEditor.MyText.Begin = textLocation;
                    formTextEditor.MyText.LineWeight = lineWeight;
                    return formTextEditor.MyText;
                }
            }
            return null;
        }

        public static void Show(Form parrentForm, List<cShape> listShapes)
        {
            using (fTextEditor formTextEditor = new fTextEditor())
            {
                List<cText> listTextEditor = new List<cText>();
                listShapes.FindAll(shape => shape.IsSelected && shape is cText).ForEach(text => listTextEditor.Add(text as cText));

                formTextEditor.MyText.GetProperty(listTextEditor[0]);
                if (formTextEditor.ShowDialog(parrentForm) == DialogResult.OK)
                {
                    for (int i = 0; i < listTextEditor.Count; i++)
                    {
                        listTextEditor[i].GetProperty(formTextEditor.MyText);
                    }
                }
            }
        }

        private void nudLineWeight_ValueChanged(object sender, EventArgs e)
        {
            MyText.LineWeight = (float)nudLineWeight.Value;
            psfDemo.Invalidate();
        }
    }
}
