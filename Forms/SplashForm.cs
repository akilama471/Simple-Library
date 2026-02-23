using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarasaviLibrary.Forms
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        public void UpdateProgress(int value, string status)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateProgress(value, status)));
                return;
            }

            progressBar1.Value = value;
            lblStatus.Text = status;
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
        }
    }
}
