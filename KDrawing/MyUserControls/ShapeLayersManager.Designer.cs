namespace KDrawing.MyUserControls
{
    partial class ShapeLayersManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpShapeLayers = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteSelected = new KDrawing.KControls.FlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSelectedAll = new System.Windows.Forms.CheckBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbLayoutPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLayoutPnl
            // 
            this.tbLayoutPnl.ColumnCount = 1;
            this.tbLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutPnl.Controls.Add(this.panel1, 0, 0);
            this.tbLayoutPnl.Controls.Add(this.flpShapeLayers, 0, 2);
            this.tbLayoutPnl.Controls.Add(this.panel2, 0, 1);
            this.tbLayoutPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutPnl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLayoutPnl.Location = new System.Drawing.Point(0, 0);
            this.tbLayoutPnl.Margin = new System.Windows.Forms.Padding(0);
            this.tbLayoutPnl.Name = "tbLayoutPnl";
            this.tbLayoutPnl.RowCount = 3;
            this.tbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tbLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutPnl.Size = new System.Drawing.Size(300, 400);
            this.tbLayoutPnl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHAPES ARE DREW";
            // 
            // flpShapeLayers
            // 
            this.flpShapeLayers.AutoScroll = true;
            this.flpShapeLayers.BackColor = System.Drawing.SystemColors.Control;
            this.flpShapeLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpShapeLayers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpShapeLayers.Location = new System.Drawing.Point(2, 58);
            this.flpShapeLayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.flpShapeLayers.Name = "flpShapeLayers";
            this.flpShapeLayers.Size = new System.Drawing.Size(296, 340);
            this.flpShapeLayers.TabIndex = 1;
            this.flpShapeLayers.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDeleteSelected);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.chkSelectedAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 24);
            this.panel2.TabIndex = 2;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.BackgroundImage = global::KDrawing.Properties.Resources.trash_selected;
            this.btnDeleteSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteSelected.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelected.Location = new System.Drawing.Point(250, 0);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(30, 24);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.ToolTipActive = true;
            this.btnDeleteSelected.ToolTipAutomaticDelay = 500;
            this.btnDeleteSelected.ToolTipAutoPopDelay = 5000;
            this.btnDeleteSelected.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnDeleteSelected.ToolTipCaption = "";
            this.btnDeleteSelected.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDeleteSelected.ToolTipInitialDelay = 200;
            this.btnDeleteSelected.ToolTipIsBalloon = false;
            this.btnDeleteSelected.ToolTipReshowDelay = 100;
            this.btnDeleteSelected.ToolTipShowAlways = true;
            this.btnDeleteSelected.ToolTipTitle = "";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // chkSelectedAll
            // 
            this.chkSelectedAll.AutoSize = true;
            this.chkSelectedAll.Location = new System.Drawing.Point(5, 4);
            this.chkSelectedAll.Name = "chkSelectedAll";
            this.chkSelectedAll.Size = new System.Drawing.Size(18, 17);
            this.chkSelectedAll.TabIndex = 0;
            this.chkSelectedAll.UseVisualStyleBackColor = true;
            this.chkSelectedAll.CheckStateChanged += new System.EventHandler(this.chkSelectedAll_CheckStateChanged);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 500;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // ShapeLayersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.tbLayoutPnl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShapeLayersManager";
            this.Size = new System.Drawing.Size(300, 400);
            this.Load += new System.EventHandler(this.ShapeLayersManager_Load);
            this.tbLayoutPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbLayoutPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpShapeLayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private KDrawing.KControls.FlatButton btnDeleteSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSelectedAll;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}
