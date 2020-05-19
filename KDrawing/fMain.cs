using KDrawing.Enums;
using KDrawing.KControls;
using KDrawing.Models;
using KDrawing.Models.Enums;
using KDrawing.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace KDrawing
{
    public partial class fMain : Form
    {
        #region Fields
        public static int untitledIndex = 0;

        ShapeType shapeType = ShapeType.NoDrawing;
        DrawingMode drawingMode = DrawingMode.NoFill;
        DrawingStage drawingStage = DrawingStage.Orther;
        private string filePath;

        private List<Button> listButton;
        private List<cShape> listShapes = new List<cShape>();
        private PointF previousPoint;
        private Brush brush = new SolidBrush(Color.Blue);
        private Pen framePen = new Pen(Color.Blue, 1)
        {
            DashPattern = new float[] { 3, 3, 3, 3 },
            DashStyle = DashStyle.Custom
        };

        private cShape selectedShape;
        private PointF selectedPoint1;
        private PointF selectedPoint2;
        private RectangleF selectedRegion;

        private bool isMouseDown;
        private bool isControlKeyPress;
        private bool isShiftKeyPress;
        private int movingOffset;
        #endregion

        #region Properties
        public List<cShape> ListShapes { get => listShapes; set => listShapes = value; }
        public RectangleF SelectedRegion
        {
            get
            {
                if (selectedPoint1 == new PointF() || selectedPoint2 == new PointF()) { return new RectangleF(); }

                float width = selectedPoint2.X - selectedPoint1.X;
                float height = selectedPoint2.Y - selectedPoint1.Y;

                if (width > 0 && height > 0)
                {
                    selectedRegion = new RectangleF(selectedPoint1, new SizeF(width, height));
                }
                else if (width < 0 && height > 0)
                {
                    selectedRegion = new RectangleF(selectedPoint2.X, selectedPoint1.Y, -width, height);
                }
                else if (width > 0 && height < 0)
                {
                    selectedRegion = new RectangleF(selectedPoint1.X, selectedPoint2.Y, width, -height);
                }
                else
                {
                    selectedRegion = new RectangleF(selectedPoint2, new SizeF(-width, -height));
                }

                return selectedRegion;
            }
            set => selectedRegion = value;
        }
        public ShapeType ShapeType { 
            get => shapeType;
            set
            {
                shapeType = value;
                statusBar_ShapeType.Text = "Shape type : " + value.ToString();
            }
        }
        public DrawingMode DrawingMode
        {
            get => drawingMode;
            set
            {
                drawingMode = value;
                statusBar_DrawingMode.Text = "Mode : " + value.ToString();
            }
        }
        #endregion

        public fMain()
        {
            InitializeComponent();
        }

        #region Events
        #region fMain event
        private void fMain_Load(object sender, EventArgs e)
        {
            mnu.Renderer = new MenuStripRenderer(Color.FromArgb(28, 151, 234));

            DrawingMode = DrawingMode.NoFill;
            ShapeType = ShapeType.NoDrawing;
            listButton = new List<Button> { btnBezier, btnCurve, btnEllipse, btnLine, btnPolygon, btnRectangle, btnSelect, btnPencil, btnText };
            cboDashStyle.SelectedIndex = 0;

            if (System.IO.File.Exists(this.filePath))
            {
                titleBar.TitleText = System.IO.Path.GetFileName(filePath) + " - KDrawing";

                var shapeData = ShapeData.Deserialize(filePath);
                psfMain.BackColor = shapeData.BackColor;
                shapeData.ListShapes.ForEach(shape =>
                {
                    ListShapes.Add(shape);
                    shapeLayers.Add(shape);
                });
                ReDraw();
            }
            else { titleBar.TitleText = "Untitled " + (++untitledIndex).ToString() + " - KDrawing"; }
        }

        private void fMain_KeyDown(object sender, KeyEventArgs e)
        {
            psfMain.Focus();
            isControlKeyPress = e.Control;
            isShiftKeyPress = e.Shift;

            if (e.Control) { movingOffset = 1; }
            else { movingOffset = 5; }

            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    MoveShape(Direction.Up);
                    break;
                case Keys.S:
                case Keys.Down:
                    MoveShape(Direction.Down);
                    break;
                case Keys.Left:
                case Keys.A:
                    MoveShape(Direction.Left);
                    break;
                case Keys.Right:
                case Keys.D:
                    MoveShape(Direction.Right);
                    break;
                case Keys.Delete:
                    DeleteSelectedShape();
                    break;
                case Keys.OemOpenBrackets:  //Phím [
                    if (nudLineWeight.Enabled && nudLineWeight.Value > 1) { nudLineWeight.Value -= 0.5m; }
                    break;
                case Keys.OemCloseBrackets: //Phím ]
                    if (nudLineWeight.Enabled && nudLineWeight.Value < 100) { nudLineWeight.Value += 0.5m; }
                    break;
                case Keys.Oemplus:          //Phím =
                    ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Scale(1.1f); });
                    ReDraw();
                    break;
                case Keys.OemMinus:         //Phím -
                    ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Scale(0.9f); });
                    ReDraw();
                    break;
            }
        }

        private void fMain_KeyUp(object sender, KeyEventArgs e)
        {
            isControlKeyPress = e.Control;
            isShiftKeyPress = e.Shift;
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ListShapes.Count > 0)
            {
                string mess = "Save changes to drawing project \"" + titleBar.TitleText.TrimEnd(" - KDrawing".ToCharArray()) + "\" before quitting ?"; ;
                DialogResult dialogResult = MessageBox.Show(mess, "KDrawing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    mnuFile_Save.PerformClick();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        private void btnCloseToolbar_Click(object sender, EventArgs e)
        {
            if (tblpnlMidArea.Controls.Contains(pnlToolbar))
            {
                tblpnlMidArea.Controls.Remove(pnlToolbar);
                btnCloseToolbar.ToolTipCaption = "Open tool bar";
            }
            else
            {
                tblpnlMidArea.Controls.Add(pnlToolbar);
                btnCloseToolbar.ToolTipCaption = "Close tool bar";
            }
        }

        private void btnCloseLayer_Click(object sender, EventArgs e)
        {
            if (tblpnlMidArea.Controls.Contains(shapeLayers))
            {
                tblpnlMidArea.Controls.Remove(shapeLayers);
                btnCloseLayer.ToolTipCaption = "Open layers";
            }
            else
            {
                tblpnlMidArea.Controls.Add(shapeLayers);
                btnCloseLayer.ToolTipCaption = "Close layers";
            }
        }

        private void btnEnableFill_Click(object sender, EventArgs e)
        {
            if (btnEnableFill.ToggleStage)
            {
                DrawingMode = DrawingMode.Fill;
                btnFillColor.Enabled = true;
                ListShapes.FindAll(shape => (shape is IFillableShape && shape.IsSelected)).ForEach(shape => (shape as IFillableShape).IsFill = true);

                if (btnEllipse.Tag.ToString() == "Ellipse") { btnEllipse.BackgroundImage = Properties.Resources.shape_ellipse_white; }
                else { btnEllipse.BackgroundImage = Properties.Resources.shape_circle_white; }
                if (btnRectangle.Tag.ToString() == "Rectangle") { btnRectangle.BackgroundImage = Properties.Resources.shape_rectangle_white; }
                else { btnRectangle.BackgroundImage = Properties.Resources.shape_square_white; }
                btnPolygon.BackgroundImage = Properties.Resources.shape_pentagon_white;
            }
            else
            {
                DrawingMode = DrawingMode.NoFill;
                btnFillColor.Enabled = false;
                ListShapes.FindAll(shape => (shape is IFillableShape && shape.IsSelected)).ForEach(shape => (shape as IFillableShape).IsFill = false);


                if (btnEllipse.Tag.ToString() == "Ellipse") { btnEllipse.BackgroundImage = Properties.Resources.shape_ellipse_outline_white; }
                else { btnEllipse.BackgroundImage = Properties.Resources.shape_circle_outline_white; }
                if (btnRectangle.Tag.ToString() == "Rectangle") { btnRectangle.BackgroundImage = Properties.Resources.shape_rectangle_outline_white; }
                else { btnRectangle.BackgroundImage = Properties.Resources.shape_square_outline_white; }
                btnPolygon.BackgroundImage = Properties.Resources.shape_pentagon_outline_white;
            }
            ReDraw();
        }

        private void nudLineWeight_ValueChanged(object sender, EventArgs e)
        {
            statusBar_LineWeight.Text = "Line weight : " + nudLineWeight.Value.ToString();

            this.ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape =>
            {
                if (shape is cGroup group)
                {
                    foreach (cShape s in group.Shapes) { s.LineWeight = (float)nudLineWeight.Value; }
                }
                else { shape.LineWeight = (float)nudLineWeight.Value; }
            });

            ReDraw();
        }

        private void cboDashStyle_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.DrawBackground();
            //if (e.Index != -1) { e.Graphics.DrawImage(imgCboDashStyle.Images[e.Index], e.Bounds.Left, e.Bounds.Top); }

            e.DrawBackground();
            if (e.Index != -1)
            {
                e.Graphics.DrawImage(imgCboDashStyle.Images[e.Index], e.Bounds.Left, e.Bounds.Top);
            }
            e.DrawFocusRectangle();
        }

        private void cboDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusBar_DashStyle.Text = "Dash style : " + ((DashStyle)cboDashStyle.SelectedIndex).ToString();

            this.ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape =>
            {
                shape.DashStyle = (DashStyle)cboDashStyle.SelectedIndex;
            });

            this.ReDraw();
        }

        #region select Color button event
        private void btnDefaultColor_Click(object sender, EventArgs e)
        {
            btnForeColor.BackColor = Color.Black;
            btnBackColor.BackColor = Color.White;
        }

        private void btnSwapColor_Click(object sender, EventArgs e)
        {
            Color temp = btnForeColor.BackColor;
            btnForeColor.BackColor = btnBackColor.BackColor;
            btnBackColor.BackColor = temp;
        }

        private void btnFillColor_BackColorChanged(object sender, EventArgs e)
        {
            var btn = sender as Button;
            ListShapes.FindAll(shape => shape.IsSelected && shape is IFillableShape).ForEach(shape =>
            {
                (shape as IFillableShape).FillColor = btn.BackColor;
            });
            ReDraw();
        }

        private void btnForeColor_BackColorChanged(object sender, EventArgs e)
        {
            var btn = sender as Button;
            statusBar_ForeColor.BackColor = btn.BackColor;
            ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Color = btn.BackColor; });
            ReDraw();
        }

        private void btnBackColor_BackColorChanged(object sender, EventArgs e)
        {
            var btn = sender as Button;
            statusBar_BackColor.BackColor = btn.BackColor;
            psfMain.BackColor = btn.BackColor;
        }
        #endregion

        #region psfMain's event
        private void psfMain_DoubleClick(object sender, EventArgs e)
        {
            if (drawingStage == DrawingStage.IsDrawPolygon)
            {
                drawingStage = DrawingStage.Orther;
                cPolygon polygon = ListShapes[ListShapes.Count - 1] as cPolygon;
                polygon.Points.RemoveAt(polygon.Points.Count - 1);

                psfMain.Invalidate();
                polygon.FindRegion();
            }
            else if (drawingStage == DrawingStage.IsDrawCurve)
            {
                drawingStage = DrawingStage.Orther;
                cCurve curve = ListShapes[ListShapes.Count - 1] as cCurve;
                if (curve.Points.Count <= 3) { ListShapes.Remove(curve); }
                curve.Points.RemoveAt(curve.Points.Count - 1);
                curve.Points.RemoveAt(curve.Points.Count - 1);

                psfMain.Invalidate();
                curve.FindRegion();
            }
        }

        private void psfMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < ListShapes.Count; i++)
                {
                    if (ListShapes[i].IsHit(e.Location))
                    {
                        ListShapes[i].IsSelected = true;

                        if (!(ListShapes[i] is cGroup))
                        {
                            nudLineWeight.Value = (decimal)ListShapes[i].LineWeight;
                            cboDashStyle.SelectedIndex = (int)ListShapes[i].DashStyle;
                            btnForeColor.BackColor = ListShapes[i].Color;

                            if (ListShapes[i] is IFillableShape fillableShape)
                            {
                                if (btnEnableFill.ToggleStage != fillableShape.IsFill)
                                {
                                    btnEnableFill.PerformClick();
                                }
                                btnFillColor.BackColor = fillableShape.FillColor;
                            }
                        }

                        ReDraw();
                        return;
                    }
                }
            }

            if (ShapeType != ShapeType.NoDrawing)
            {
                isMouseDown = true;
                ListShapes.ForEach(shape => shape.IsSelected = false);
            }

            switch (this.ShapeType)
            {
                case ShapeType.NoDrawing:
                    if (isControlKeyPress)
                    {
                        for (int i = 0; i < ListShapes.Count; i++)
                        {
                            if (ListShapes[i].IsHit(e.Location))
                            {
                                ListShapes[i].IsSelected = !ListShapes[i].IsSelected;
                                ReDraw();
                                break;
                            }
                        }
                    }
                    else
                    {
                        var isHitSelectedShape = false;
                        var listShapeSelected = ListShapes.FindAll(shape => shape.IsSelected);

                        for (int i = 0; i < listShapeSelected.Count; i++)
                        {
                            if (listShapeSelected[i].IsHit(e.Location))
                            {
                                isHitSelectedShape = true;
                                break;
                            }
                        }

                        if (!isHitSelectedShape)
                        {
                            UnselectAllShapes();
                        }

                        for (int i = 0; i < ListShapes.Count; i++)
                        {
                            if (ListShapes[i].IsHit(e.Location))
                            {
                                selectedShape = ListShapes[i];
                                ListShapes[i].IsSelected = true;

                                if (!(ListShapes[i] is cGroup))
                                {
                                    nudLineWeight.Value = (decimal)ListShapes[i].LineWeight;
                                    cboDashStyle.SelectedIndex = (int)ListShapes[i].DashStyle;
                                    btnForeColor.BackColor = ListShapes[i].Color;

                                    if (ListShapes[i] is IFillableShape fillableShape)
                                    {
                                        if (btnEnableFill.ToggleStage != fillableShape.IsFill)
                                        {
                                            btnEnableFill.PerformClick();
                                        }
                                        btnFillColor.BackColor = fillableShape.FillColor;
                                    }
                                }

                                ReDraw();
                                break;
                            }
                        }

                        if (selectedShape != null)
                        {
                            drawingStage = DrawingStage.IsMovingShape;
                            previousPoint = e.Location;
                        }
                        else
                        {
                            drawingStage = DrawingStage.IsMouseSelect;
                            selectedPoint1 = e.Location;
                            selectedPoint2 = new PointF();
                        }
                    }
                    break;

                case ShapeType.Text:
                    var text = fTextEditor.Show(this, e.Location, (float)nudLineWeight.Value);
                    if (text != null)
                    {
                        ListShapes.Add(text);
                        shapeLayers.Add(text);
                        ReDraw();
                    }
                    isMouseDown = false;
                    break;

                case ShapeType.Freehand:
                    if (drawingStage != DrawingStage.IsFreehand)
                    {
                        cFreehand freehand = new cFreehand((float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                        freehand.Begin = e.Location;
                        freehand.Points.Add(e.Location);

                        ListShapes.Add(freehand);
                        drawingStage = DrawingStage.IsFreehand;
                    }
                    else
                    {
                        cFreehand freehand = ListShapes[ListShapes.Count - 1] as cFreehand;
                        freehand.Points[freehand.Points.Count - 1] = e.Location;
                        freehand.Points.Add(e.Location);
                    }
                    break;

                case ShapeType.Line:
                    cLine line = new cLine(e.Location, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                    ListShapes.Add(line);
                    break;

                case ShapeType.Rectangle:
                    cRectangle rectangle = new cRectangle(e.Location, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                    if (DrawingMode == DrawingMode.Fill)
                    {
                        rectangle.IsFill = true;
                        rectangle.FillColor = btnFillColor.BackColor;
                    }
                    ListShapes.Add(rectangle);
                    break;

                case ShapeType.Square:
                    cSquare square = new cSquare(e.Location, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                    if (DrawingMode == DrawingMode.Fill)
                    {
                        square.IsFill = true;
                        square.FillColor = btnFillColor.BackColor;
                    }
                    ListShapes.Add(square);
                    break;

                case ShapeType.Ellipse:
                    cEllipse ellipse = new cEllipse(e.Location, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                    if (DrawingMode == DrawingMode.Fill)
                    {
                        ellipse.IsFill = true;
                        ellipse.FillColor = btnFillColor.BackColor;
                    }
                    ListShapes.Add(ellipse);
                    break;

                case ShapeType.Circle:
                    cCircle circle = new cCircle(e.Location, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                    if (DrawingMode == DrawingMode.Fill)
                    {
                        circle.IsFill = true;
                        circle.FillColor = btnFillColor.BackColor;
                    }
                    ListShapes.Add(circle);
                    break;

                case ShapeType.Curve:
                    if (drawingStage != DrawingStage.IsDrawCurve)
                    {
                        cCurve curve = new cCurve(false, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                        curve.Points.Add(e.Location);
                        curve.Points.Add(e.Location);

                        ListShapes.Add(curve);
                        drawingStage = DrawingStage.IsDrawCurve;
                    }
                    else
                    {
                        cCurve curve = ListShapes[ListShapes.Count - 1] as cCurve;
                        curve.Points[curve.Points.Count - 1] = e.Location;

                        curve.Points.Add(e.Location);
                    }
                    isMouseDown = false;
                    break;

                case ShapeType.Bezier:
                    if (drawingStage != DrawingStage.IsDrawBezier)
                    {
                        cCurve bezier = new cCurve(true, (float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                        bezier.Points.Add(e.Location);
                        bezier.Points.Add(e.Location);

                        ListShapes.Add(bezier);
                        drawingStage = DrawingStage.IsDrawBezier;
                    }
                    else
                    {
                        cCurve bezier = ListShapes[ListShapes.Count - 1] as cCurve;
                        if (bezier.Points.Count < 4)
                        {
                            bezier.Points[bezier.Points.Count - 1] = e.Location;
                            bezier.Points.Add(e.Location);
                        }
                        else
                        {
                            drawingStage = DrawingStage.Orther;
                            bezier.FindRegion();
                        }
                    }
                    isMouseDown = false;
                    break;

                case ShapeType.Polygon:
                    if (drawingStage != DrawingStage.IsDrawPolygon)
                    {
                        cPolygon polygon = new cPolygon((float)nudLineWeight.Value, btnForeColor.BackColor, (DashStyle)cboDashStyle.SelectedIndex);
                        if (DrawingMode == DrawingMode.Fill)
                        {
                            polygon.IsFill = true;
                            polygon.FillColor = btnFillColor.BackColor;
                        }
                        polygon.Points.Add(e.Location);
                        polygon.Points.Add(e.Location);

                        ListShapes.Add(polygon);
                        drawingStage = DrawingStage.IsDrawPolygon;
                    }
                    else
                    {
                        cPolygon polygon = ListShapes[ListShapes.Count - 1] as cPolygon;
                        polygon.Points[polygon.Points.Count - 1] = e.Location;
                        polygon.Points.Add(e.Location);
                    }

                    isMouseDown = false;
                    break;
                default:
                    break;

            }
        }

        private void psfMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingStage == DrawingStage.IsFreehand)
            {
                cFreehand freehand = ListShapes[ListShapes.Count - 1] as cFreehand;
                freehand.Points.Add(e.Location);
                ReDraw();
            }

            if (isMouseDown)
            {
                cShape lastShape = ListShapes[ListShapes.Count - 1];
                if (isShiftKeyPress)
                {
                    if (lastShape is cRectangle) { (lastShape as cRectangle).IsSquare = true; }
                    else if (lastShape is cEllipse) { (lastShape as cEllipse).IsCircle = true; }
                }
                else
                {
                    if (lastShape is cRectangle) { (lastShape as cRectangle).IsSquare = false; }
                    else if (lastShape is cEllipse) { (lastShape as cEllipse).IsCircle = false; }
                }
                lastShape.End = e.Location;
                ReDraw();
            }
            else if (drawingStage == DrawingStage.IsMovingShape)
            {
                PointF d = new PointF(e.X - previousPoint.X, e.Y - previousPoint.Y);
                ListShapes.FindAll(shape => shape.IsSelected).ForEach(shape => { shape.Move(d); });
                previousPoint = e.Location;
                ReDraw();
            }
            else if (ShapeType == ShapeType.NoDrawing)
            {
                if (drawingStage == DrawingStage.IsMouseSelect)
                {
                    selectedPoint2 = e.Location;
                    ReDraw();
                }
                else
                {
                    if (ListShapes.Exists(shape => shape.IsHit(e.Location)))
                    {
                        psfMain.Cursor = MyCursor.Instance.SizeAll;
                    }
                    else
                    {
                        psfMain.Cursor = Cursors.Default;
                    }
                }
            }

            else if (drawingStage == DrawingStage.IsDrawPolygon)
            {
                cPolygon polygon = ListShapes[ListShapes.Count - 1] as cPolygon;
                polygon.Points[polygon.Points.Count - 1] = e.Location;

                ReDraw();
            }
            else if (drawingStage == DrawingStage.IsDrawCurve)
            {
                cCurve curve = ListShapes[ListShapes.Count - 1] as cCurve;
                curve.Points[curve.Points.Count - 1] = e.Location;

                ReDraw();
            }
            else if (drawingStage == DrawingStage.IsDrawBezier)
            {
                cCurve bezier = ListShapes[ListShapes.Count - 1] as cCurve;
                bezier.Points[bezier.Points.Count - 1] = e.Location;

                ReDraw();
            }
        }

        private void psfMain_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (drawingStage == DrawingStage.IsFreehand)
            {
                drawingStage = DrawingStage.Orther;
                cFreehand freehand = ListShapes[ListShapes.Count - 1] as cFreehand;
                freehand.End = freehand.Points[freehand.Points.Count - 1];
                psfMain.Invalidate();
            }
            else if (drawingStage == DrawingStage.IsMovingShape)
            {
                drawingStage = DrawingStage.Orther;
                selectedShape = null;
            }
            else if (drawingStage == DrawingStage.IsMouseSelect)
            {
                drawingStage = DrawingStage.Orther;
                for (int i = 0; i < ListShapes.Count; i++)
                {
                    ListShapes[i].IsSelected = false;

                    if (ListShapes[i].Begin.X >= SelectedRegion.X &&
                        ListShapes[i].End.X <= SelectedRegion.X + SelectedRegion.Width &&
                        ListShapes[i].Begin.Y >= SelectedRegion.Y &&
                        ListShapes[i].End.Y <= SelectedRegion.Y + SelectedRegion.Height)
                    {
                        ListShapes[i].IsSelected = true;
                    }
                }
                ReDraw();
            }

            try
            {
                cShape shape = ListShapes[ListShapes.Count - 1];

                // Đổi 2 điểm lại cho thuận nếu bị ngược
                if (shape.Begin.X > shape.End.X || (shape.Begin.X == shape.End.X && shape.Begin.Y > shape.End.Y))
                {
                    PointF temp = shape.Begin;
                    shape.Begin = shape.End;
                    shape.End = temp;
                }

                if (shape is cCircle circle)
                {
                    circle.End = new PointF(circle.Begin.X + circle.Diameter, circle.Begin.Y + circle.Diameter);
                }
                else if (shape is cSquare square)
                {
                    if (square.Begin.X < square.End.X && square.Begin.Y > square.End.Y)
                    {
                        square.Begin = new PointF(square.Begin.X, square.End.Y);
                        square.End = new PointF(square.Begin.X + square.Width, square.Begin.Y + square.Width);
                    }
                    else
                    {
                        square.End = new PointF(square.Begin.X + square.Width, square.Begin.Y + square.Width);
                    }
                }
                else if (shape is cRectangle rect)
                {
                    if (rect.Begin.X < rect.End.X && rect.Begin.Y > rect.End.Y)
                    {
                        PointF begin = rect.Begin, end = rect.End;

                        rect.Begin = new PointF(begin.X, end.Y);
                        rect.End = new PointF(end.X, begin.Y);
                    }
                }

                if (ShapeType != ShapeType.NoDrawing)
                {
                    if (shape is cCurve)
                    {
                        // Chỉ ghi khi đã vẽ xong đường cong đó
                        if ((ShapeType == ShapeType.Curve && drawingStage != DrawingStage.IsDrawCurve) ||
                            (ShapeType == ShapeType.Bezier && drawingStage != DrawingStage.IsDrawBezier))
                        {
                            shapeLayers.Add(shape);
                        }
                    }
                    else if (shape is cPolygon) // ngược lại nếu là đa giác
                    {
                        // thì cũng đợi vẽ xong mới ghi thông tin
                        if (drawingStage != DrawingStage.IsDrawPolygon) { shapeLayers.Add(shape); }
                    }
                    // ngược lại không là đường cong thì ghi bình thường
                    else {
                        if (shape is cFreehand freehand) { freehand.FindRegion(); }
                        shapeLayers.Add(shape); 
                    }
                }
            }
            catch { }
        }

        private void psfMain_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            ListShapes.ForEach(shape =>
            {
                if (shape.IsSelected)
                {
                    shape.Draw(e.Graphics);

                    if (!(shape is cLine))
                    {
                        e.Graphics.DrawRectangle(framePen, new RectangleF(shape.Begin.X, shape.Begin.Y, shape.End.X - shape.Begin.X, shape.End.Y - shape.Begin.Y));
                    }

                    if (shape is cEllipse || shape is cRectangle || shape is cLine || shape is cFreehand)
                    {
                        e.Graphics.FillEllipse(brush, new RectangleF(shape.Begin.X - 4, shape.Begin.Y - 4, 8, 8));
                        e.Graphics.FillEllipse(brush, new RectangleF(shape.End.X - 4, shape.End.Y - 4, 8, 8));
                        if (shape is cEllipse elip)
                        {
                            e.Graphics.FillEllipse(brush, new RectangleF(elip.TopRight.X - 4, elip.TopRight.Y - 4, 8, 8));
                            e.Graphics.FillEllipse(brush, new RectangleF(elip.BottomLeft.X - 4, elip.BottomLeft.Y - 4, 8, 8));
                        }
                        else if (shape is cRectangle rec)
                        {
                            e.Graphics.FillEllipse(brush, new RectangleF(rec.TopRight.X - 4, rec.TopRight.Y - 4, 8, 8));
                            e.Graphics.FillEllipse(brush, new RectangleF(rec.BottomLeft.X - 4, rec.BottomLeft.Y - 4, 8, 8));
                        }
                    }
                    else if (shape is cCurve curve)
                    {
                        for (int i = 0; i < curve.Points.Count; i++)
                        {
                            e.Graphics.FillEllipse(brush, new RectangleF(curve.Points[i].X - 4, curve.Points[i].Y - 4, 8, 8));
                        }
                    }
                    else if (shape is cPolygon polygon)
                    {
                        for (int i = 0; i < polygon.Points.Count; i++)
                        {
                            e.Graphics.FillEllipse(brush, new RectangleF(polygon.Points[i].X - 4, polygon.Points[i].Y - 4, 8, 8));
                        }
                    }
                }
                else if (!shape.IsHidden)
                {
                    shape.Draw(e.Graphics);
                }
            });

            if (drawingStage == DrawingStage.IsMouseSelect)
            {
                e.Graphics.DrawRectangle(framePen, SelectedRegion);
            }
        }
        #endregion

        private void btnText_Click(object sender, EventArgs e)
        {
            if (ListShapes.FindAll(shape => shape.IsSelected && shape is cText).Count > 0)
            {
                fTextEditor.Show(this, ListShapes);
                ReDraw();
            }
            else { btnShape_Click(sender, e); }
        }

        private void btnShape_Click(object sender, EventArgs e)
        {
            UnselectAllShapes();
            Button btn = sender as Button;

            if (btn.BackColor == Color.FromArgb(0, 30, 81))
            {
                UncheckAll();
                this.ShapeType = ShapeType.NoDrawing;
                this.btnSelect.BackColor = Color.FromArgb(0, 30, 81);
                this.psfMain.Cursor = Cursors.Default;
            }
            else
            {
                UncheckAll();
                btn.BackColor = Color.FromArgb(0, 30, 81);
                btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                this.psfMain.Cursor = MyCursor.Instance.Cross;

                switch (btn.Tag)
                {
                    case "Freehand":
                        this.ShapeType = ShapeType.Freehand;
                        break;
                    case "Text":
                        this.ShapeType = ShapeType.Text;
                        break;
                    case "Line":
                        this.ShapeType = ShapeType.Line;
                        break;
                    case "Curve":
                        this.ShapeType = ShapeType.Curve;
                        break;
                    case "Bezier":
                        this.ShapeType = ShapeType.Bezier;
                        break;
                    case "Ellipse":
                        this.ShapeType = ShapeType.Ellipse;
                        break;
                    case "Circle":
                        this.ShapeType = ShapeType.Circle;
                        break;
                    case "Rectangle":
                        this.ShapeType = ShapeType.Rectangle;
                        break;
                    case "Square":
                        this.ShapeType = ShapeType.Square;
                        break;
                    case "Polygon":
                        this.ShapeType = ShapeType.Polygon;
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnEllipse_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = sender as Button;
                if (btn.Tag.ToString() == "Ellipse")
                {
                    btn.Tag = "Circle";
                    if (DrawingMode == DrawingMode.NoFill) { btn.BackgroundImage = Properties.Resources.shape_circle_outline_white; }
                    else { btn.BackgroundImage = Properties.Resources.shape_circle_white; }
                }
                else
                {
                    btn.Tag = "Ellipse";
                    if (DrawingMode == DrawingMode.NoFill) { btn.BackgroundImage = Properties.Resources.shape_ellipse_outline_white; }
                    else { btn.BackgroundImage = Properties.Resources.shape_ellipse_white; }
                }
                btn.PerformClick();
                btn.PerformClick();
            }
        }

        private void btnRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = sender as Button;
                if (btn.Tag.ToString() == "Rectangle")
                {
                    btn.Tag = "Square";
                    if (DrawingMode == DrawingMode.NoFill) { btn.BackgroundImage = Properties.Resources.shape_square_outline_white; }
                    else { btn.BackgroundImage = Properties.Resources.shape_square_white; }
                }
                else
                {
                    btn.Tag = "Rectangle";
                    if (DrawingMode == DrawingMode.NoFill) { btn.BackgroundImage = Properties.Resources.shape_rectangle_outline_white; }
                    else { btn.BackgroundImage = Properties.Resources.shape_rectangle_white; }
                }
                btn.PerformClick();
                btn.PerformClick();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            UnselectAllShapes();
            this.ShapeType = ShapeType.NoDrawing;
            UncheckAll();
            (sender as Button).BackColor = Color.FromArgb(0, 30, 81);
            this.psfMain.Cursor = Cursors.Default;
        }

        private void btnGroup_Click(object sender, EventArgs e) { GroupSelectedShape(); }

        private void btnUngroup_Click(object sender, EventArgs e) { UngroupSelectedGroup(); }

        private void btnDelete_Click(object sender, EventArgs e) { DeleteSelectedShape(); }

        #region Menustrip event

        #region Menu File
        private void mnuFile_Open_Click(object sender, EventArgs e)
        {
            string openFilePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Kdrawing project | *.kdr";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.ListShapes.Count == 0)
                {
                    this.filePath = openFileDialog.FileName;
                    this.OnLoad(null);
                }
                else
                {
                    openFilePath = openFileDialog.FileName;
                    fMain fMain = new fMain();
                    fMain.filePath = openFilePath;
                    fMain.Show();
                }
            }
        }
        
        private void mnuFile_New_Click(object sender, EventArgs e)
        {
            fMain fMain = new fMain();
            fMain.Show();
        }

        private void mnuFile_Save_Click(object sender, EventArgs e)
        {
            if (this.filePath == null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Kdrawing project | *.kdr|" +
                                            "PNG Picture | *.png|" +
                                            "JPEG Picture | *.jpg *.jpeg *.jpe *.jfif|" +
                                            "BMP Picture | *.bmp|" +
                                            "GIF Picture | *.gif|" +
                                            "TIFF Picture | *.tif *.tiff";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var extension = System.IO.Path.GetExtension(saveFileDialog.FileName);

                        if (extension.ToLower() == ".kdr") 
                        {
                            this.filePath = saveFileDialog.FileName; 
                        }
                        else
                        {
                            Bitmap myBitmap = Utilities.CreateBimap(psfMain.Width, psfMain.Height, psfMain.BackColor, ListShapes);

                            switch (extension.ToLower())
                            {
                                case ".png":
                                    myBitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                                    break;

                                case ".jpeg":
                                case ".jpg":
                                case ".jpe":
                                case ".jfif":
                                    myBitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                                    break;

                                case ".bmp":
                                    myBitmap.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                                    break;

                                case ".gif":
                                    myBitmap.Save(saveFileDialog.FileName, ImageFormat.Gif);
                                    break;

                                case ".tif":
                                case ".tiff":
                                    myBitmap.Save(saveFileDialog.FileName, ImageFormat.Tiff);
                                    break;
                            }
                        }
                    }
                }
            }

            if (this.filePath != null)
            {
                ShapeData shapeData = new ShapeData()
                {
                    BackColor = psfMain.BackColor,
                    ListShapes = this.ListShapes
                };
                ShapeData.Serialize(shapeData, this.filePath);
            }
        }

        private void mnuFile_SaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Kdrawing project | *.kdr|" +
                                        "PNG Picture | *.png|" +
                                        "JPEG Picture | *.jpg;*.jpeg;*.jpe;*.jfif|" +
                                        "BMP Picture | *.bmp|" +
                                        "GIF Picture | *.gif|" +
                                        "TIFF Picture | *.tif;*.tiff";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var extension = System.IO.Path.GetExtension(saveFileDialog.FileName);

                    if (extension.ToLower() == ".kdr") { this.filePath = saveFileDialog.FileName; }
                    else
                    {
                        Bitmap myBitmap = Utilities.CreateBimap(psfMain.Width, psfMain.Height, psfMain.BackColor, ListShapes);

                        switch (extension.ToLower())
                        {
                            case ".png":
                                myBitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                                break;

                            case ".jpeg":
                            case ".jpg":
                            case ".jpe":
                            case ".jfif":
                                myBitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                                break;

                            case ".bmp":
                                myBitmap.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                                break;

                            case ".gif":
                                myBitmap.Save(saveFileDialog.FileName, ImageFormat.Gif);
                                break;

                            case ".tif":
                            case ".tiff":
                                myBitmap.Save(saveFileDialog.FileName, ImageFormat.Tiff);
                                break;
                        }
                    }
                }
            }
        }

        private void mnuFile_Quit_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        #region Menu Edit
        private void mnuEdit_Fill_Click(object sender, EventArgs e) { btnEnableFill.PerformClick(); }

        private void mnuEdit_LineWeight_Click(object sender, EventArgs e) { }

        private void mnuEdit_DashStyle_Click(object sender, EventArgs e) { }

        private void mnuEdit_ForeColor_Click(object sender, EventArgs e) { btnForeColor.PerformClick(); }

        private void mnuEdit_BackColor_Click(object sender, EventArgs e) { btnBackColor.PerformClick(); }

        private void mnuEdit_SwapColor_Click(object sender, EventArgs e) { btnSwapColor.PerformClick(); }

        private void mnuEdit_DefaultColor_Click(object sender, EventArgs e) { btnDefaultColor.PerformClick(); }
        #endregion

        #region Menu select
        private void mnuSelect_Select_Click(object sender, EventArgs e) { btnSelect.PerformClick(); }

        private void mnuSelect_Deselected_Click(object sender, EventArgs e)
        {
            ListShapes.FindAll(sh => sh.IsHidden == false).ForEach(shape => shape.IsSelected = false);
            ReDraw();
        }

        private void mnuSelect_SelectAll_Click(object sender, EventArgs e)
        {
            ListShapes.FindAll(sh => sh.IsHidden == false).ForEach(shape => shape.IsSelected = true);
            ReDraw();
        }

        private void mnuSelect_Group_Click(object sender, EventArgs e) { GroupSelectedShape(); }

        private void mnuSelect_Ungroup_Click(object sender, EventArgs e) { UngroupSelectedGroup(); }

        private void mnuSelect_Scale_Click(object sender, EventArgs e) { ScaleShapes(); }

        private void mnuSelect_Rotate_Click(object sender, EventArgs e) { RotateShapes(); }

        private void mnuSelect_DeleteSelected_Click(object sender, EventArgs e) { DeleteSelectedShape(); }
        #endregion

        #region Menu Drawing
        private void mnuDrawing_Freehand_Click(object sender, EventArgs e) { btnPencil.PerformClick(); }

        private void mnuDrawing_Text_Click(object sender, EventArgs e) { btnText.PerformClick(); }

        private void mnuDrawing_Line_Click(object sender, EventArgs e) { btnLine.PerformClick(); }

        private void mnuDrawing_Curve_Click(object sender, EventArgs e) { btnCurve.PerformClick(); }

        private void mnuDrawing_Bezier_Click(object sender, EventArgs e) { btnBezier.PerformClick(); }

        private void mnuDrawing_Ellipse_Click(object sender, EventArgs e) { btnEllipse.PerformClick(); }

        private void mnuDrawing_Rectangle_Click(object sender, EventArgs e) { btnRectangle.PerformClick(); }

        private void mnuDrawing_Polygon_Click(object sender, EventArgs e) { btnPolygon.PerformClick(); }
        #endregion

        private void mnuView_Toolbar_Click(object sender, EventArgs e) { btnCloseToolbar.PerformClick(); }

        private void mnuView_Layers_Click(object sender, EventArgs e) { btnCloseLayer.PerformClick(); }

        private void mnuAbout_Click(object sender, EventArgs e) { fAbout.Show(this); }
        #endregion

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            int numShapeSelected = ListShapes.FindAll(shape => shape.IsSelected).Count;
            int numShapes = ListShapes.Count;
            statusBar_NumShapesSelected.Text = "Selected " + numShapeSelected.ToString() + "/" + numShapes.ToString() + " shapes";
            shapeLayers.Update(numShapeSelected, numShapes);
        }
        #endregion

        #region Methods
        #region Public methods

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
                float percent = fScale.Show(this, 1f);
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
                int degree = fRotate.Show(this, 0);
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

        #region Private methods
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

        #endregion
    }
}