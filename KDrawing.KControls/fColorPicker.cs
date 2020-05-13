using Cyotek.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    [DefaultEvent("PreviewColorChanged")]
    [DefaultProperty("Color")]
    public partial class fColorPicker : Form
    {
        #region Constants
        private static readonly object _eventPreviewColorChanged = new object();
        #endregion

        #region Fields
        private Brush _textureBrush;
        #endregion

        #region Constructors
        public fColorPicker()
        {
            this.InitializeComponent();
            this.ShowAlphaChannel = true;
            //this.Font = SystemFonts.DialogFont;
        }
        #endregion

        #region Events
        [Category("Property Changed")]
        public event EventHandler PreviewColorChanged
        {
            add { this.Events.AddHandler(_eventPreviewColorChanged, value); }
            remove { this.Events.RemoveHandler(_eventPreviewColorChanged, value); }
        }
        #endregion

        #region Properties
        public Color Color
        {
            get { return colorEditorManager.Color; }
            set { colorEditorManager.Color = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowAlphaChannel { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

                if (_textureBrush != null)
                {
                    _textureBrush.Dispose();
                    _textureBrush = null;
                }
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            colorEditor.ShowAlphaChannel = this.ShowAlphaChannel;

            if (!this.ShowAlphaChannel)
            {
                for (int i = 0; i < colorGrid.Colors.Count; i++)
                {
                    Color color = colorGrid.Colors[i];
                    if (color.A != 255)
                    {
                        colorGrid.Colors[i] = Color.FromArgb(255, color);
                    }
                }
            }
        }

        /// <summary>
        /// Raises the <see cref="PreviewColorChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected virtual void OnPreviewColorChanged(EventArgs e)
        {
            EventHandler handler = (EventHandler)this.Events[_eventPreviewColorChanged];
            handler?.Invoke(this, e);
        }

        private void colorEditorManager_ColorChanged(object sender, EventArgs e)
        {
            previewPanel.Invalidate();
            this.OnPreviewColorChanged(e);
        }

        private void colorGrid_EditingColor(object sender, EditColorCancelEventArgs e)
        {
            e.Cancel = true;

            using (ColorDialog dialog = new ColorDialog
            {
                FullOpen = true,
                Color = e.Color
            })
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    colorGrid.Colors[e.ColorIndex] = dialog.Color;
                }
            }
        }

        private void previewPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle region = previewPanel.ClientRectangle;

            if (this.Color.A != 255)
            {
                if (_textureBrush == null)
                {
                    using (Bitmap background = new Bitmap(ShareResources.cellbackground))
                    {
                        _textureBrush = new TextureBrush(background, WrapMode.Tile);
                    }
                }

                e.Graphics.FillRectangle(_textureBrush, region);
            }

            using (Brush brush = new SolidBrush(this.Color))
            {
                e.Graphics.FillRectangle(brush, region);
            }

            e.Graphics.DrawRectangle(SystemPens.ControlText, region.Left, region.Top, region.Width - 1, region.Height - 1);
        }
        #endregion

        #region Khanh's Extension
        public static Color Show(Form form, Color controlColor)
        {
            using (fColorPicker formColorPicker = new fColorPicker())
            {
                formColorPicker.Color = controlColor;
                if (formColorPicker.ShowDialog(form) == DialogResult.OK)
                {
                    formColorPicker.Dispose();
                    return formColorPicker.Color;
                }
            }
            return controlColor;
        }
        

        private void ColorPickerDialog_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0, 122, 204), 5), this.DisplayRectangle);
        }

        private void btnTransparent_Click(object sender, EventArgs e)
        {
            Color = Color.Transparent;
            btnOK.PerformClick();
        }
        #endregion
    }
}
