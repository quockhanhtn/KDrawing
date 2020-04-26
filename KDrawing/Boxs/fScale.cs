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
    public partial class fScale : Form
    {
        public float Percent { get => (float)nudScale.Value / 100; }
        public fScale()
        {
            InitializeComponent();
            nudScale.Focus();
        }

        public static float Show(Form form, float percent)
        {
            fScale formScale = new fScale();
            if (formScale.ShowDialog(form) == DialogResult.OK)
            {
                return formScale.Percent;
            }
            return percent;
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
