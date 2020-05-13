using Cyotek.Windows.Forms;

namespace KDrawing.KControls
{
    partial class fColorPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fColorPicker));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.screenColorPicker = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.titleBar = new KDrawing.KControls.TitleBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTransparent = new System.Windows.Forms.Button();
            this.colorWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.colorEditor = new KDrawing.KControls.ColorEditor();
            this.colorGrid = new Cyotek.Windows.Forms.ColorGrid();
            this.colorEditorManager = new KDrawing.KControls.ColorEditorManager();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(600, 43);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 40);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
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
            this.btnCancel.Location = new System.Drawing.Point(600, 142);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // previewPanel
            // 
            this.previewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPanel.Location = new System.Drawing.Point(600, 331);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(100, 100);
            this.previewPanel.TabIndex = 3;
            this.previewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.previewPanel_Paint);
            // 
            // screenColorPicker
            // 
            this.screenColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.screenColorPicker.Color = System.Drawing.Color.Black;
            this.screenColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("screenColorPicker.Image")));
            this.screenColorPicker.Location = new System.Drawing.Point(600, 204);
            this.screenColorPicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.screenColorPicker.Name = "screenColorPicker";
            this.screenColorPicker.Size = new System.Drawing.Size(100, 100);
            this.toolTip.SetToolTip(this.screenColorPicker, "Click and drag to select screen color");
            this.screenColorPicker.Zoom = 6;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar.ButtonForeColor = KDrawing.KControls.TitleBar.ButtonColor.White;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(2);
            this.titleBar.Name = "titleBar";
            this.titleBar.ResizeWindowsBox = KDrawing.KControls.TitleBar.ResizeBox.NoneResize;
            this.titleBar.Size = new System.Drawing.Size(720, 34);
            this.titleBar.TabIndex = 8;
            this.titleBar.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.TitleForeColor = System.Drawing.Color.White;
            this.titleBar.TitleIcon = global::KDrawing.KControls.Properties.Resources.palette_white;
            this.titleBar.TitleText = "Color picker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Color";
            // 
            // btnTransparent
            // 
            this.btnTransparent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransparent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTransparent.FlatAppearance.BorderSize = 0;
            this.btnTransparent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTransparent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnTransparent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransparent.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransparent.ForeColor = System.Drawing.Color.White;
            this.btnTransparent.Location = new System.Drawing.Point(600, 93);
            this.btnTransparent.Margin = new System.Windows.Forms.Padding(0);
            this.btnTransparent.Name = "btnTransparent";
            this.btnTransparent.Size = new System.Drawing.Size(100, 40);
            this.btnTransparent.TabIndex = 1;
            this.btnTransparent.Text = "No color";
            this.btnTransparent.UseVisualStyleBackColor = false;
            this.btnTransparent.Click += new System.EventHandler(this.btnTransparent_Click);
            // 
            // colorWheel
            // 
            this.colorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel.Location = new System.Drawing.Point(10, 67);
            this.colorWheel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.Size = new System.Drawing.Size(240, 240);
            this.colorWheel.TabIndex = 4;
            // 
            // colorEditor
            // 
            this.colorEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorEditor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorEditor.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorEditor.Location = new System.Drawing.Point(269, 56);
            this.colorEditor.Margin = new System.Windows.Forms.Padding(5);
            this.colorEditor.Name = "colorEditor";
            this.colorEditor.Size = new System.Drawing.Size(307, 363);
            this.colorEditor.TabIndex = 0;
            // 
            // colorGrid
            // 
            this.colorGrid.AutoAddColors = false;
            this.colorGrid.CellBorderStyle = Cyotek.Windows.Forms.ColorCellBorderStyle.None;
            this.colorGrid.EditMode = Cyotek.Windows.Forms.ColorEditingMode.Both;
            this.colorGrid.Location = new System.Drawing.Point(10, 313);
            this.colorGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.colorGrid.Name = "colorGrid";
            this.colorGrid.Padding = new System.Windows.Forms.Padding(0);
            this.colorGrid.Palette = Cyotek.Windows.Forms.ColorPalette.Paint;
            this.colorGrid.SelectedCellStyle = Cyotek.Windows.Forms.ColorGridSelectedCellStyle.Standard;
            this.colorGrid.ShowCustomColors = false;
            this.colorGrid.Size = new System.Drawing.Size(240, 90);
            this.colorGrid.Spacing = new System.Drawing.Size(0, 0);
            this.colorGrid.TabIndex = 7;
            this.colorGrid.EditingColor += new System.EventHandler<Cyotek.Windows.Forms.EditColorCancelEventArgs>(this.colorGrid_EditingColor);
            // 
            // colorEditorManager
            // 
            this.colorEditorManager.ColorEditor = this.colorEditor;
            this.colorEditorManager.ColorGrid = this.colorGrid;
            this.colorEditorManager.ColorWheel = this.colorWheel;
            this.colorEditorManager.ScreenColorPicker = this.screenColorPicker;
            this.colorEditorManager.ColorChanged += new System.EventHandler(this.colorEditorManager_ColorChanged);
            // 
            // fColorPicker
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(720, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransparent);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.screenColorPicker);
            this.Controls.Add(this.colorWheel);
            this.Controls.Add(this.colorEditor);
            this.Controls.Add(this.colorGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fColorPicker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Picker";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorPickerDialog_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorGrid colorGrid;
        private ColorEditor colorEditor;
        private ColorWheel colorWheel;
        private ColorEditorManager colorEditorManager;
        private ScreenColorPicker screenColorPicker;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.ToolTip toolTip;
        private KDrawing.KControls.TitleBar titleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransparent;
    }
}