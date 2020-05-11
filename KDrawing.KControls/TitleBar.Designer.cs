namespace KDrawing.KControls
{
    partial class TitleBar
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
            this.pnlDragMove = new KDrawing.KControls.DragMovePanel();
            this.cmnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.cmnuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMaximize = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximinze = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.pnlDragMove.SuspendLayout();
            this.cmnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDragMove
            // 
            this.pnlDragMove.ContextMenuStrip = this.cmnu;
            this.pnlDragMove.Controls.Add(this.lblTitleText);
            this.pnlDragMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDragMove.Location = new System.Drawing.Point(34, 0);
            this.pnlDragMove.Name = "pnlDragMove";
            this.pnlDragMove.Size = new System.Drawing.Size(322, 34);
            this.pnlDragMove.TabIndex = 4;
            // 
            // cmnu
            // 
            this.cmnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuRestore,
            this.cmnuMove,
            this.cmnuMinimize,
            this.cmnuMaximize,
            this.toolStripSeparator1,
            this.cmnuClose});
            this.cmnu.Name = "cmnu";
            this.cmnu.Size = new System.Drawing.Size(147, 140);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleText.Location = new System.Drawing.Point(3, 7);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(65, 20);
            this.lblTitleText.TabIndex = 0;
            this.lblTitleText.Text = "TitleText";
            this.lblTitleText.SizeChanged += new System.EventHandler(this.lblTitleText_SizeChanged);
            // 
            // cmnuRestore
            // 
            this.cmnuRestore.Image = global::KDrawing.KControls.Properties.Resources.window_restore_black;
            this.cmnuRestore.Name = "cmnuRestore";
            this.cmnuRestore.Size = new System.Drawing.Size(146, 26);
            this.cmnuRestore.Text = "Restore";
            this.cmnuRestore.Click += new System.EventHandler(this.cmnuRestore_Click);
            // 
            // cmnuMove
            // 
            this.cmnuMove.Image = global::KDrawing.KControls.Properties.Resources.cursor_size_all;
            this.cmnuMove.Name = "cmnuMove";
            this.cmnuMove.Size = new System.Drawing.Size(146, 26);
            this.cmnuMove.Text = "Move";
            this.cmnuMove.Click += new System.EventHandler(this.cmnuMove_Click);
            // 
            // cmnuMinimize
            // 
            this.cmnuMinimize.Image = global::KDrawing.KControls.Properties.Resources.window_minimize_black;
            this.cmnuMinimize.Name = "cmnuMinimize";
            this.cmnuMinimize.Size = new System.Drawing.Size(146, 26);
            this.cmnuMinimize.Text = "Minimize";
            this.cmnuMinimize.Click += new System.EventHandler(this.cmnuMinimize_Click);
            // 
            // cmnuMaximize
            // 
            this.cmnuMaximize.Image = global::KDrawing.KControls.Properties.Resources.window_maximize_black;
            this.cmnuMaximize.Name = "cmnuMaximize";
            this.cmnuMaximize.Size = new System.Drawing.Size(146, 26);
            this.cmnuMaximize.Text = "Maximize";
            this.cmnuMaximize.Click += new System.EventHandler(this.cmnuMaximize_Click);
            // 
            // cmnuClose
            // 
            this.cmnuClose.Image = global::KDrawing.KControls.Properties.Resources.window_close_black;
            this.cmnuClose.Name = "cmnuClose";
            this.cmnuClose.Size = new System.Drawing.Size(146, 26);
            this.cmnuClose.Text = "Close";
            this.cmnuClose.Click += new System.EventHandler(this.cmnuClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.BackgroundImage = global::KDrawing.KControls.Properties.Resources.window_minimize_black;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(356, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 34);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximinze
            // 
            this.btnMaximinze.BackColor = System.Drawing.SystemColors.Control;
            this.btnMaximinze.BackgroundImage = global::KDrawing.KControls.Properties.Resources.window_maximize_black;
            this.btnMaximinze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximinze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximinze.FlatAppearance.BorderSize = 0;
            this.btnMaximinze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnMaximinze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximinze.Location = new System.Drawing.Point(390, 0);
            this.btnMaximinze.Name = "btnMaximinze";
            this.btnMaximinze.Size = new System.Drawing.Size(34, 34);
            this.btnMaximinze.TabIndex = 2;
            this.btnMaximinze.UseVisualStyleBackColor = false;
            this.btnMaximinze.Click += new System.EventHandler(this.btnMaximinze_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::KDrawing.KControls.Properties.Resources.window_close_black;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(424, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picIcon.ContextMenuStrip = this.cmnu;
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picIcon.Location = new System.Drawing.Point(0, 0);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(34, 34);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.picIcon_Click);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDragMove);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximinze);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(458, 34);
            this.Load += new System.EventHandler(this.TitleBar_Load);
            this.BackColorChanged += new System.EventHandler(this.TitleBar_BackColorChanged);
            this.Resize += new System.EventHandler(this.TitleBar_Resize);
            this.pnlDragMove.ResumeLayout(false);
            this.pnlDragMove.PerformLayout();
            this.cmnu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximinze;
        private System.Windows.Forms.Button btnClose;
        private DragMovePanel pnlDragMove;
        private System.Windows.Forms.ContextMenuStrip cmnu;
        private System.Windows.Forms.ToolStripMenuItem cmnuRestore;
        private System.Windows.Forms.ToolStripMenuItem cmnuMove;
        private System.Windows.Forms.ToolStripMenuItem cmnuMinimize;
        private System.Windows.Forms.ToolStripMenuItem cmnuMaximize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmnuClose;
        private System.Windows.Forms.Label lblTitleText;
    }
}
