using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDrawing
{
    public partial class fAbout : Form
    {
        public fAbout()
        {
            InitializeComponent();
        }

        public static void Show(Form parentForm)
        {
            using (fAbout formAbout = new fAbout())
            {
                formAbout.ShowDialog(parentForm);
            }
        }

        private void llbGmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "mailto:quockhanhdev@gmail.com?subject=KDrawing contact&body=Send from KDrawing";
            proc.Start();
        }

        private void llbGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/quockhanhtn");
        }

        private void llbWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://quockhanh.dev");
        }

        private void picGmail_Click(object sender, EventArgs e)
        {
            llbGmail_LinkClicked(llbGmail, null);
        }

        private void picGithub_Click(object sender, EventArgs e)
        {
            llbGithub_LinkClicked(llbGithub, null);
        }

        private void picWeb_Click(object sender, EventArgs e)
        {
            llbWeb_LinkClicked(llbWeb, null);
        }
    }
}
