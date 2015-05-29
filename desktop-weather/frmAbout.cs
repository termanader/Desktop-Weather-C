using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWeather
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void llblURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://kruug.org/draconemsoft");
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forecast.io/");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
