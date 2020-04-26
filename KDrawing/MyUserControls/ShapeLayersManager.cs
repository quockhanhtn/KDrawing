using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KDrawing.Models;
using System.Collections.ObjectModel;

namespace KDrawing.MyUserControls
{
    public partial class ShapeLayersManager : UserControl
    {
        public ShapeLayersManager()
        {
            InitializeComponent();
        }

        public void Add(cShape shape)
        {
            flpShapeLayers.Controls.Add(new ShapeLayer(shape));
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.flpShapeLayers.Size.ToString());
        }
    }
}
