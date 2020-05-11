namespace KDrawing
{
    partial class fAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAbout));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleBar1 = new KDrawing.KControls.TitleBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.llbWeb = new System.Windows.Forms.LinkLabel();
            this.llbGithub = new System.Windows.Forms.LinkLabel();
            this.llbGmail = new System.Windows.Forms.LinkLabel();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.picWeb = new System.Windows.Forms.PictureBox();
            this.picGmail = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGmail)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 295);
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
            this.titleBar1.Size = new System.Drawing.Size(628, 34);
            this.titleBar1.TabIndex = 0;
            this.titleBar1.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.TitleForeColor = System.Drawing.Color.White;
            this.titleBar1.TitleIcon = global::KDrawing.Properties.Resources.qk_logo;
            this.titleBar1.TitleText = "About";
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
            this.panel1.Size = new System.Drawing.Size(628, 257);
            this.panel1.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.llbWeb);
            this.pnlMain.Controls.Add(this.llbGithub);
            this.pnlMain.Controls.Add(this.llbGmail);
            this.pnlMain.Controls.Add(this.picGithub);
            this.pnlMain.Controls.Add(this.picWeb);
            this.pnlMain.Controls.Add(this.picGmail);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnOk);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(2, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(624, 255);
            this.pnlMain.TabIndex = 0;
            // 
            // llbWeb
            // 
            this.llbWeb.AutoSize = true;
            this.llbWeb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbWeb.Location = new System.Drawing.Point(70, 192);
            this.llbWeb.Name = "llbWeb";
            this.llbWeb.Size = new System.Drawing.Size(140, 25);
            this.llbWeb.TabIndex = 6;
            this.llbWeb.TabStop = true;
            this.llbWeb.Text = "quockhanh.dev";
            this.llbWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbWeb_LinkClicked);
            // 
            // llbGithub
            // 
            this.llbGithub.AutoSize = true;
            this.llbGithub.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGithub.Location = new System.Drawing.Point(70, 160);
            this.llbGithub.Name = "llbGithub";
            this.llbGithub.Size = new System.Drawing.Size(225, 25);
            this.llbGithub.TabIndex = 6;
            this.llbGithub.TabStop = true;
            this.llbGithub.Text = "github.com/quockhanhtn";
            this.llbGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGithub_LinkClicked);
            // 
            // llbGmail
            // 
            this.llbGmail.AutoSize = true;
            this.llbGmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGmail.Location = new System.Drawing.Point(70, 128);
            this.llbGmail.Name = "llbGmail";
            this.llbGmail.Size = new System.Drawing.Size(241, 25);
            this.llbGmail.TabIndex = 6;
            this.llbGmail.TabStop = true;
            this.llbGmail.Text = "quockhanhdev@gmail.com";
            this.llbGmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGmail_LinkClicked);
            // 
            // picGithub
            // 
            this.picGithub.Image = global::KDrawing.Properties.Resources.github;
            this.picGithub.Location = new System.Drawing.Point(34, 158);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(30, 30);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGithub.TabIndex = 5;
            this.picGithub.TabStop = false;
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
            // 
            // picWeb
            // 
            this.picWeb.Image = global::KDrawing.Properties.Resources.web;
            this.picWeb.Location = new System.Drawing.Point(34, 190);
            this.picWeb.Name = "picWeb";
            this.picWeb.Size = new System.Drawing.Size(30, 30);
            this.picWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeb.TabIndex = 5;
            this.picWeb.TabStop = false;
            this.picWeb.Click += new System.EventHandler(this.picWeb_Click);
            // 
            // picGmail
            // 
            this.picGmail.Image = global::KDrawing.Properties.Resources.gmail;
            this.picGmail.Location = new System.Drawing.Point(34, 126);
            this.picGmail.Name = "picGmail";
            this.picGmail.Size = new System.Drawing.Size(30, 30);
            this.picGmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGmail.TabIndex = 5;
            this.picGmail.TabStop = false;
            this.picGmail.Click += new System.EventHandler(this.picGmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "© 2020 Lâm Quốc Khánh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "KDrawing version 1.0";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(503, 198);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // fAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 295);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAbout";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KControls.TitleBar titleBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox picGmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbWeb;
        private System.Windows.Forms.LinkLabel llbGithub;
        private System.Windows.Forms.LinkLabel llbGmail;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.PictureBox picWeb;
    }
}