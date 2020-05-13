using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    public partial class TitleBar : UserControl
    {
        #region Enums
        public enum ButtonColor
        {
            White, Black
        }

        public enum ResizeBox
        {
            MinimizeAndMaximize,
            MaximizeBoxOnly,
            MinimizeBoxOnly,
            NoneResize
        }
        #endregion

        #region Fields
        private ButtonColor buttonColor;
        private ResizeBox resizeBox;
        #endregion

        #region Properties

        [Category("My Properties"), Description("")]
        public Font TitleFont
        {
            get { return lblTitleText.Font; }
            set { lblTitleText.Font = value; }
        }

        [Category("My Properties"), Description("")]
        public Color TitleForeColor
        {
            get { return lblTitleText.ForeColor; }
            set { lblTitleText.ForeColor = value; }
        }

        [Category("My Properties"), Description("")]
        public string TitleText
        {
            get { return lblTitleText.Text; }
            set { lblTitleText.Text = value; }
        }

        [Category("My Properties"), Description("")]
        public ResizeBox ResizeWindowsBox
        {
            get { return this.resizeBox; }
            set
            {
                this.resizeBox = value;
                if (this.Controls.Contains(btnMaximinze)) { this.Controls.Remove(btnMaximinze); }
                if (this.Controls.Contains(btnMinimize)) { this.Controls.Remove(btnMinimize); }
                if (this.Controls.Contains(btnClose)) { this.Controls.Remove(btnClose); }

                switch (value)
                {
                    case ResizeBox.MinimizeAndMaximize:
                        btnMaximinze.Enabled = true;
                        btnMinimize.Enabled = true;
                        this.Controls.Add(btnMinimize);
                        this.Controls.Add(btnMaximinze);
                        this.Controls.Add(btnClose);
                        break;

                    case ResizeBox.MaximizeBoxOnly:
                        btnMaximinze.Enabled = true;
                        btnMinimize.Enabled = false;
                        this.Controls.Add(btnMaximinze);
                        this.Controls.Add(btnClose);
                        break;

                    case ResizeBox.MinimizeBoxOnly:
                        btnMaximinze.Enabled = false;
                        btnMinimize.Enabled = true;

                        this.Controls.Add(btnMinimize);
                        this.Controls.Add(btnClose);
                        break;

                    case ResizeBox.NoneResize:
                        btnMaximinze.Enabled = false;
                        btnMinimize.Enabled = false;
                        this.Controls.Add(btnClose);
                        break;
                }
            }
        }

        [Category("My Properties"), Description("")]
        public Image TitleIcon
        {
            get { return picIcon.Image; }
            set { picIcon.Image = value; }
        }

        [Category("My Properties"), Description("")]
        public ButtonColor ButtonForeColor
        {
            get { return this.buttonColor; }
            set
            {
                this.buttonColor = value;
                if (this.buttonColor == ButtonColor.Black)
                {
                    this.btnMinimize.BackgroundImage = Properties.Resources.window_minimize_black;
                    this.btnMaximinze.BackgroundImage = Properties.Resources.window_maximize_black;
                    this.btnClose.BackgroundImage = Properties.Resources.window_close_black;
                }
                else if (this.buttonColor == ButtonColor.White)
                {
                    this.btnMinimize.BackgroundImage = Properties.Resources.window_minimize_white;
                    this.btnMaximinze.BackgroundImage = Properties.Resources.window_maximize_white;
                    this.btnClose.BackgroundImage = Properties.Resources.window_close_white;
                }
            }
        }
        #endregion

        #region Constructor
        public TitleBar()
        {
            InitializeComponent();
            this.buttonColor = ButtonColor.Black;
            this.cmnuRestore.Enabled = false;
        }
        #endregion

        #region Events
        private void TitleBar_BackColorChanged(object sender, EventArgs e)
        {
            this.picIcon.BackColor = this.BackColor;
            this.pnlDragMove.BackColor = this.BackColor;
            this.btnMinimize.BackColor = this.BackColor;
            this.btnMaximinze.BackColor = this.BackColor;
        }

        private void TitleBar_Resize(object sender, EventArgs e)
        {
            this.picIcon.Width = this.picIcon.Height;
            this.btnClose.Width = this.btnClose.Height;
            this.btnMaximinze.Width = this.btnMaximinze.Height;
            this.btnMinimize.Width = this.btnMinimize.Height;
            this.lblTitleText.Location = new Point(6, (this.Height - lblTitleText.Height) / 2);
        }

        private void picIcon_Click(object sender, EventArgs e)
        {
            cmnu.Show(Cursor.Position);
        }

        private void lblTitleText_SizeChanged(object sender, EventArgs e) { this.lblTitleText.Location = new Point(6, (this.Height - lblTitleText.Height) / 2); }

        private void lblTitleText_TextChanged(object sender, EventArgs e) { if (this.FindForm() != null) { this.FindForm().Text = lblTitleText.Text; } }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void btnMaximinze_Click(object sender, EventArgs e)
        {
            if (this.FindForm().WindowState == FormWindowState.Maximized)
            {
                this.FindForm().WindowState = FormWindowState.Normal;
                this.cmnuMaximize.Enabled = true;
                this.cmnuRestore.Enabled = false;
            }
            else
            {
                this.FindForm().WindowState = FormWindowState.Maximized;
                this.cmnuMaximize.Enabled = false;
                this.cmnuRestore.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) { this.FindForm().Close(); }

        private void cmnuRestore_Click(object sender, EventArgs e) { this.btnMaximinze.PerformClick(); }

        private void cmnuMove_Click(object sender, EventArgs e) { }

        private void cmnuMinimize_Click(object sender, EventArgs e) { this.btnMinimize.PerformClick(); }

        private void cmnuMaximize_Click(object sender, EventArgs e) { this.btnMaximinze.PerformClick(); }

        private void cmnuClose_Click(object sender, EventArgs e) { this.btnClose.PerformClick(); }

        private void TitleBar_Load(object sender, EventArgs e)
        {
            if (btnMaximinze.Enabled == false)
            {
                cmnuRestore.Enabled = false;
                cmnuMaximize.Enabled = false;
            }

            if (btnMinimize.Enabled == false)
            {
                cmnuMinimize.Enabled = false;
            }
        }
        #endregion
    }
}