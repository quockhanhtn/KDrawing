using System;
using System.Windows.Forms;
using KDrawing.Models;

namespace KDrawing.MyUserControls
{
    public partial class ShapeLayersManager : UserControl
    {
        private fMain formMain;
        private fMain FormMain {
            get
            {
                if (formMain == null) { formMain = this.FindForm() as fMain; }
                return formMain;
            }
        }
        public ShapeLayersManager()
        {
            InitializeComponent();
        }

        public void Add(MyShape shape)
        {
            flpShapeLayers.Controls.Add(new ShapeLayer(shape));
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            int numShapeSelected = FormMain.ListShapes.FindAll(shape => shape.IsSelected).Count;
            if (numShapeSelected < 1) { return; } 
            string dialogText = "Are you sure you want to delete " + numShapeSelected.ToString() + " shape is selected ?";

            DialogResult dialogResult = MessageBox.Show(dialogText, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            
            if (dialogResult == DialogResult.Yes) { FormMain.DeleteSelectedShape(); }
        }

        private void chkSelectedAll_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkSelectedAll.CheckState == CheckState.Checked)
            {
                FormMain.ListShapes.FindAll(shape => !shape.IsHidden).ForEach(shape => shape.IsSelected = true);
            }
            else if (chkSelectedAll.CheckState == CheckState.Unchecked)
            {
                FormMain.ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => shape.IsSelected = false);
            }
        }

        public void Update(int numShapeSelected, int numShape)
        {
            if (numShapeSelected == numShape)
            {
                chkSelectedAll.CheckState = CheckState.Checked;
            }
            else if (numShapeSelected == 0)
            {
                chkSelectedAll.CheckState = CheckState.Unchecked;
            }
            else if (numShapeSelected < numShape)
            {
                chkSelectedAll.CheckState = CheckState.Indeterminate;
            }
        }
    }
}
