using System;
using System.Windows.Forms;

namespace KDrawing
{
    public partial class fRotate : Form
    {
        public int Degree { get => (int)nudDegree.Value; }

        public fRotate()
        {
            InitializeComponent();
        }

        private void fRotate_Shown(object sender, EventArgs e)
        {
            nudDegree.Focus();
            nudDegree.Select(0, nudDegree.Value.ToString().Length);
        }

        public static int Show(Form form, int degree)
        {
            using (fRotate formRotate = new fRotate())
            {
                if (formRotate.ShowDialog(form) == DialogResult.OK)
                {
                    return formRotate.Degree;
                }
            }
            return degree;
        }

    }
}
