using Cyotek.Windows.Forms;

namespace KDrawing.KControls
{
    partial class ColorEditor
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
            this.rgbHeaderLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.rNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gLabel = new System.Windows.Forms.Label();
            this.gNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bLabel = new System.Windows.Forms.Label();
            this.bNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hexLabel = new System.Windows.Forms.Label();
            this.hexTextBox = new System.Windows.Forms.ComboBox();
            this.lNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lLabel = new System.Windows.Forms.Label();
            this.sNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sLabel = new System.Windows.Forms.Label();
            this.hNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hLabel = new System.Windows.Forms.Label();
            this.hslLabel = new System.Windows.Forms.Label();
            this.aNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aLabel = new System.Windows.Forms.Label();
            this.btnCopyHex = new System.Windows.Forms.Button();
            this.aColorBar = new RgbaColorSlider();
            this.lColorBar = new LightnessColorSlider();
            this.sColorBar = new SaturationColorSlider();
            this.hColorBar = new HueColorSlider();
            this.bColorBar = new RgbaColorSlider();
            this.gColorBar = new RgbaColorSlider();
            this.rColorBar = new RgbaColorSlider();
            ((System.ComponentModel.ISupportInitialize)(this.rNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // rgbHeaderLabel
            // 
            this.rgbHeaderLabel.AutoSize = true;
            this.rgbHeaderLabel.Location = new System.Drawing.Point(-4, 0);
            this.rgbHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rgbHeaderLabel.Name = "rgbHeaderLabel";
            this.rgbHeaderLabel.Size = new System.Drawing.Size(42, 17);
            this.rgbHeaderLabel.TabIndex = 0;
            this.rgbHeaderLabel.Text = "RGB:";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(4, 16);
            this.rLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(22, 17);
            this.rLabel.TabIndex = 1;
            this.rLabel.Text = "R:";
            // 
            // rNumericUpDown
            // 
            this.rNumericUpDown.Location = new System.Drawing.Point(140, 14);
            this.rNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.rNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rNumericUpDown.Name = "rNumericUpDown";
            this.rNumericUpDown.Size = new System.Drawing.Size(77, 22);
            this.rNumericUpDown.TabIndex = 2;
            this.rNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(4, 48);
            this.gLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(23, 17);
            this.gLabel.TabIndex = 4;
            this.gLabel.Text = "G:";
            // 
            // gNumericUpDown
            // 
            this.gNumericUpDown.Location = new System.Drawing.Point(140, 46);
            this.gNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.gNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gNumericUpDown.Name = "gNumericUpDown";
            this.gNumericUpDown.Size = new System.Drawing.Size(77, 22);
            this.gNumericUpDown.TabIndex = 5;
            this.gNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(4, 80);
            this.bLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(21, 17);
            this.bLabel.TabIndex = 7;
            this.bLabel.Text = "B:";
            // 
            // bNumericUpDown
            // 
            this.bNumericUpDown.Location = new System.Drawing.Point(140, 80);
            this.bNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.bNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bNumericUpDown.Name = "bNumericUpDown";
            this.bNumericUpDown.Size = new System.Drawing.Size(77, 22);
            this.bNumericUpDown.TabIndex = 8;
            this.bNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(4, 116);
            this.hexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(36, 17);
            this.hexLabel.TabIndex = 10;
            this.hexLabel.Text = "Hex:";
            // 
            // hexTextBox
            // 
            this.hexTextBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hexTextBox.Location = new System.Drawing.Point(57, 116);
            this.hexTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(76, 23);
            this.hexTextBox.TabIndex = 11;
            this.hexTextBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.hexTextBox_DrawItem);
            this.hexTextBox.DropDown += new System.EventHandler(this.hexTextBox_DropDown);
            this.hexTextBox.SelectedIndexChanged += new System.EventHandler(this.hexTextBox_SelectedIndexChanged);
            this.hexTextBox.TextChanged += new System.EventHandler(this.ValueChangedHandler);
            this.hexTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hexTextBox_KeyDown);
            // 
            // lNumericUpDown
            // 
            this.lNumericUpDown.Location = new System.Drawing.Point(140, 234);
            this.lNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.lNumericUpDown.Name = "lNumericUpDown";
            this.lNumericUpDown.Size = new System.Drawing.Size(77, 22);
            this.lNumericUpDown.TabIndex = 20;
            this.lNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // lLabel
            // 
            this.lLabel.AutoSize = true;
            this.lLabel.Location = new System.Drawing.Point(4, 236);
            this.lLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLabel.Name = "lLabel";
            this.lLabel.Size = new System.Drawing.Size(20, 17);
            this.lLabel.TabIndex = 19;
            this.lLabel.Text = "L:";
            // 
            // sNumericUpDown
            // 
            this.sNumericUpDown.Location = new System.Drawing.Point(140, 202);
            this.sNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.sNumericUpDown.Name = "sNumericUpDown";
            this.sNumericUpDown.Size = new System.Drawing.Size(77, 22);
            this.sNumericUpDown.TabIndex = 17;
            this.sNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(5, 204);
            this.sLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(21, 17);
            this.sLabel.TabIndex = 16;
            this.sLabel.Text = "S:";
            // 
            // hNumericUpDown
            // 
            this.hNumericUpDown.Location = new System.Drawing.Point(140, 170);
            this.hNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.hNumericUpDown.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.hNumericUpDown.Name = "hNumericUpDown";
            this.hNumericUpDown.Size = new System.Drawing.Size(77, 22);
            this.hNumericUpDown.TabIndex = 14;
            this.hNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(4, 172);
            this.hLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(22, 17);
            this.hLabel.TabIndex = 13;
            this.hLabel.Text = "H:";
            // 
            // hslLabel
            // 
            this.hslLabel.AutoSize = true;
            this.hslLabel.Location = new System.Drawing.Point(4, 144);
            this.hslLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hslLabel.Name = "hslLabel";
            this.hslLabel.Size = new System.Drawing.Size(39, 17);
            this.hslLabel.TabIndex = 12;
            this.hslLabel.Text = "HSL:";
            // 
            // aNumericUpDown
            // 
            this.aNumericUpDown.Location = new System.Drawing.Point(140, 266);
            this.aNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.aNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.aNumericUpDown.Name = "aNumericUpDown";
            this.aNumericUpDown.Size = new System.Drawing.Size(77, 22);
            this.aNumericUpDown.TabIndex = 23;
            this.aNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(4, 268);
            this.aLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(48, 17);
            this.aLabel.TabIndex = 22;
            this.aLabel.Text = "Alpha:";
            // 
            // btnCopyHex
            // 
            this.btnCopyHex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCopyHex.FlatAppearance.BorderSize = 0;
            this.btnCopyHex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCopyHex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnCopyHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyHex.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyHex.ForeColor = System.Drawing.Color.White;
            this.btnCopyHex.Location = new System.Drawing.Point(142, 111);
            this.btnCopyHex.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopyHex.Name = "btnCopyHex";
            this.btnCopyHex.Size = new System.Drawing.Size(75, 30);
            this.btnCopyHex.TabIndex = 25;
            this.btnCopyHex.Text = "Copy";
            this.btnCopyHex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopyHex.UseVisualStyleBackColor = false;
            this.btnCopyHex.Click += new System.EventHandler(this.btnCopyHex_Click);
            // 
            // aColorBar
            // 
            this.aColorBar.Channel = RgbaChannel.Alpha;
            this.aColorBar.Location = new System.Drawing.Point(36, 266);
            this.aColorBar.Margin = new System.Windows.Forms.Padding(4);
            this.aColorBar.Name = "aColorBar";
            this.aColorBar.Size = new System.Drawing.Size(96, 25);
            this.aColorBar.TabIndex = 24;
            this.aColorBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // lColorBar
            // 
            this.lColorBar.Location = new System.Drawing.Point(36, 234);
            this.lColorBar.Margin = new System.Windows.Forms.Padding(4);
            this.lColorBar.Name = "lColorBar";
            this.lColorBar.Size = new System.Drawing.Size(96, 25);
            this.lColorBar.TabIndex = 21;
            this.lColorBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // sColorBar
            // 
            this.sColorBar.Location = new System.Drawing.Point(36, 202);
            this.sColorBar.Margin = new System.Windows.Forms.Padding(4);
            this.sColorBar.Name = "sColorBar";
            this.sColorBar.Size = new System.Drawing.Size(96, 25);
            this.sColorBar.TabIndex = 18;
            this.sColorBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // hColorBar
            // 
            this.hColorBar.Location = new System.Drawing.Point(36, 170);
            this.hColorBar.Margin = new System.Windows.Forms.Padding(4);
            this.hColorBar.Name = "hColorBar";
            this.hColorBar.Size = new System.Drawing.Size(96, 25);
            this.hColorBar.TabIndex = 15;
            this.hColorBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // bColorBar
            // 
            this.bColorBar.Channel = RgbaChannel.Blue;
            this.bColorBar.Location = new System.Drawing.Point(36, 80);
            this.bColorBar.Margin = new System.Windows.Forms.Padding(4);
            this.bColorBar.Name = "bColorBar";
            this.bColorBar.Size = new System.Drawing.Size(96, 25);
            this.bColorBar.TabIndex = 9;
            this.bColorBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // gColorBar
            // 
            this.gColorBar.Channel = RgbaChannel.Green;
            this.gColorBar.Location = new System.Drawing.Point(36, 48);
            this.gColorBar.Margin = new System.Windows.Forms.Padding(4);
            this.gColorBar.Name = "gColorBar";
            this.gColorBar.Size = new System.Drawing.Size(96, 25);
            this.gColorBar.TabIndex = 6;
            this.gColorBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // rColorBar
            // 
            this.rColorBar.Location = new System.Drawing.Point(36, 16);
            this.rColorBar.Margin = new System.Windows.Forms.Padding(4);
            this.rColorBar.Name = "rColorBar";
            this.rColorBar.Size = new System.Drawing.Size(96, 25);
            this.rColorBar.TabIndex = 3;
            this.rColorBar.ValueChanged += new System.EventHandler(this.ValueChangedHandler);
            // 
            // ColorEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopyHex);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.aNumericUpDown);
            this.Controls.Add(this.aColorBar);
            this.Controls.Add(this.hslLabel);
            this.Controls.Add(this.lNumericUpDown);
            this.Controls.Add(this.lColorBar);
            this.Controls.Add(this.lLabel);
            this.Controls.Add(this.sNumericUpDown);
            this.Controls.Add(this.sColorBar);
            this.Controls.Add(this.sLabel);
            this.Controls.Add(this.hColorBar);
            this.Controls.Add(this.hNumericUpDown);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.bNumericUpDown);
            this.Controls.Add(this.bColorBar);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.gNumericUpDown);
            this.Controls.Add(this.gColorBar);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.rColorBar);
            this.Controls.Add(this.rNumericUpDown);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.rgbHeaderLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ColorEditor";
            this.Size = new System.Drawing.Size(231, 303);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorEditor_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.rNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rgbHeaderLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.NumericUpDown rNumericUpDown;
        private RgbaColorSlider rColorBar;
        private System.Windows.Forms.Label gLabel;
        private RgbaColorSlider gColorBar;
        private System.Windows.Forms.NumericUpDown gNumericUpDown;
        private System.Windows.Forms.Label bLabel;
        private RgbaColorSlider bColorBar;
        private System.Windows.Forms.NumericUpDown bNumericUpDown;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.ComboBox hexTextBox;
        private System.Windows.Forms.NumericUpDown lNumericUpDown;
        private LightnessColorSlider lColorBar;
        private System.Windows.Forms.Label lLabel;
        private System.Windows.Forms.NumericUpDown sNumericUpDown;
        private SaturationColorSlider sColorBar;
        private System.Windows.Forms.Label sLabel;
        private HueColorSlider hColorBar;
        private System.Windows.Forms.NumericUpDown hNumericUpDown;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Label hslLabel;
        private System.Windows.Forms.NumericUpDown aNumericUpDown;
        private RgbaColorSlider aColorBar;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Button btnCopyHex;
    }
}
