using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDrawing.KControls
{
    public class ToggleButton : FlatButton
    {
        private Style toggleButtonStyle;
        private bool toggleStage = true;
        public Style ToggleButtonStyle { get => toggleButtonStyle; set { toggleButtonStyle = value; SetBackgroundImage(); } }
        public bool ToggleStage { get => toggleStage; set { toggleStage = value; SetBackgroundImage(); } }

        public ToggleButton() : base()
        {
            this.Click += ToggleButton_Click;
            this.BackColorChanged += ToggleButton_BackColorChanged;
            SetBackgroundImage();
            this.FlatAppearance.BorderSize = 0;
        }

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

        public enum Style
        {
            ToggleButtonStyle1,
            ToggleButtonStyle2,
            ToggleButtonStyle3,
            ToggleButtonStyle4
        }
    }
}
