using System;
using System.Windows.Forms;

namespace KDrawing.Boxs
{
    public partial class fRotate : Form
    {
        public int Degree { get => (int)nudDegree.Value; }

        public fRotate()
        {
            InitializeComponent();
        }

        public static int Show(Form form, int degree)
        {
            fRotate formRotate = new fRotate();
            if (formRotate.ShowDialog(form) == DialogResult.OK)
            {
                return formRotate.Degree;
            }
            return degree;
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
