namespace KDrawing.Boxs
{
    partial class fTextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTextEditor));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleBar1 = new KDrawing.KControls.TitleBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpDemo = new KDrawing.KControls.FlatGroupBox();
            this.psfDemo = new KDrawing.KControls.PaintSurface();
            this.grpText = new KDrawing.KControls.FlatGroupBox();
            this.txtText = new KDrawing.KControls.FlatTextBox();
            this.grpColor = new KDrawing.KControls.FlatGroupBox();
            this.btnColor = new KDrawing.KControls.FlatButton();
            this.grpFill = new KDrawing.KControls.FlatGroupBox();
            this.btnIsFill = new KDrawing.KControls.ToggleButton();
            this.grpFont = new KDrawing.KControls.FlatGroupBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFontStyle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFontFamily = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeFont = new KDrawing.KControls.FlatButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpDemo.SuspendLayout();
            this.grpText.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.grpFill.SuspendLayout();
            this.grpFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.titleBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 469);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar1.ButtonForeColor = KDrawing.KControls.TitleBar.ButtonColor.White;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.Location = new System.Drawing.Point(2, 2);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.ResizeWindowsBox = KDrawing.KControls.TitleBar.ResizeBox.NoneResize;
            this.titleBar1.Size = new System.Drawing.Size(595, 34);
            this.titleBar1.TabIndex = 0;
            this.titleBar1.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.TitleForeColor = System.Drawing.Color.White;
            this.titleBar1.TitleIcon = global::KDrawing.Properties.Resources.shape_text_white;
            this.titleBar1.TitleText = "Text editor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pnlMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.panel1.Size = new System.Drawing.Size(595, 431);
            this.panel1.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.grpDemo);
            this.pnlMain.Controls.Add(this.grpText);
            this.pnlMain.Controls.Add(this.grpColor);
            this.pnlMain.Controls.Add(this.grpFill);
            this.pnlMain.Controls.Add(this.grpFont);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnOk);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(2, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(591, 429);
            this.pnlMain.TabIndex = 0;
            // 
            // grpDemo
            // 
            this.grpDemo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpDemo.BorderWidth = 0.5F;
            this.grpDemo.Controls.Add(this.psfDemo);
            this.grpDemo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpDemo.Location = new System.Drawing.Point(10, 172);
            this.grpDemo.Name = "grpDemo";
            this.grpDemo.Size = new System.Drawing.Size(570, 244);
            this.grpDemo.TabIndex = 4;
            this.grpDemo.TabStop = false;
            this.grpDemo.Text = "Demo";
            // 
            // psfDemo
            // 
            this.psfDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psfDemo.Location = new System.Drawing.Point(3, 23);
            this.psfDemo.Name = "psfDemo";
            this.psfDemo.Size = new System.Drawing.Size(564, 218);
            this.psfDemo.TabIndex = 0;
            this.psfDemo.Paint += new System.Windows.Forms.PaintEventHandler(this.psfDemo_Paint);
            // 
            // grpText
            // 
            this.grpText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpText.BorderWidth = 0.5F;
            this.grpText.Controls.Add(this.txtText);
            this.grpText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpText.Location = new System.Drawing.Point(147, 106);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(433, 60);
            this.grpText.TabIndex = 3;
            this.grpText.TabStop = false;
            this.grpText.Text = "Text";
            // 
            // txtText
            // 
            this.txtText.BoderColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(6, 22);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(421, 30);
            this.txtText.TabIndex = 0;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // grpColor
            // 
            this.grpColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpColor.BorderWidth = 0.5F;
            this.grpColor.Controls.Add(this.btnColor);
            this.grpColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpColor.Location = new System.Drawing.Point(76, 106);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(65, 60);
            this.grpColor.TabIndex = 2;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(8, 26);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(48, 24);
            this.btnColor.TabIndex = 0;
            this.btnColor.ToolTipActive = true;
            this.btnColor.ToolTipAutomaticDelay = 500;
            this.btnColor.ToolTipAutoPopDelay = 5000;
            this.btnColor.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnColor.ToolTipCaption = "";
            this.btnColor.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnColor.ToolTipInitialDelay = 200;
            this.btnColor.ToolTipIsBalloon = false;
            this.btnColor.ToolTipReshowDelay = 100;
            this.btnColor.ToolTipShowAlways = true;
            this.btnColor.ToolTipTitle = "";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.BackColorChanged += new System.EventHandler(this.btnColor_BackColorChanged);
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // grpFill
            // 
            this.grpFill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpFill.BorderWidth = 0.5F;
            this.grpFill.Controls.Add(this.btnIsFill);
            this.grpFill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpFill.Location = new System.Drawing.Point(10, 106);
            this.grpFill.Name = "grpFill";
            this.grpFill.Size = new System.Drawing.Size(60, 60);
            this.grpFill.TabIndex = 1;
            this.grpFill.TabStop = false;
            this.grpFill.Text = "Fill";
            // 
            // btnIsFill
            // 
            this.btnIsFill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIsFill.BackgroundImage")));
            this.btnIsFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIsFill.FlatAppearance.BorderSize = 0;
            this.btnIsFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIsFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnIsFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsFill.Location = new System.Drawing.Point(6, 26);
            this.btnIsFill.Name = "btnIsFill";
            this.btnIsFill.Size = new System.Drawing.Size(48, 24);
            this.btnIsFill.TabIndex = 0;
            this.btnIsFill.ToggleButtonStyle = KDrawing.KControls.ToggleButton.Style.ToggleButtonStyle3;
            this.btnIsFill.ToggleStage = false;
            this.btnIsFill.ToolTipActive = true;
            this.btnIsFill.ToolTipAutomaticDelay = 500;
            this.btnIsFill.ToolTipAutoPopDelay = 5000;
            this.btnIsFill.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnIsFill.ToolTipCaption = "";
            this.btnIsFill.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnIsFill.ToolTipInitialDelay = 200;
            this.btnIsFill.ToolTipIsBalloon = false;
            this.btnIsFill.ToolTipReshowDelay = 100;
            this.btnIsFill.ToolTipShowAlways = true;
            this.btnIsFill.ToolTipTitle = "";
            this.btnIsFill.UseVisualStyleBackColor = true;
            this.btnIsFill.Click += new System.EventHandler(this.btnIsFill_Click);
            // 
            // grpFont
            // 
            this.grpFont.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpFont.BorderWidth = 0.5F;
            this.grpFont.Controls.Add(this.lblFontSize);
            this.grpFont.Controls.Add(this.label6);
            this.grpFont.Controls.Add(this.lblFontStyle);
            this.grpFont.Controls.Add(this.label5);
            this.grpFont.Controls.Add(this.lblFontFamily);
            this.grpFont.Controls.Add(this.label2);
            this.grpFont.Controls.Add(this.btnChangeFont);
            this.grpFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.grpFont.Location = new System.Drawing.Point(10, 10);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(460, 94);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Font ";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSize.Location = new System.Drawing.Point(107, 67);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(0, 20);
            this.lblFontSize.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Font size:";
            // 
            // lblFontStyle
            // 
            this.lblFontStyle.AutoSize = true;
            this.lblFontStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontStyle.Location = new System.Drawing.Point(107, 45);
            this.lblFontStyle.Name = "lblFontStyle";
            this.lblFontStyle.Size = new System.Drawing.Size(0, 20);
            this.lblFontStyle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Font style:";
            // 
            // lblFontFamily
            // 
            this.lblFontFamily.AutoSize = true;
            this.lblFontFamily.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontFamily.Location = new System.Drawing.Point(107, 23);
            this.lblFontFamily.Name = "lblFontFamily";
            this.lblFontFamily.Size = new System.Drawing.Size(0, 20);
            this.lblFontFamily.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Font family:";
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChangeFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangeFont.FlatAppearance.BorderSize = 0;
            this.btnChangeFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnChangeFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnChangeFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeFont.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFont.ForeColor = System.Drawing.Color.White;
            this.btnChangeFont.Location = new System.Drawing.Point(354, 52);
            this.btnChangeFont.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(100, 35);
            this.btnChangeFont.TabIndex = 3;
            this.btnChangeFont.Text = "Change";
            this.btnChangeFont.ToolTipActive = true;
            this.btnChangeFont.ToolTipAutomaticDelay = 500;
            this.btnChangeFont.ToolTipAutoPopDelay = 5000;
            this.btnChangeFont.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnChangeFont.ToolTipCaption = "Change font";
            this.btnChangeFont.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnChangeFont.ToolTipInitialDelay = 200;
            this.btnChangeFont.ToolTipIsBalloon = false;
            this.btnChangeFont.ToolTipReshowDelay = 100;
            this.btnChangeFont.ToolTipShowAlways = true;
            this.btnChangeFont.ToolTipTitle = "Font";
            this.btnChangeFont.UseVisualStyleBackColor = false;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(480, 62);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(480, 22);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ShowApply = true;
            this.fontDialog.ShowColor = true;
            this.fontDialog.Apply += new System.EventHandler(this.fontDialog_Apply);
            // 
            // fTextEditor
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(599, 469);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "fTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fTextEditor";
            this.Shown += new System.EventHandler(this.fTextEditor_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.grpDemo.ResumeLayout(false);
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.grpColor.ResumeLayout(false);
            this.grpFill.ResumeLayout(false);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private KControls.TitleBar titleBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private KControls.FlatButton btnChangeFont;
        private KControls.FlatButton btnColor;
        private System.Windows.Forms.FontDialog fontDialog;
        private KDrawing.KControls.FlatGroupBox grpFont;
        private KControls.ToggleButton btnIsFill;
        private KDrawing.KControls.FlatGroupBox grpDemo;
        private KControls.PaintSurface psfDemo;
        private KDrawing.KControls.FlatGroupBox grpText;
        private KDrawing.KControls.FlatGroupBox grpColor;
        private KDrawing.KControls.FlatGroupBox grpFill;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFontStyle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFontFamily;
        private System.Windows.Forms.Label label2;
        private KControls.FlatTextBox txtText;
    }
}