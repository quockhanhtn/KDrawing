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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.titleBar1 = new KDrawing.KControls.TitleBar();
            this.btnChangeFont = new KDrawing.KControls.FlatButton();
            this.btnColor = new KDrawing.KControls.FlatButton();
            this.btnIsFill = new KDrawing.KControls.ToggleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFontFamily = new System.Windows.Forms.Label();
            this.lblFontStyle = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.psfDemo = new KDrawing.KControls.PaintSurface();
            this.txtText = new KDrawing.KControls.FlatTextbox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.groupBox5);
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.groupBox4);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnOk);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(2, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(591, 429);
            this.pnlMain.TabIndex = 0;
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
            this.btnCancel.TabIndex = 4;
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
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontDialog.ShowColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFontSize);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblFontStyle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblFontFamily);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnChangeFont);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 94);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font";
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
            this.btnColor.TabIndex = 8;
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
            this.btnIsFill.TabIndex = 11;
            this.btnIsFill.ToggleButtonStyle = KDrawing.KControls.ToggleButton.Style.ToggleButtonStyle3;
            this.btnIsFill.ToggleStage = true;
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
            // lblFontFamily
            // 
            this.lblFontFamily.AutoSize = true;
            this.lblFontFamily.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontFamily.Location = new System.Drawing.Point(107, 23);
            this.lblFontFamily.Name = "lblFontFamily";
            this.lblFontFamily.Size = new System.Drawing.Size(0, 20);
            this.lblFontFamily.TabIndex = 4;
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
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSize.Location = new System.Drawing.Point(107, 67);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(0, 20);
            this.lblFontSize.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIsFill);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(60, 60);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnColor);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(76, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(65, 60);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtText);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(147, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 60);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.psfDemo);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(10, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(570, 244);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Demo";
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
            this.Name = "fTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fTextEditor";
            this.Shown += new System.EventHandler(this.fTextEditor_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private KControls.ToggleButton btnIsFill;
        private System.Windows.Forms.GroupBox groupBox5;
        private KControls.PaintSurface psfDemo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFontStyle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFontFamily;
        private System.Windows.Forms.Label label2;
        private KControls.FlatTextbox txtText;
    }
}