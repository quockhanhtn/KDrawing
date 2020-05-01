using KDrawing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDrawing.Boxs
{
    public partial class fTextEditor : Form
    {
        cText myctext = new cText(new PointF());
        Font myFont;
        
        public Font MyFont { 
            get => myFont;
            set
            {
                myFont = value;
                myctext.MyFont = value;
                this.lblFont.Text = "Font " + value.Name.ToString();
                this.btnColor.BackColor = fontDialog.Color;
                this.txtText.Font = value;
            }
        }

        public fTextEditor()
        {
            InitializeComponent();
            myFont = txtText.Font;
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

        public static void Show(Form form, cText cText)
        {
        }

        public static void Show(Form form, List<cText> listTexts)
        {
            
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = MyFont;
            fontDialog.ShowDialog();
            MyFont = fontDialog.Font;
        }

        private void btnColor_BackColorChanged(object sender, EventArgs e)
        {
            txtText.ForeColor = btnColor.BackColor;
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
