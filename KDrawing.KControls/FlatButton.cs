using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KDrawing.KControls
{
    public class FlatButton : Button
    {
        #region Properties
        [Category("Tool tip"), Description("")]
        public bool ToolTipActive { get => this.toolTip.Active; set => this.toolTip.Active = value; }

        [Category("Tool tip"), Description("")]
        public string ToolTipTitle { get => this.toolTip.ToolTipTitle; set => this.toolTip.ToolTipTitle = value; }

        [Category("Tool tip"), Description("")]
        public string ToolTipCaption
        {
            get => toolTipCation;
            set
            {
                toolTipCation = value;
                this.toolTip.SetToolTip(this, toolTipCation);
            }
        }

        [Category("Tool tip"), Description("")]
        public int ToolTipAutomaticDelay { get => this.toolTip.AutomaticDelay; set => this.toolTip.AutomaticDelay = value; }

        [Category("Tool tip"), Description("")]
        public int ToolTipAutoPopDelay { get => this.toolTip.AutoPopDelay; set => this.toolTip.AutoPopDelay = value; }

        [Category("Tool tip"), Description("")]
        public Color ToolTipBackColor { get => this.toolTip.BackColor; set => this.toolTip.BackColor = value; }

        [Category("Tool tip"), Description("")]
        public Color ToolTipForeColor { get => this.toolTip.ForeColor; set => this.toolTip.ForeColor = value; }

        [Category("Tool tip"), Description("")]
        public int ToolTipInitialDelay { get => this.toolTip.InitialDelay; set => this.toolTip.InitialDelay = value; }

        [Category("Tool tip"), Description("")]
        public bool ToolTipIsBalloon { get => this.toolTip.IsBalloon; set => this.toolTip.IsBalloon = value; }

        [Category("Tool tip"), Description("")]
        public int ToolTipReshowDelay { get => this.toolTip.ReshowDelay; set => this.toolTip.ReshowDelay = value; }

        [Category("Tool tip"), Description("")]
        public bool ToolTipShowAlways { get => this.toolTip.ShowAlways; set => this.toolTip.ShowAlways = value; }
        #endregion

        #region Constructor
        public FlatButton() : base()
        {
            FlatStyle = FlatStyle.Flat;
            BackgroundImageLayout = ImageLayout.Zoom;

            this.toolTip = new ToolTip();
            this.toolTip.ShowAlways = true;
            this.toolTip.InitialDelay = 200;
        }
        #endregion

        #region Fields
        private ToolTip toolTip;
        private string toolTipCation = "";
        #endregion
    }
}
