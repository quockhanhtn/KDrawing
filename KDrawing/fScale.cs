using System;
using System.Windows.Forms;

namespace KDrawing
{
    public partial class fScale : Form
    {
        public float Percent { get => (float)nudScale.Value / 100; }
        public fScale()
        {
            InitializeComponent();
        }

        private void fScale_Shown(object sender, EventArgs e)
        {
            nudScale.Focus();
            nudScale.Select(0, nudScale.Value.ToString().Length);
        }

        public static float Show(Form form, float percent)
        {
            using (fScale formScale = new fScale())
            {
                if (formScale.ShowDialog(form) == DialogResult.OK)
                {
                    return formScale.Percent;
                }
                return percent;
            }
        }
    }
}
