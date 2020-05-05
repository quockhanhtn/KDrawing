using KDrawing.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDrawing
{
    public partial class fMain
    {
        #region Public Function

        /// <summary>
        /// Vẽ lại psfMain
        /// </summary>
        public void ReDraw() { this.psfMain.Invalidate(); }

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

                for (int i = ListShapes.Count - 1; i >= 0; i--)
                {
                    if (ListShapes[i].IsSelected)
                    {
                        group.Add(ListShapes[i]);
                        ListShapes.RemoveAt(i);
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
                foreach (cShape shape in selectedGroup.Shapes)
                {
                    ListShapes.Add(shape);
                    shapeLayers.Add(shape);
                }
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
            //if (drawingMode == DrawingMode.Fill)
            //{
            //    cboDrawingMode.SelectedIndex = 1;
            //}
        }

        /// <summary>
        /// Kích hoạt các button
        /// </summary>
        private void EnableButtons()
        {
            this.listButton.ForEach(button => button.Enabled = true);
        }

        /// <summary>
        /// Di chuyển các hình đã chọn
        /// </summary>
        /// <param name="action">Hướng di chuyển</param>
        private void MoveShape(Action<int> action)
        {
            for (int i = 0; i < ListShapes.Count; i++)
            {
                if (ListShapes[i].IsSelected)
                {
                    action(i);
                }
            }
            ReDraw();
        }

        /// <summary>
        /// Di chuyển hình ở vị trí index sang phải
        /// </summary>
        /// <param name="index">Vị trí của hình</param>
        private void ToRight(int index)
        {
            cShape shape = ListShapes[index];
            if (shape is cFreehand freehand)
            {
                for (int j = 0; j < freehand.Points.Count; j++)
                {
                    freehand.Points[j] = new PointF(freehand.Points[j].X + movingOffset, freehand.Points[j].Y);
                }
            }
            else if (shape is cCurve curve)
            {
                for (int j = 0; j < curve.Points.Count; j++)
                {
                    curve.Points[j] = new PointF(curve.Points[j].X + movingOffset, curve.Points[j].Y);
                }
            }
            else if (shape is cPolygon polygon)
            {
                for (int j = 0; j < polygon.Points.Count; j++)
                {
                    polygon.Points[j] = new PointF(polygon.Points[j].X + movingOffset, polygon.Points[j].Y);
                }
            }
            else if (shape is cGroup group)
            {
                for (int i = 0; i < group.Count; i++)
                {
                    cShape s = group[i];
                    if (s is cCurve c)
                    {
                        for (int j = 0; j < c.Points.Count; j++)
                        {
                            c.Points[j] = new PointF(c.Points[j].X + movingOffset, c.Points[j].Y);
                        }
                    }
                    else if (s is cPolygon p)
                    {
                        for (int j = 0; j < p.Points.Count; j++)
                        {
                            p.Points[j] = new PointF(p.Points[j].X + movingOffset, p.Points[j].Y);
                        }
                    }
                    s.Begin = new PointF(s.Begin.X + movingOffset, s.Begin.Y);
                    s.End = new PointF(s.End.X + movingOffset, s.End.Y);
                }
            }
            shape.Begin = new PointF(shape.Begin.X + movingOffset, shape.Begin.Y);
            shape.End = new PointF(shape.End.X + movingOffset, shape.End.Y);
        }

        /// <summary>
        /// Di chuyển hình ở vị trí index lên trên
        /// </summary>
        /// <param name="index">Vị trí của hình</param>
        private void ToUp(int index)
        {
            cShape shape = ListShapes[index];
            if (shape is cFreehand freehand)
            {
                for (int j = 0; j < freehand.Points.Count; j++)
                {
                    freehand.Points[j] = new PointF(freehand.Points[j].X, freehand.Points[j].Y - movingOffset);
                }
            }
            else if (shape is cCurve curve)
            {
                for (int j = 0; j < curve.Points.Count; j++)
                {
                    curve.Points[j] = new PointF(curve.Points[j].X, curve.Points[j].Y - movingOffset);
                }
            }
            else if (shape is cPolygon polygon)
            {
                for (int j = 0; j < polygon.Points.Count; j++)
                {
                    polygon.Points[j] = new PointF(polygon.Points[j].X, polygon.Points[j].Y - movingOffset);
                }
            }
            else if (shape is cGroup group)
            {
                for (int i = 0; i < group.Count; i++)
                {
                    cShape s = group[i];
                    if (s is cCurve c)
                    {
                        for (int j = 0; j < c.Points.Count; j++)
                        {
                            c.Points[j] = new PointF(c.Points[j].X, c.Points[j].Y - movingOffset);
                        }
                    }
                    else if (s is cPolygon p)
                    {
                        for (int j = 0; j < p.Points.Count; j++)
                        {
                            p.Points[j] = new PointF(p.Points[j].X, p.Points[j].Y - movingOffset);
                        }
                    }
                    s.Begin = new PointF(s.Begin.X, s.Begin.Y - movingOffset);
                    s.End = new PointF(s.End.X, s.End.Y - movingOffset);
                }
            }
            shape.Begin = new PointF(shape.Begin.X, shape.Begin.Y - movingOffset);
            shape.End = new PointF(shape.End.X, shape.End.Y - movingOffset);
        }

        /// <summary>
        /// Di chuyển hình ở vị trí index xuống dưới
        /// </summary>
        /// <param name="index">Vị trí của hình</param>
        private void ToDown(int index)
        {
            cShape shape = ListShapes[index];
            if (shape is cFreehand freehand)
            {
                for (int j = 0; j < freehand.Points.Count; j++)
                {
                    freehand.Points[j] = new PointF(freehand.Points[j].X , freehand.Points[j].Y + movingOffset);
                }
            }
            else if (shape is cCurve curve)
            {
                for (int j = 0; j < curve.Points.Count; j++)
                {
                    curve.Points[j] = new PointF(curve.Points[j].X, curve.Points[j].Y + movingOffset);
                }
            }
            else if (shape is cPolygon polygon)
            {
                for (int j = 0; j < polygon.Points.Count; j++)
                {
                    polygon.Points[j] = new PointF(polygon.Points[j].X, polygon.Points[j].Y + movingOffset);
                }
            }
            else if (shape is cGroup group)
            {
                for (int i = 0; i < group.Count; i++)
                {
                    cShape s = group[i];
                    if (s is cCurve c)
                    {
                        for (int j = 0; j < c.Points.Count; j++)
                        {
                            c.Points[j] = new PointF(c.Points[j].X, c.Points[j].Y + movingOffset);
                        }
                    }
                    else if (s is cPolygon p)
                    {
                        for (int j = 0; j < p.Points.Count; j++)
                        {
                            p.Points[j] = new PointF(p.Points[j].X, p.Points[j].Y + movingOffset);
                        }
                    }
                    s.Begin = new PointF(s.Begin.X, s.Begin.Y + movingOffset);
                    s.End = new PointF(s.End.X, s.End.Y + movingOffset);
                }
            }
            shape.Begin = new PointF(shape.Begin.X, shape.Begin.Y + movingOffset);
            shape.End = new PointF(shape.End.X, shape.End.Y + movingOffset);
        }

        /// <summary>
        /// Di chuyển hình ở vị trí index sang trái
        /// </summary>
        /// <param name="index">Vị trí của hình</param>
        private void ToLeft(int index)
        {
            cShape shape = ListShapes[index];
            if (shape is cFreehand freehand)
            {
                for (int j = 0; j < freehand.Points.Count; j++)
                {
                    freehand.Points[j] = new PointF(freehand.Points[j].X - movingOffset, freehand.Points[j].Y);
                }
            }
            else if (shape is cCurve curve)
            {
                for (int j = 0; j < curve.Points.Count; j++)
                {
                    curve.Points[j] = new PointF(curve.Points[j].X - movingOffset, curve.Points[j].Y);
                }
            }
            else if (shape is cPolygon polygon)
            {
                for (int j = 0; j < polygon.Points.Count; j++)
                {
                    polygon.Points[j] = new PointF(polygon.Points[j].X - movingOffset, polygon.Points[j].Y);
                }
            }
            else if (shape is cGroup group)
            {
                for (int i = 0; i < group.Count; i++)
                {
                    cShape s = group[i];
                    if (s is cCurve c)
                    {
                        for (int j = 0; j < c.Points.Count; j++)
                        {
                            c.Points[j] = new PointF(c.Points[j].X - movingOffset, c.Points[j].Y);
                        }
                    }
                    else if (s is cPolygon p)
                    {
                        for (int j = 0; j < p.Points.Count; j++)
                        {
                            p.Points[j] = new PointF(p.Points[j].X - movingOffset, p.Points[j].Y);
                        }
                    }
                    s.Begin = new PointF(s.Begin.X - movingOffset, s.Begin.Y);
                    s.End = new PointF(s.End.X - movingOffset, s.End.Y);
                }
            }
            shape.Begin = new PointF(shape.Begin.X - movingOffset, shape.Begin.Y);
            shape.End = new PointF(shape.End.X - movingOffset, shape.End.Y);
        }
        #endregion
    }
}
