using KDrawing.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace KDrawing
{
    public partial class fMain
    {
        #region Public Function

        /// <summary>
        /// Vẽ lại psfMain (== psfMain.Invalidate();)
        /// </summary>
        public void ReDraw() { psfMain.Invalidate(); }

        /// <summary>
        /// Phóng to các hình theo tỉ lệ nhập vào
        /// </summary>
        public void ScaleShapes()
        {
            if (ListShapes.Count(shape => shape.IsSelected) > 0)
            {
                float percent = Boxs.fScale.Show(this, 1f);
                ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Scale(percent); });
                ReDraw();
            }
        }

        /// <summary>
        /// Xoay các hình được chọn theo số độ nhập vào
        /// </summary>
        public void RotateShapes()
        {
            if (ListShapes.Count(shape => shape.IsSelected) > 0)
            {
                int degree = Boxs.fRotate.Show(this, 0);
                ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Rotate(degree); });
                ReDraw();
            }
        }

        /// <summary>
        /// Group các hình được chọn
        /// </summary>
        public void GroupSelectedShape()
        {
            if (ListShapes.Count(shape => shape.IsSelected) > 1)
            {
                cGroup group = new cGroup();

                for (int i = 0; i < ListShapes.Count; i++)
                {
                    if (ListShapes[i].IsSelected)
                    {
                        group.Add(ListShapes[i]);
                        ListShapes.RemoveAt(i);
                        i--;
                    }
                }

                group.FindRegion();
                ListShapes.Add(group);
                group.IsSelected = true;

                shapeLayers.Add(group);
                ReDraw();
            }
        }

        /// <summary>
        /// Ungroup các group được chọn
        /// </summary>
        public void UngroupSelectedGroup()
        {
            if (ListShapes.Find(shape => shape.IsSelected) is cGroup selectedGroup)
            {
                selectedGroup.Shapes.ForEach(shape =>
                {
                    ListShapes.Add(shape);
                    shapeLayers.Add(shape);
                });
                ListShapes.Remove(selectedGroup);
            }
            ReDraw();
        }

        /// <summary>
        /// Xóa các hình được chọn
        /// </summary>
        public void DeleteSelectedShape()
        {
            for (int i = ListShapes.Count - 1; i >= 0; i--)
            {
                if (ListShapes[i].IsSelected) { ListShapes.RemoveAt(i); }
            }
            ReDraw();
        }
        #endregion

        #region Private Function
        /// <summary>
        /// Bỏ chọn hết các shapes
        /// </summary>
        private void UnselectAllShapes()
        {
            ListShapes.ForEach(shape => shape.IsSelected = false);
            ReDraw();
        }

        /// <summary>
        /// Bỏ chọn hết các button
        /// </summary>
        private void UncheckAll()
        {
            listButton.ForEach(button => button.BackColor = Color.Transparent);
        }

        /// <summary>
        /// Di chuyển các hình đã chọn
        /// </summary>
        /// <param name="action">Hướng di chuyển</param>
        private void MoveShape(Enums.Direction direction)
        {
            ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => shape.Move(direction, movingOffset));
            ReDraw();
        }
        #endregion
    }
}
