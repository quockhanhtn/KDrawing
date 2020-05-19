namespace KDrawing.MyUserControls
{
    partial class ShapeLayer
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
            this.chkIsSelected = new System.Windows.Forms.CheckBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.txtShapeName = new KDrawing.KControls.RenameLable();
            this.btnHidden = new KDrawing.KControls.FlatButton();
            this.btnDelete = new KDrawing.KControls.FlatButton();
            this.SuspendLayout();
            // 
            // chkIsSelected
            // 
            this.chkIsSelected.AutoSize = true;
            this.chkIsSelected.Location = new System.Drawing.Point(5, 9);
            this.chkIsSelected.Name = "chkIsSelected";
            this.chkIsSelected.Size = new System.Drawing.Size(18, 17);
            this.chkIsSelected.TabIndex = 2;
            this.chkIsSelected.UseVisualStyleBackColor = true;
            this.chkIsSelected.CheckedChanged += new System.EventHandler(this.chkIsSelected_CheckedChanged);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // txtShapeName
            // 
            this.txtShapeName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShapeName.Location = new System.Drawing.Point(55, 2);
            this.txtShapeName.Name = "txtShapeName";
            this.txtShapeName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.txtShapeName.Size = new System.Drawing.Size(189, 30);
            this.txtShapeName.TabIndex = 5;
            this.txtShapeName.Text = "bnhfm";
            // 
            // btnHidden
            // 
            this.btnHidden.BackgroundImage = global::KDrawing.Properties.Resources.eye_off_black;
            this.btnHidden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidden.FlatAppearance.BorderSize = 0;
            this.btnHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidden.Location = new System.Drawing.Point(25, 5);
            this.btnHidden.Name = "btnHidden";
            this.btnHidden.Size = new System.Drawing.Size(24, 24);
            this.btnHidden.TabIndex = 4;
            this.btnHidden.ToolTipActive = true;
            this.btnHidden.ToolTipAutomaticDelay = 500;
            this.btnHidden.ToolTipAutoPopDelay = 5000;
            this.btnHidden.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnHidden.ToolTipCaption = "";
            this.btnHidden.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHidden.ToolTipInitialDelay = 200;
            this.btnHidden.ToolTipIsBalloon = false;
            this.btnHidden.ToolTipReshowDelay = 100;
            this.btnHidden.ToolTipShowAlways = true;
            this.btnHidden.ToolTipTitle = "";
            this.btnHidden.UseVisualStyleBackColor = true;
            this.btnHidden.Click += new System.EventHandler(this.btnHidden_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::KDrawing.Properties.Resources.trash_red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(250, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(24, 24);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.ToolTipActive = true;
            this.btnDelete.ToolTipAutomaticDelay = 500;
            this.btnDelete.ToolTipAutoPopDelay = 5000;
            this.btnDelete.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.ToolTipCaption = "";
            this.btnDelete.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDelete.ToolTipInitialDelay = 200;
            this.btnDelete.ToolTipIsBalloon = false;
            this.btnDelete.ToolTipReshowDelay = 100;
            this.btnDelete.ToolTipShowAlways = true;
            this.btnDelete.ToolTipTitle = "";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ShapeLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtShapeName);
            this.Controls.Add(this.btnHidden);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkIsSelected);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Name = "ShapeLayer";
            this.Size = new System.Drawing.Size(296, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIsSelected;
        private KDrawing.KControls.FlatButton btnDelete;
        private KDrawing.KControls.FlatButton btnHidden;
        private KControls.RenameLable txtShapeName;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}
