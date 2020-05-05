namespace KDrawing
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tblpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.titleBar = new KDrawing.KControls.TitleBar();
            this.dragMovePnl = new KDrawing.KControls.DragMovePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.nudLineWeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnableFill = new KDrawing.KControls.ToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragMovePanel1 = new KDrawing.KControls.DragMovePanel();
            this.btnCloseLayer = new KDrawing.KControls.ToggleButton();
            this.btnCloseToolbar = new KDrawing.KControls.ToggleButton();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFile_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Fill = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_LineWeight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_DashStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEdit_ForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_BackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_SwapColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_DefaultColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect_Select = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect_Deselected = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelect_Group = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect_Ungroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelect_Scale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect_Rotate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelect_DeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawing = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawing_Freehand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawing_Text = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDrawing_Line = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawing_Curve = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawing_Bezier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawing_Ellipse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawing_Rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawing_Polygon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_Toolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_Layers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tblpnlMidArea = new System.Windows.Forms.TableLayoutPanel();
            this.shapeLayers = new KDrawing.MyUserControls.ShapeLayersManager();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnForeColor = new KDrawing.KControls.FlatButton();
            this.btnBackColor = new KDrawing.KControls.FlatButton();
            this.btnDefaultColor = new KDrawing.KControls.FlatButton();
            this.btnPolygon = new KDrawing.KControls.FlatButton();
            this.btnRectangle = new KDrawing.KControls.FlatButton();
            this.btnEllipse = new KDrawing.KControls.FlatButton();
            this.btnBezier = new KDrawing.KControls.FlatButton();
            this.btnCurve = new KDrawing.KControls.FlatButton();
            this.btnLine = new KDrawing.KControls.FlatButton();
            this.btnText = new KDrawing.KControls.FlatButton();
            this.btnPencil = new KDrawing.KControls.FlatButton();
            this.btnDelete = new KDrawing.KControls.FlatButton();
            this.btnUngroup = new KDrawing.KControls.FlatButton();
            this.btnGroup = new KDrawing.KControls.FlatButton();
            this.btnSelect = new KDrawing.KControls.FlatButton();
            this.btnSwapColor = new KDrawing.KControls.FlatButton();
            this.psfMain = new KDrawing.KControls.PaintSurface();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBar_DrawingMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_LineWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_DashStyle = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_LabelForeColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_ForeColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_LabelBackColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_BackColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_ShapeType = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_NumShapesSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.imgCboDashStyle = new System.Windows.Forms.ImageList(this.components);
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tblpnlMain.SuspendLayout();
            this.dragMovePnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dragMovePanel1.SuspendLayout();
            this.mnu.SuspendLayout();
            this.tblpnlMidArea.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnlMain
            // 
            this.tblpnlMain.ColumnCount = 1;
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMain.Controls.Add(this.titleBar, 0, 0);
            this.tblpnlMain.Controls.Add(this.dragMovePnl, 0, 1);
            this.tblpnlMain.Controls.Add(this.tblpnlMidArea, 0, 2);
            this.tblpnlMain.Controls.Add(this.statusBar, 0, 3);
            this.tblpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tblpnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnlMain.Name = "tblpnlMain";
            this.tblpnlMain.RowCount = 4;
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMain.Size = new System.Drawing.Size(1582, 853);
            this.tblpnlMain.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar.ButtonForeColor = KDrawing.KControls.TitleBar.ButtonColor.White;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.Location = new System.Drawing.Point(2, 2);
            this.titleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ResizeWindowsBox = KDrawing.KControls.TitleBar.ResizeBox.MinimizeAndMaximize;
            this.titleBar.Size = new System.Drawing.Size(1578, 34);
            this.titleBar.TabIndex = 0;
            this.titleBar.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.TitleForeColor = System.Drawing.Color.White;
            this.titleBar.TitleIcon = null;
            this.titleBar.TitleText = "KDrawing";
            // 
            // dragMovePnl
            // 
            this.dragMovePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dragMovePnl.Controls.Add(this.panel1);
            this.dragMovePnl.Controls.Add(this.dragMovePanel1);
            this.dragMovePnl.Controls.Add(this.btnCloseToolbar);
            this.dragMovePnl.Controls.Add(this.mnu);
            this.dragMovePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dragMovePnl.Location = new System.Drawing.Point(2, 36);
            this.dragMovePnl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.dragMovePnl.Name = "dragMovePnl";
            this.dragMovePnl.Size = new System.Drawing.Size(1578, 34);
            this.dragMovePnl.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.cboDashStyle);
            this.panel1.Controls.Add(this.nudLineWeight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEnableFill);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(613, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 34);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(16, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2, 20);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // cboDashStyle
            // 
            this.cboDashStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDashStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDashStyle.FormattingEnabled = true;
            this.cboDashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash Dot",
            "Dash Dot Dot"});
            this.cboDashStyle.Location = new System.Drawing.Point(455, 3);
            this.cboDashStyle.Name = "cboDashStyle";
            this.cboDashStyle.Size = new System.Drawing.Size(200, 28);
            this.cboDashStyle.TabIndex = 2;
            this.cboDashStyle.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboDashStyle_DrawItem);
            this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.cboDashStyle_SelectedIndexChanged);
            // 
            // nudLineWeight
            // 
            this.nudLineWeight.DecimalPlaces = 2;
            this.nudLineWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLineWeight.Location = new System.Drawing.Point(236, 4);
            this.nudLineWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWeight.Name = "nudLineWeight";
            this.nudLineWeight.Size = new System.Drawing.Size(79, 27);
            this.nudLineWeight.TabIndex = 2;
            this.nudLineWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLineWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWeight.ValueChanged += new System.EventHandler(this.nudLineWeight_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(371, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dash style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Line weight";
            // 
            // btnEnableFill
            // 
            this.btnEnableFill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnableFill.BackgroundImage")));
            this.btnEnableFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnableFill.FlatAppearance.BorderSize = 0;
            this.btnEnableFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEnableFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEnableFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableFill.Location = new System.Drawing.Point(66, 5);
            this.btnEnableFill.Name = "btnEnableFill";
            this.btnEnableFill.Size = new System.Drawing.Size(48, 24);
            this.btnEnableFill.TabIndex = 0;
            this.btnEnableFill.ToggleButtonStyle = KDrawing.KControls.ToggleButton.Style.ToggleButtonStyle3;
            this.btnEnableFill.ToggleStage = false;
            this.btnEnableFill.ToolTipActive = true;
            this.btnEnableFill.ToolTipAutomaticDelay = 500;
            this.btnEnableFill.ToolTipAutoPopDelay = 5000;
            this.btnEnableFill.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnEnableFill.ToolTipCaption = "";
            this.btnEnableFill.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEnableFill.ToolTipInitialDelay = 200;
            this.btnEnableFill.ToolTipIsBalloon = false;
            this.btnEnableFill.ToolTipReshowDelay = 100;
            this.btnEnableFill.ToolTipShowAlways = true;
            this.btnEnableFill.ToolTipTitle = "";
            this.btnEnableFill.UseVisualStyleBackColor = true;
            this.btnEnableFill.Click += new System.EventHandler(this.btnEnableFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fill";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(125, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 20);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(321, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "pt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(355, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 20);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dragMovePanel1
            // 
            this.dragMovePanel1.Controls.Add(this.btnCloseLayer);
            this.dragMovePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dragMovePanel1.Location = new System.Drawing.Point(1278, 0);
            this.dragMovePanel1.Name = "dragMovePanel1";
            this.dragMovePanel1.Size = new System.Drawing.Size(300, 34);
            this.dragMovePanel1.TabIndex = 2;
            // 
            // btnCloseLayer
            // 
            this.btnCloseLayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseLayer.BackgroundImage")));
            this.btnCloseLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseLayer.FlatAppearance.BorderSize = 0;
            this.btnCloseLayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCloseLayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCloseLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLayer.Location = new System.Drawing.Point(0, 2);
            this.btnCloseLayer.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseLayer.Name = "btnCloseLayer";
            this.btnCloseLayer.Size = new System.Drawing.Size(56, 30);
            this.btnCloseLayer.TabIndex = 2;
            this.btnCloseLayer.ToggleButtonStyle = KDrawing.KControls.ToggleButton.Style.ToggleButtonStyle2;
            this.btnCloseLayer.ToggleStage = true;
            this.btnCloseLayer.ToolTipActive = true;
            this.btnCloseLayer.ToolTipAutomaticDelay = 500;
            this.btnCloseLayer.ToolTipAutoPopDelay = 5000;
            this.btnCloseLayer.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnCloseLayer.ToolTipCaption = "Close tool bar";
            this.btnCloseLayer.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCloseLayer.ToolTipInitialDelay = 200;
            this.btnCloseLayer.ToolTipIsBalloon = false;
            this.btnCloseLayer.ToolTipReshowDelay = 100;
            this.btnCloseLayer.ToolTipShowAlways = true;
            this.btnCloseLayer.ToolTipTitle = "";
            this.btnCloseLayer.UseVisualStyleBackColor = true;
            this.btnCloseLayer.Click += new System.EventHandler(this.btnCloseLayer_Click);
            // 
            // btnCloseToolbar
            // 
            this.btnCloseToolbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseToolbar.BackgroundImage")));
            this.btnCloseToolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseToolbar.FlatAppearance.BorderSize = 0;
            this.btnCloseToolbar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCloseToolbar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCloseToolbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseToolbar.Location = new System.Drawing.Point(2, 2);
            this.btnCloseToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseToolbar.Name = "btnCloseToolbar";
            this.btnCloseToolbar.Size = new System.Drawing.Size(56, 30);
            this.btnCloseToolbar.TabIndex = 1;
            this.btnCloseToolbar.ToggleButtonStyle = KDrawing.KControls.ToggleButton.Style.ToggleButtonStyle1;
            this.btnCloseToolbar.ToggleStage = true;
            this.btnCloseToolbar.ToolTipActive = true;
            this.btnCloseToolbar.ToolTipAutomaticDelay = 500;
            this.btnCloseToolbar.ToolTipAutoPopDelay = 5000;
            this.btnCloseToolbar.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnCloseToolbar.ToolTipCaption = "Close tool bar";
            this.btnCloseToolbar.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCloseToolbar.ToolTipInitialDelay = 200;
            this.btnCloseToolbar.ToolTipIsBalloon = false;
            this.btnCloseToolbar.ToolTipReshowDelay = 100;
            this.btnCloseToolbar.ToolTipShowAlways = true;
            this.btnCloseToolbar.ToolTipTitle = "";
            this.btnCloseToolbar.UseVisualStyleBackColor = true;
            this.btnCloseToolbar.Click += new System.EventHandler(this.btnCloseToolbar_Click);
            // 
            // mnu
            // 
            this.mnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mnu.Dock = System.Windows.Forms.DockStyle.None;
            this.mnu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuSelect,
            this.mnuDrawing,
            this.mnuView,
            this.mnuAbout});
            this.mnu.Location = new System.Drawing.Point(60, 1);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(460, 31);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "mnu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_Open,
            this.mnuFile_New,
            this.toolStripSeparator4,
            this.mnuFile_Save,
            this.mnuFile_SaveAs,
            this.toolStripSeparator5,
            this.mnuFile_Quit});
            this.mnuFile.ForeColor = System.Drawing.Color.White;
            this.mnuFile.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(50, 27);
            this.mnuFile.Text = "File";
            // 
            // mnuFile_Open
            // 
            this.mnuFile_Open.Name = "mnuFile_Open";
            this.mnuFile_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFile_Open.Size = new System.Drawing.Size(256, 28);
            this.mnuFile_Open.Text = "Open";
            this.mnuFile_Open.Click += new System.EventHandler(this.mnuFile_Open_Click);
            // 
            // mnuFile_New
            // 
            this.mnuFile_New.Name = "mnuFile_New";
            this.mnuFile_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFile_New.Size = new System.Drawing.Size(256, 28);
            this.mnuFile_New.Text = "New";
            this.mnuFile_New.Click += new System.EventHandler(this.mnuFile_New_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(253, 6);
            // 
            // mnuFile_Save
            // 
            this.mnuFile_Save.Name = "mnuFile_Save";
            this.mnuFile_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFile_Save.Size = new System.Drawing.Size(256, 28);
            this.mnuFile_Save.Text = "Save";
            this.mnuFile_Save.Click += new System.EventHandler(this.mnuFile_Save_Click);
            // 
            // mnuFile_SaveAs
            // 
            this.mnuFile_SaveAs.Name = "mnuFile_SaveAs";
            this.mnuFile_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuFile_SaveAs.Size = new System.Drawing.Size(256, 28);
            this.mnuFile_SaveAs.Text = "Save as";
            this.mnuFile_SaveAs.Click += new System.EventHandler(this.mnuFile_SaveAs_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(253, 6);
            // 
            // mnuFile_Quit
            // 
            this.mnuFile_Quit.Name = "mnuFile_Quit";
            this.mnuFile_Quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFile_Quit.Size = new System.Drawing.Size(256, 28);
            this.mnuFile_Quit.Text = "Quit";
            this.mnuFile_Quit.Click += new System.EventHandler(this.mnuFile_Quit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit_Fill,
            this.mnuEdit_LineWeight,
            this.mnuEdit_DashStyle,
            this.toolStripSeparator6,
            this.mnuEdit_ForeColor,
            this.mnuEdit_BackColor,
            this.mnuEdit_SwapColor,
            this.mnuEdit_DefaultColor});
            this.mnuEdit.ForeColor = System.Drawing.Color.White;
            this.mnuEdit.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(53, 27);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuEdit_Fill
            // 
            this.mnuEdit_Fill.CheckOnClick = true;
            this.mnuEdit_Fill.Name = "mnuEdit_Fill";
            this.mnuEdit_Fill.Size = new System.Drawing.Size(242, 28);
            this.mnuEdit_Fill.Text = "Fill";
            this.mnuEdit_Fill.Click += new System.EventHandler(this.mnuEdit_Fill_Click);
            // 
            // mnuEdit_LineWeight
            // 
            this.mnuEdit_LineWeight.Name = "mnuEdit_LineWeight";
            this.mnuEdit_LineWeight.Size = new System.Drawing.Size(242, 28);
            this.mnuEdit_LineWeight.Text = "Line weight";
            this.mnuEdit_LineWeight.Click += new System.EventHandler(this.mnuEdit_LineWeight_Click);
            // 
            // mnuEdit_DashStyle
            // 
            this.mnuEdit_DashStyle.Name = "mnuEdit_DashStyle";
            this.mnuEdit_DashStyle.Size = new System.Drawing.Size(242, 28);
            this.mnuEdit_DashStyle.Text = "Dash style";
            this.mnuEdit_DashStyle.Click += new System.EventHandler(this.mnuEdit_DashStyle_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(239, 6);
            // 
            // mnuEdit_ForeColor
            // 
            this.mnuEdit_ForeColor.Name = "mnuEdit_ForeColor";
            this.mnuEdit_ForeColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.mnuEdit_ForeColor.Size = new System.Drawing.Size(242, 28);
            this.mnuEdit_ForeColor.Text = "Fore color";
            this.mnuEdit_ForeColor.Click += new System.EventHandler(this.mnuEdit_ForeColor_Click);
            // 
            // mnuEdit_BackColor
            // 
            this.mnuEdit_BackColor.Name = "mnuEdit_BackColor";
            this.mnuEdit_BackColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.mnuEdit_BackColor.Size = new System.Drawing.Size(242, 28);
            this.mnuEdit_BackColor.Text = "Back color";
            this.mnuEdit_BackColor.Click += new System.EventHandler(this.mnuEdit_BackColor_Click);
            // 
            // mnuEdit_SwapColor
            // 
            this.mnuEdit_SwapColor.Name = "mnuEdit_SwapColor";
            this.mnuEdit_SwapColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.mnuEdit_SwapColor.Size = new System.Drawing.Size(242, 28);
            this.mnuEdit_SwapColor.Text = "Swap color";
            this.mnuEdit_SwapColor.Click += new System.EventHandler(this.mnuEdit_SwapColor_Click);
            // 
            // mnuEdit_DefaultColor
            // 
            this.mnuEdit_DefaultColor.Name = "mnuEdit_DefaultColor";
            this.mnuEdit_DefaultColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.mnuEdit_DefaultColor.Size = new System.Drawing.Size(242, 28);
            this.mnuEdit_DefaultColor.Text = "Defaul color";
            this.mnuEdit_DefaultColor.Click += new System.EventHandler(this.mnuEdit_DefaultColor_Click);
            // 
            // mnuSelect
            // 
            this.mnuSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelect_Select,
            this.mnuSelect_Deselected,
            this.mnuSelect_SelectAll,
            this.toolStripSeparator1,
            this.mnuSelect_Group,
            this.mnuSelect_Ungroup,
            this.toolStripSeparator2,
            this.mnuSelect_Scale,
            this.mnuSelect_Rotate,
            this.toolStripSeparator3,
            this.mnuSelect_DeleteSelected});
            this.mnuSelect.ForeColor = System.Drawing.Color.White;
            this.mnuSelect.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(69, 27);
            this.mnuSelect.Text = "Select";
            // 
            // mnuSelect_Select
            // 
            this.mnuSelect_Select.Name = "mnuSelect_Select";
            this.mnuSelect_Select.Size = new System.Drawing.Size(318, 28);
            this.mnuSelect_Select.Text = "Select";
            this.mnuSelect_Select.Click += new System.EventHandler(this.mnuSelect_Select_Click);
            // 
            // mnuSelect_Deselected
            // 
            this.mnuSelect_Deselected.Name = "mnuSelect_Deselected";
            this.mnuSelect_Deselected.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSelect_Deselected.Size = new System.Drawing.Size(318, 28);
            this.mnuSelect_Deselected.Text = "Deselect";
            this.mnuSelect_Deselected.Click += new System.EventHandler(this.mnuSelect_Deselected_Click);
            // 
            // mnuSelect_SelectAll
            // 
            this.mnuSelect_SelectAll.Name = "mnuSelect_SelectAll";
            this.mnuSelect_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuSelect_SelectAll.Size = new System.Drawing.Size(318, 28);
            this.mnuSelect_SelectAll.Text = "Select all";
            this.mnuSelect_SelectAll.Click += new System.EventHandler(this.mnuSelect_SelectAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(315, 6);
            // 
            // mnuSelect_Group
            // 
            this.mnuSelect_Group.Name = "mnuSelect_Group";
            this.mnuSelect_Group.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mnuSelect_Group.Size = new System.Drawing.Size(318, 28);
            this.mnuSelect_Group.Text = "Group";
            this.mnuSelect_Group.Click += new System.EventHandler(this.mnuSelect_Group_Click);
            // 
            // mnuSelect_Ungroup
            // 
            this.mnuSelect_Ungroup.Name = "mnuSelect_Ungroup";
            this.mnuSelect_Ungroup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuSelect_Ungroup.Size = new System.Drawing.Size(318, 28);
            this.mnuSelect_Ungroup.Text = "Ungroup";
            this.mnuSelect_Ungroup.Click += new System.EventHandler(this.mnuSelect_Ungroup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(315, 6);
            // 
            // mnuSelect_Scale
            // 
            this.mnuSelect_Scale.Name = "mnuSelect_Scale";
            this.mnuSelect_Scale.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuSelect_Scale.Size = new System.Drawing.Size(318, 28);
            this.mnuSelect_Scale.Text = "Scale";
            this.mnuSelect_Scale.Click += new System.EventHandler(this.mnuSelect_Scale_Click);
            // 
            // mnuSelect_Rotate
            // 
            this.mnuSelect_Rotate.Name = "mnuSelect_Rotate";
            this.mnuSelect_Rotate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuSelect_Rotate.Size = new System.Drawing.Size(318, 28);
            this.mnuSelect_Rotate.Text = "Rotate";
            this.mnuSelect_Rotate.Click += new System.EventHandler(this.mnuSelect_Rotate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(315, 6);
            // 
            // mnuSelect_DeleteSelected
            // 
            this.mnuSelect_DeleteSelected.Name = "mnuSelect_DeleteSelected";
            this.mnuSelect_DeleteSelected.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.mnuSelect_DeleteSelected.Size = new System.Drawing.Size(318, 28);
            this.mnuSelect_DeleteSelected.Text = "Delete selected";
            this.mnuSelect_DeleteSelected.Click += new System.EventHandler(this.mnuSelect_DeleteSelected_Click);
            // 
            // mnuDrawing
            // 
            this.mnuDrawing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDrawing_Freehand,
            this.mnuDrawing_Text,
            this.toolStripSeparator7,
            this.mnuDrawing_Line,
            this.mnuDrawing_Curve,
            this.mnuDrawing_Bezier,
            this.mnuDrawing_Ellipse,
            this.mnuDrawing_Rectangle,
            this.mnuDrawing_Polygon});
            this.mnuDrawing.ForeColor = System.Drawing.Color.White;
            this.mnuDrawing.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuDrawing.Name = "mnuDrawing";
            this.mnuDrawing.Size = new System.Drawing.Size(88, 27);
            this.mnuDrawing.Text = "Drawing";
            // 
            // mnuDrawing_Freehand
            // 
            this.mnuDrawing_Freehand.Image = global::KDrawing.Properties.Resources.lead_pencil_black;
            this.mnuDrawing_Freehand.Name = "mnuDrawing_Freehand";
            this.mnuDrawing_Freehand.Size = new System.Drawing.Size(171, 28);
            this.mnuDrawing_Freehand.Text = "Free hand";
            this.mnuDrawing_Freehand.Click += new System.EventHandler(this.mnuDrawing_Freehand_Click);
            // 
            // mnuDrawing_Text
            // 
            this.mnuDrawing_Text.Image = global::KDrawing.Properties.Resources.shape_text_black;
            this.mnuDrawing_Text.Name = "mnuDrawing_Text";
            this.mnuDrawing_Text.Size = new System.Drawing.Size(171, 28);
            this.mnuDrawing_Text.Text = "Text";
            this.mnuDrawing_Text.Click += new System.EventHandler(this.mnuDrawing_Text_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(168, 6);
            // 
            // mnuDrawing_Line
            // 
            this.mnuDrawing_Line.Image = global::KDrawing.Properties.Resources.shape_line_black;
            this.mnuDrawing_Line.Name = "mnuDrawing_Line";
            this.mnuDrawing_Line.Size = new System.Drawing.Size(171, 28);
            this.mnuDrawing_Line.Text = "Line";
            this.mnuDrawing_Line.Click += new System.EventHandler(this.mnuDrawing_Line_Click);
            // 
            // mnuDrawing_Curve
            // 
            this.mnuDrawing_Curve.Image = global::KDrawing.Properties.Resources.shape_curve_black;
            this.mnuDrawing_Curve.Name = "mnuDrawing_Curve";
            this.mnuDrawing_Curve.Size = new System.Drawing.Size(171, 28);
            this.mnuDrawing_Curve.Text = "Curve";
            this.mnuDrawing_Curve.Click += new System.EventHandler(this.mnuDrawing_Curve_Click);
            // 
            // mnuDrawing_Bezier
            // 
            this.mnuDrawing_Bezier.Image = global::KDrawing.Properties.Resources.shape_bezier_black;
            this.mnuDrawing_Bezier.Name = "mnuDrawing_Bezier";
            this.mnuDrawing_Bezier.Size = new System.Drawing.Size(171, 28);
            this.mnuDrawing_Bezier.Text = "Bezier";
            this.mnuDrawing_Bezier.Click += new System.EventHandler(this.mnuDrawing_Bezier_Click);
            // 
            // mnuDrawing_Ellipse
            // 
            this.mnuDrawing_Ellipse.Image = global::KDrawing.Properties.Resources.shape_ellipse_outline_black;
            this.mnuDrawing_Ellipse.Name = "mnuDrawing_Ellipse";
            this.mnuDrawing_Ellipse.Size = new System.Drawing.Size(171, 28);
            this.mnuDrawing_Ellipse.Text = "Ellipse";
            this.mnuDrawing_Ellipse.Click += new System.EventHandler(this.mnuDrawing_Ellipse_Click);
            // 
            // mnuDrawing_Rectangle
            // 
            this.mnuDrawing_Rectangle.Image = global::KDrawing.Properties.Resources.shape_rectangle_outline_black;
            this.mnuDrawing_Rectangle.Name = "mnuDrawing_Rectangle";
            this.mnuDrawing_Rectangle.Size = new System.Drawing.Size(171, 28);
            this.mnuDrawing_Rectangle.Text = "Rectangle";
            this.mnuDrawing_Rectangle.Click += new System.EventHandler(this.mnuDrawing_Rectangle_Click);
            // 
            // mnuDrawing_Polygon
            // 
            this.mnuDrawing_Polygon.Image = global::KDrawing.Properties.Resources.shape_pentagon_outline_black;
            this.mnuDrawing_Polygon.Name = "mnuDrawing_Polygon";
            this.mnuDrawing_Polygon.Size = new System.Drawing.Size(171, 28);
            this.mnuDrawing_Polygon.Text = "Polygon";
            this.mnuDrawing_Polygon.Click += new System.EventHandler(this.mnuDrawing_Polygon_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView_Toolbar,
            this.mnuView_Layers});
            this.mnuView.ForeColor = System.Drawing.Color.White;
            this.mnuView.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(61, 27);
            this.mnuView.Text = "View";
            // 
            // mnuView_Toolbar
            // 
            this.mnuView_Toolbar.Checked = true;
            this.mnuView_Toolbar.CheckOnClick = true;
            this.mnuView_Toolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuView_Toolbar.Name = "mnuView_Toolbar";
            this.mnuView_Toolbar.Size = new System.Drawing.Size(220, 28);
            this.mnuView_Toolbar.Text = "Toolbar";
            this.mnuView_Toolbar.ToolTipText = "Hide tool bar";
            this.mnuView_Toolbar.Click += new System.EventHandler(this.mnuView_Toolbar_Click);
            // 
            // mnuView_Layers
            // 
            this.mnuView_Layers.Checked = true;
            this.mnuView_Layers.CheckOnClick = true;
            this.mnuView_Layers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuView_Layers.Name = "mnuView_Layers";
            this.mnuView_Layers.Size = new System.Drawing.Size(220, 28);
            this.mnuView_Layers.Text = "Shapes are drew";
            this.mnuView_Layers.ToolTipText = "Close shapes are drew panel";
            this.mnuView_Layers.Click += new System.EventHandler(this.mnuView_Layers_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.ForeColor = System.Drawing.Color.White;
            this.mnuAbout.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(71, 27);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // tblpnlMidArea
            // 
            this.tblpnlMidArea.ColumnCount = 3;
            this.tblpnlMidArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlMidArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMidArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlMidArea.Controls.Add(this.shapeLayers, 2, 0);
            this.tblpnlMidArea.Controls.Add(this.pnlToolbar, 0, 0);
            this.tblpnlMidArea.Controls.Add(this.psfMain, 1, 0);
            this.tblpnlMidArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMidArea.Location = new System.Drawing.Point(0, 72);
            this.tblpnlMidArea.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnlMidArea.Name = "tblpnlMidArea";
            this.tblpnlMidArea.RowCount = 1;
            this.tblpnlMidArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMidArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 751F));
            this.tblpnlMidArea.Size = new System.Drawing.Size(1582, 751);
            this.tblpnlMidArea.TabIndex = 3;
            // 
            // shapeLayers
            // 
            this.shapeLayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.shapeLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shapeLayers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLayers.Location = new System.Drawing.Point(1280, 0);
            this.shapeLayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shapeLayers.Name = "shapeLayers";
            this.shapeLayers.Size = new System.Drawing.Size(300, 751);
            this.shapeLayers.TabIndex = 13;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlToolbar.Controls.Add(this.btnForeColor);
            this.pnlToolbar.Controls.Add(this.btnBackColor);
            this.pnlToolbar.Controls.Add(this.btnDefaultColor);
            this.pnlToolbar.Controls.Add(this.btnPolygon);
            this.pnlToolbar.Controls.Add(this.btnRectangle);
            this.pnlToolbar.Controls.Add(this.btnEllipse);
            this.pnlToolbar.Controls.Add(this.btnBezier);
            this.pnlToolbar.Controls.Add(this.btnCurve);
            this.pnlToolbar.Controls.Add(this.btnLine);
            this.pnlToolbar.Controls.Add(this.btnText);
            this.pnlToolbar.Controls.Add(this.btnPencil);
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnUngroup);
            this.pnlToolbar.Controls.Add(this.btnGroup);
            this.pnlToolbar.Controls.Add(this.btnSelect);
            this.pnlToolbar.Controls.Add(this.btnSwapColor);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToolbar.Location = new System.Drawing.Point(2, 0);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(60, 751);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnForeColor
            // 
            this.btnForeColor.BackColor = System.Drawing.Color.Black;
            this.btnForeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForeColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForeColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnForeColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor.Location = new System.Drawing.Point(5, 250);
            this.btnForeColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(35, 35);
            this.btnForeColor.TabIndex = 0;
            this.btnForeColor.ToolTipActive = true;
            this.btnForeColor.ToolTipAutomaticDelay = 500;
            this.btnForeColor.ToolTipAutoPopDelay = 5000;
            this.btnForeColor.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnForeColor.ToolTipCaption = "";
            this.btnForeColor.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnForeColor.ToolTipInitialDelay = 200;
            this.btnForeColor.ToolTipIsBalloon = false;
            this.btnForeColor.ToolTipReshowDelay = 100;
            this.btnForeColor.ToolTipShowAlways = true;
            this.btnForeColor.ToolTipTitle = "Fore color";
            this.btnForeColor.UseVisualStyleBackColor = false;
            this.btnForeColor.BackColorChanged += new System.EventHandler(this.btnForeColor_BackColorChanged);
            this.btnForeColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.BackColor = System.Drawing.Color.White;
            this.btnBackColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBackColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Location = new System.Drawing.Point(20, 270);
            this.btnBackColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(35, 35);
            this.btnBackColor.TabIndex = 0;
            this.btnBackColor.ToolTipActive = true;
            this.btnBackColor.ToolTipAutomaticDelay = 500;
            this.btnBackColor.ToolTipAutoPopDelay = 5000;
            this.btnBackColor.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnBackColor.ToolTipCaption = "";
            this.btnBackColor.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBackColor.ToolTipInitialDelay = 200;
            this.btnBackColor.ToolTipIsBalloon = false;
            this.btnBackColor.ToolTipReshowDelay = 100;
            this.btnBackColor.ToolTipShowAlways = true;
            this.btnBackColor.ToolTipTitle = "Back color";
            this.btnBackColor.UseVisualStyleBackColor = false;
            this.btnBackColor.BackColorChanged += new System.EventHandler(this.btnBackColor_BackColorChanged);
            this.btnBackColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnDefaultColor
            // 
            this.btnDefaultColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDefaultColor.BackgroundImage")));
            this.btnDefaultColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefaultColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDefaultColor.FlatAppearance.BorderSize = 0;
            this.btnDefaultColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDefaultColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnDefaultColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultColor.Location = new System.Drawing.Point(5, 225);
            this.btnDefaultColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnDefaultColor.Name = "btnDefaultColor";
            this.btnDefaultColor.Size = new System.Drawing.Size(20, 20);
            this.btnDefaultColor.TabIndex = 0;
            this.btnDefaultColor.ToolTipActive = true;
            this.btnDefaultColor.ToolTipAutomaticDelay = 500;
            this.btnDefaultColor.ToolTipAutoPopDelay = 5000;
            this.btnDefaultColor.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnDefaultColor.ToolTipCaption = "Fore color = black, Back color = white";
            this.btnDefaultColor.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDefaultColor.ToolTipInitialDelay = 200;
            this.btnDefaultColor.ToolTipIsBalloon = false;
            this.btnDefaultColor.ToolTipReshowDelay = 100;
            this.btnDefaultColor.ToolTipShowAlways = true;
            this.btnDefaultColor.ToolTipTitle = "Default color";
            this.btnDefaultColor.UseVisualStyleBackColor = true;
            this.btnDefaultColor.Click += new System.EventHandler(this.btnDefaultColor_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackgroundImage = global::KDrawing.Properties.Resources.shape_pentagon_outline_white;
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPolygon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolygon.Location = new System.Drawing.Point(5, 656);
            this.btnPolygon.Margin = new System.Windows.Forms.Padding(0);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(50, 40);
            this.btnPolygon.TabIndex = 0;
            this.btnPolygon.Tag = "Polygon";
            this.btnPolygon.ToolTipActive = true;
            this.btnPolygon.ToolTipAutomaticDelay = 500;
            this.btnPolygon.ToolTipAutoPopDelay = 5000;
            this.btnPolygon.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnPolygon.ToolTipCaption = "Draw polygon, double click to stop";
            this.btnPolygon.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPolygon.ToolTipInitialDelay = 200;
            this.btnPolygon.ToolTipIsBalloon = false;
            this.btnPolygon.ToolTipReshowDelay = 100;
            this.btnPolygon.ToolTipShowAlways = true;
            this.btnPolygon.ToolTipTitle = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = global::KDrawing.Properties.Resources.shape_rectangle_outline_white;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Location = new System.Drawing.Point(5, 610);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(0);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(50, 40);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.Tag = "Rectangle";
            this.btnRectangle.ToolTipActive = true;
            this.btnRectangle.ToolTipAutomaticDelay = 500;
            this.btnRectangle.ToolTipAutoPopDelay = 5000;
            this.btnRectangle.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnRectangle.ToolTipCaption = "Draw a rectangle, press \"Shift\" while drawing to draw square";
            this.btnRectangle.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnRectangle.ToolTipInitialDelay = 200;
            this.btnRectangle.ToolTipIsBalloon = false;
            this.btnRectangle.ToolTipReshowDelay = 100;
            this.btnRectangle.ToolTipShowAlways = true;
            this.btnRectangle.ToolTipTitle = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnShape_Click);
            this.btnRectangle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRectangle_MouseDown);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackgroundImage = global::KDrawing.Properties.Resources.shape_ellipse_outline_white;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEllipse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Location = new System.Drawing.Point(5, 564);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(0);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(50, 40);
            this.btnEllipse.TabIndex = 0;
            this.btnEllipse.Tag = "Ellipse";
            this.btnEllipse.ToolTipActive = true;
            this.btnEllipse.ToolTipAutomaticDelay = 500;
            this.btnEllipse.ToolTipAutoPopDelay = 5000;
            this.btnEllipse.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnEllipse.ToolTipCaption = "Draw an ellipse, press \"Shift\" while drawing to draw circle";
            this.btnEllipse.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEllipse.ToolTipInitialDelay = 200;
            this.btnEllipse.ToolTipIsBalloon = false;
            this.btnEllipse.ToolTipReshowDelay = 100;
            this.btnEllipse.ToolTipShowAlways = true;
            this.btnEllipse.ToolTipTitle = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnShape_Click);
            this.btnEllipse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEllipse_MouseDown);
            // 
            // btnBezier
            // 
            this.btnBezier.BackgroundImage = global::KDrawing.Properties.Resources.shape_bezier_white;
            this.btnBezier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBezier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnBezier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnBezier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnBezier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBezier.Location = new System.Drawing.Point(5, 518);
            this.btnBezier.Margin = new System.Windows.Forms.Padding(0);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(50, 40);
            this.btnBezier.TabIndex = 0;
            this.btnBezier.Tag = "Bezier";
            this.btnBezier.ToolTipActive = true;
            this.btnBezier.ToolTipAutomaticDelay = 500;
            this.btnBezier.ToolTipAutoPopDelay = 5000;
            this.btnBezier.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnBezier.ToolTipCaption = "Draw a bezier with 4 point";
            this.btnBezier.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBezier.ToolTipInitialDelay = 200;
            this.btnBezier.ToolTipIsBalloon = false;
            this.btnBezier.ToolTipReshowDelay = 100;
            this.btnBezier.ToolTipShowAlways = true;
            this.btnBezier.ToolTipTitle = "Bezier";
            this.btnBezier.UseVisualStyleBackColor = true;
            this.btnBezier.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.BackgroundImage = global::KDrawing.Properties.Resources.shape_curve_white;
            this.btnCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCurve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnCurve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnCurve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurve.Location = new System.Drawing.Point(5, 472);
            this.btnCurve.Margin = new System.Windows.Forms.Padding(0);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(50, 40);
            this.btnCurve.TabIndex = 0;
            this.btnCurve.Tag = "Curve";
            this.btnCurve.ToolTipActive = true;
            this.btnCurve.ToolTipAutomaticDelay = 500;
            this.btnCurve.ToolTipAutoPopDelay = 5000;
            this.btnCurve.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnCurve.ToolTipCaption = "Draw curve, stop by double click";
            this.btnCurve.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCurve.ToolTipInitialDelay = 200;
            this.btnCurve.ToolTipIsBalloon = false;
            this.btnCurve.ToolTipReshowDelay = 100;
            this.btnCurve.ToolTipShowAlways = true;
            this.btnCurve.ToolTipTitle = "Curve";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = global::KDrawing.Properties.Resources.shape_line_white;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Location = new System.Drawing.Point(5, 426);
            this.btnLine.Margin = new System.Windows.Forms.Padding(0);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(50, 40);
            this.btnLine.TabIndex = 0;
            this.btnLine.Tag = "Line";
            this.btnLine.ToolTipActive = true;
            this.btnLine.ToolTipAutomaticDelay = 500;
            this.btnLine.ToolTipAutoPopDelay = 5000;
            this.btnLine.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnLine.ToolTipCaption = "Draw a line";
            this.btnLine.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLine.ToolTipInitialDelay = 200;
            this.btnLine.ToolTipIsBalloon = false;
            this.btnLine.ToolTipReshowDelay = 100;
            this.btnLine.ToolTipShowAlways = true;
            this.btnLine.ToolTipTitle = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnText
            // 
            this.btnText.BackgroundImage = global::KDrawing.Properties.Resources.shape_text_white;
            this.btnText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText.Location = new System.Drawing.Point(5, 311);
            this.btnText.Margin = new System.Windows.Forms.Padding(0);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(50, 50);
            this.btnText.TabIndex = 0;
            this.btnText.Tag = "Text";
            this.btnText.ToolTipActive = true;
            this.btnText.ToolTipAutomaticDelay = 500;
            this.btnText.ToolTipAutoPopDelay = 5000;
            this.btnText.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnText.ToolTipCaption = "";
            this.btnText.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnText.ToolTipInitialDelay = 200;
            this.btnText.ToolTipIsBalloon = false;
            this.btnText.ToolTipReshowDelay = 100;
            this.btnText.ToolTipShowAlways = true;
            this.btnText.ToolTipTitle = "";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackgroundImage = global::KDrawing.Properties.Resources.lead_pencil_white;
            this.btnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPencil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.Location = new System.Drawing.Point(5, 365);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(0);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(50, 50);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.Tag = "Freehand";
            this.btnPencil.ToolTipActive = true;
            this.btnPencil.ToolTipAutomaticDelay = 500;
            this.btnPencil.ToolTipAutoPopDelay = 5000;
            this.btnPencil.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnPencil.ToolTipCaption = "";
            this.btnPencil.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPencil.ToolTipInitialDelay = 200;
            this.btnPencil.ToolTipIsBalloon = false;
            this.btnPencil.ToolTipReshowDelay = 100;
            this.btnPencil.ToolTipShowAlways = true;
            this.btnPencil.ToolTipTitle = "";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::KDrawing.Properties.Resources.trash_red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(5, 170);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.ToolTipActive = true;
            this.btnDelete.ToolTipAutomaticDelay = 500;
            this.btnDelete.ToolTipAutoPopDelay = 5000;
            this.btnDelete.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.ToolTipCaption = "Delete selected shapes";
            this.btnDelete.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDelete.ToolTipInitialDelay = 200;
            this.btnDelete.ToolTipIsBalloon = false;
            this.btnDelete.ToolTipReshowDelay = 100;
            this.btnDelete.ToolTipShowAlways = true;
            this.btnDelete.ToolTipTitle = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUngroup
            // 
            this.btnUngroup.BackgroundImage = global::KDrawing.Properties.Resources.ungroup_white;
            this.btnUngroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUngroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnUngroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnUngroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnUngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUngroup.Location = new System.Drawing.Point(5, 115);
            this.btnUngroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnUngroup.Name = "btnUngroup";
            this.btnUngroup.Size = new System.Drawing.Size(50, 50);
            this.btnUngroup.TabIndex = 0;
            this.btnUngroup.ToolTipActive = true;
            this.btnUngroup.ToolTipAutomaticDelay = 500;
            this.btnUngroup.ToolTipAutoPopDelay = 5000;
            this.btnUngroup.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnUngroup.ToolTipCaption = "Ungroup selected groups";
            this.btnUngroup.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnUngroup.ToolTipInitialDelay = 200;
            this.btnUngroup.ToolTipIsBalloon = false;
            this.btnUngroup.ToolTipReshowDelay = 100;
            this.btnUngroup.ToolTipShowAlways = true;
            this.btnUngroup.ToolTipTitle = "Ungroup";
            this.btnUngroup.UseVisualStyleBackColor = true;
            this.btnUngroup.Click += new System.EventHandler(this.btnUngroup_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackgroundImage = global::KDrawing.Properties.Resources.group_white;
            this.btnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Location = new System.Drawing.Point(5, 60);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(50, 50);
            this.btnGroup.TabIndex = 0;
            this.btnGroup.ToolTipActive = true;
            this.btnGroup.ToolTipAutomaticDelay = 500;
            this.btnGroup.ToolTipAutoPopDelay = 5000;
            this.btnGroup.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnGroup.ToolTipCaption = "Group selected shapes";
            this.btnGroup.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnGroup.ToolTipInitialDelay = 200;
            this.btnGroup.ToolTipIsBalloon = false;
            this.btnGroup.ToolTipReshowDelay = 100;
            this.btnGroup.ToolTipShowAlways = true;
            this.btnGroup.ToolTipTitle = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(5, 5);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 50);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.ToolTipActive = true;
            this.btnSelect.ToolTipAutomaticDelay = 500;
            this.btnSelect.ToolTipAutoPopDelay = 5000;
            this.btnSelect.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnSelect.ToolTipCaption = "Select shape by click. Press \"Shift\" to select multi shapes";
            this.btnSelect.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSelect.ToolTipInitialDelay = 200;
            this.btnSelect.ToolTipIsBalloon = false;
            this.btnSelect.ToolTipReshowDelay = 100;
            this.btnSelect.ToolTipShowAlways = true;
            this.btnSelect.ToolTipTitle = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSwapColor
            // 
            this.btnSwapColor.BackgroundImage = global::KDrawing.Properties.Resources.swap_color;
            this.btnSwapColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSwapColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSwapColor.FlatAppearance.BorderSize = 0;
            this.btnSwapColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSwapColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnSwapColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwapColor.Location = new System.Drawing.Point(25, 225);
            this.btnSwapColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnSwapColor.Name = "btnSwapColor";
            this.btnSwapColor.Size = new System.Drawing.Size(30, 30);
            this.btnSwapColor.TabIndex = 0;
            this.btnSwapColor.ToolTipActive = true;
            this.btnSwapColor.ToolTipAutomaticDelay = 500;
            this.btnSwapColor.ToolTipAutoPopDelay = 5000;
            this.btnSwapColor.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnSwapColor.ToolTipCaption = "Fore color <-> Back color";
            this.btnSwapColor.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSwapColor.ToolTipInitialDelay = 200;
            this.btnSwapColor.ToolTipIsBalloon = false;
            this.btnSwapColor.ToolTipReshowDelay = 100;
            this.btnSwapColor.ToolTipShowAlways = true;
            this.btnSwapColor.ToolTipTitle = "Swap color";
            this.btnSwapColor.UseVisualStyleBackColor = true;
            this.btnSwapColor.Click += new System.EventHandler(this.btnSwapColor_Click);
            // 
            // psfMain
            // 
            this.psfMain.BackColor = System.Drawing.Color.White;
            this.psfMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.psfMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psfMain.Location = new System.Drawing.Point(69, 5);
            this.psfMain.Margin = new System.Windows.Forms.Padding(5);
            this.psfMain.Name = "psfMain";
            this.psfMain.Size = new System.Drawing.Size(1204, 741);
            this.psfMain.TabIndex = 14;
            this.psfMain.Paint += new System.Windows.Forms.PaintEventHandler(this.psfMain_Paint);
            this.psfMain.DoubleClick += new System.EventHandler(this.psfMain_DoubleClick);
            this.psfMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.psfMain_MouseDown);
            this.psfMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.psfMain_MouseMove);
            this.psfMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.psfMain_MouseUp);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar_DrawingMode,
            this.statusBar_LineWeight,
            this.statusBar_DashStyle,
            this.statusBar_LabelForeColor,
            this.statusBar_ForeColor,
            this.statusBar_LabelBackColor,
            this.statusBar_BackColor,
            this.statusBar_ShapeType,
            this.statusBar_NumShapesSelected});
            this.statusBar.Location = new System.Drawing.Point(2, 825);
            this.statusBar.Margin = new System.Windows.Forms.Padding(2);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1578, 26);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 4;
            // 
            // statusBar_DrawingMode
            // 
            this.statusBar_DrawingMode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar_DrawingMode.ForeColor = System.Drawing.Color.White;
            this.statusBar_DrawingMode.Margin = new System.Windows.Forms.Padding(60, 0, 15, 0);
            this.statusBar_DrawingMode.Name = "statusBar_DrawingMode";
            this.statusBar_DrawingMode.Size = new System.Drawing.Size(57, 26);
            this.statusBar_DrawingMode.Text = "Mode :";
            // 
            // statusBar_LineWeight
            // 
            this.statusBar_LineWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar_LineWeight.ForeColor = System.Drawing.Color.White;
            this.statusBar_LineWeight.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.statusBar_LineWeight.Name = "statusBar_LineWeight";
            this.statusBar_LineWeight.Size = new System.Drawing.Size(117, 26);
            this.statusBar_LineWeight.Text = "Line weight : 1.0";
            // 
            // statusBar_DashStyle
            // 
            this.statusBar_DashStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar_DashStyle.ForeColor = System.Drawing.Color.White;
            this.statusBar_DashStyle.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.statusBar_DashStyle.Name = "statusBar_DashStyle";
            this.statusBar_DashStyle.Size = new System.Drawing.Size(86, 26);
            this.statusBar_DashStyle.Text = "Dash style :";
            // 
            // statusBar_LabelForeColor
            // 
            this.statusBar_LabelForeColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar_LabelForeColor.ForeColor = System.Drawing.Color.White;
            this.statusBar_LabelForeColor.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.statusBar_LabelForeColor.Name = "statusBar_LabelForeColor";
            this.statusBar_LabelForeColor.Size = new System.Drawing.Size(87, 26);
            this.statusBar_LabelForeColor.Text = "Fore color :";
            // 
            // statusBar_ForeColor
            // 
            this.statusBar_ForeColor.AutoSize = false;
            this.statusBar_ForeColor.BackColor = System.Drawing.Color.Black;
            this.statusBar_ForeColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar_ForeColor.ForeColor = System.Drawing.Color.Black;
            this.statusBar_ForeColor.Margin = new System.Windows.Forms.Padding(0, 2, 15, 2);
            this.statusBar_ForeColor.Name = "statusBar_ForeColor";
            this.statusBar_ForeColor.Size = new System.Drawing.Size(20, 22);
            // 
            // statusBar_LabelBackColor
            // 
            this.statusBar_LabelBackColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar_LabelBackColor.ForeColor = System.Drawing.Color.White;
            this.statusBar_LabelBackColor.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.statusBar_LabelBackColor.Name = "statusBar_LabelBackColor";
            this.statusBar_LabelBackColor.Size = new System.Drawing.Size(88, 26);
            this.statusBar_LabelBackColor.Text = "Back color :";
            // 
            // statusBar_BackColor
            // 
            this.statusBar_BackColor.AutoSize = false;
            this.statusBar_BackColor.BackColor = System.Drawing.Color.White;
            this.statusBar_BackColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar_BackColor.ForeColor = System.Drawing.Color.White;
            this.statusBar_BackColor.Margin = new System.Windows.Forms.Padding(0, 2, 15, 2);
            this.statusBar_BackColor.Name = "statusBar_BackColor";
            this.statusBar_BackColor.Size = new System.Drawing.Size(20, 22);
            // 
            // statusBar_ShapeType
            // 
            this.statusBar_ShapeType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar_ShapeType.ForeColor = System.Drawing.Color.White;
            this.statusBar_ShapeType.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.statusBar_ShapeType.Name = "statusBar_ShapeType";
            this.statusBar_ShapeType.Size = new System.Drawing.Size(93, 26);
            this.statusBar_ShapeType.Text = "Shape type :";
            // 
            // statusBar_NumShapesSelected
            // 
            this.statusBar_NumShapesSelected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar_NumShapesSelected.ForeColor = System.Drawing.Color.White;
            this.statusBar_NumShapesSelected.Margin = new System.Windows.Forms.Padding(430, 0, 15, 0);
            this.statusBar_NumShapesSelected.Name = "statusBar_NumShapesSelected";
            this.statusBar_NumShapesSelected.Size = new System.Drawing.Size(74, 26);
            this.statusBar_NumShapesSelected.Text = "Selected :";
            // 
            // imgCboDashStyle
            // 
            this.imgCboDashStyle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCboDashStyle.ImageStream")));
            this.imgCboDashStyle.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCboDashStyle.Images.SetKeyName(0, "0_Solid.png");
            this.imgCboDashStyle.Images.SetKeyName(1, "1_Dash.png");
            this.imgCboDashStyle.Images.SetKeyName(2, "2_Dot.png");
            this.imgCboDashStyle.Images.SetKeyName(3, "3_DashDot.png");
            this.imgCboDashStyle.Images.SetKeyName(4, "4_DashDotDot.png");
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.tblpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyUp);
            this.tblpnlMain.ResumeLayout(false);
            this.tblpnlMain.PerformLayout();
            this.dragMovePnl.ResumeLayout(false);
            this.dragMovePnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dragMovePanel1.ResumeLayout(false);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.tblpnlMidArea.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        private void BtnEllipse_DoubleClick1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnlMain;
        private KControls.TitleBar titleBar;
        private KControls.DragMovePanel dragMovePnl;
        private System.Windows.Forms.TableLayoutPanel tblpnlMidArea;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Panel pnlToolbar;
        private MyUserControls.ShapeLayersManager shapeLayers;
        private KControls.PaintSurface psfMain;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private KDrawing.KControls.ToggleButton btnCloseToolbar;
        private KControls.DragMovePanel dragMovePanel1;
        private KDrawing.KControls.ToggleButton btnCloseLayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.ComboBox cboDashStyle;
        public System.Windows.Forms.NumericUpDown nudLineWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private KDrawing.KControls.ToggleButton btnEnableFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KDrawing.KControls.FlatButton btnSelect;
        private System.Windows.Forms.ImageList imgCboDashStyle;
        private KDrawing.KControls.FlatButton btnUngroup;
        private KDrawing.KControls.FlatButton btnGroup;
        private KDrawing.KControls.FlatButton btnDelete;
        private KDrawing.KControls.FlatButton btnForeColor;
        private KDrawing.KControls.FlatButton btnBackColor;
        private KDrawing.KControls.FlatButton btnDefaultColor;
        private KDrawing.KControls.FlatButton btnSwapColor;
        private KDrawing.KControls.FlatButton btnPolygon;
        private KDrawing.KControls.FlatButton btnRectangle;
        private KDrawing.KControls.FlatButton btnEllipse;
        private KDrawing.KControls.FlatButton btnBezier;
        private KDrawing.KControls.FlatButton btnCurve;
        private KDrawing.KControls.FlatButton btnLine;
        private KDrawing.KControls.FlatButton btnPencil;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect_Select;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect_SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect_Group;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect_Ungroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect_Scale;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect_Rotate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect_DeleteSelected;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawing;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect_Deselected;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Open;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Save;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Quit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Fill;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuView_Toolbar;
        private System.Windows.Forms.ToolStripMenuItem mnuView_Layers;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_LineWeight;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_DashStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_ForeColor;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_BackColor;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_SwapColor;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_DefaultColor;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawing_Freehand;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawing_Text;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawing_Line;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawing_Curve;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawing_Bezier;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawing_Ellipse;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawing_Rectangle;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawing_Polygon;
        private KDrawing.KControls.FlatButton btnText;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_LabelForeColor;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_LineWeight;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_DashStyle;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_ForeColor;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_LabelBackColor;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_BackColor;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_ShapeType;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_NumShapesSelected;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_DrawingMode;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}