using System;

namespace KDrawing.KControls
{
    public class ToggleButton : FlatButton
    {
        #region Fields

        private Style toggleButtonStyle;
        private bool toggleStage = true;

        #endregion

        #region Properties
        public Style ToggleButtonStyle { get => toggleButtonStyle; set { toggleButtonStyle = value; SetBackgroundImage(); } }
        public bool ToggleStage { get => toggleStage; set { toggleStage = value; SetBackgroundImage(); } }
        #endregion

        #region Constructor
        public ToggleButton() : base()
        {
            this.Click += ToggleButton_Click;
            this.BackColorChanged += ToggleButton_BackColorChanged;
            SetBackgroundImage();
            this.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region Events
        private void ToggleButton_BackColorChanged(object sender, EventArgs e)
        {
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
            this.FlatAppearance.MouseDownBackColor = this.BackColor;
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            ToggleStage = !ToggleStage;
            SetBackgroundImage();
        }
        #endregion

        #region Method
        void SetBackgroundImage()
        {
            if (ToggleStage == true)
            {
                switch (ToggleButtonStyle)
                {
                    case Style.ToggleButtonStyle1:
                        this.BackgroundImage = Properties.Resources.toggle_on;
                        break;
                    case Style.ToggleButtonStyle2:
                        this.BackgroundImage = Properties.Resources.toggle_on_flip_x;
                        break;
                    case Style.ToggleButtonStyle3:
                        this.BackgroundImage = Properties.Resources.toggle_switch;
                        break;
                    case Style.ToggleButtonStyle4:
                        this.BackgroundImage = Properties.Resources.toggle_switch_flip_x;
                        break;
                }
            }
            else
            {
                switch (ToggleButtonStyle)
                {
                    case Style.ToggleButtonStyle1:
                        this.BackgroundImage = Properties.Resources.toggle_off;
                        break;
                    case Style.ToggleButtonStyle2:
                        this.BackgroundImage = Properties.Resources.toggle_off_flip_x;
                        break;
                    case Style.ToggleButtonStyle3:
                        this.BackgroundImage = Properties.Resources.toggle_switch_off;
                        break;
                    case Style.ToggleButtonStyle4:
                        this.BackgroundImage = Properties.Resources.toggle_switch_off_flip_x;
                        break;
                }
            }
        }
        #endregion

        public enum Style
        {
            ToggleButtonStyle1,
            ToggleButtonStyle2,
            ToggleButtonStyle3,
            ToggleButtonStyle4
        }
    }
}
