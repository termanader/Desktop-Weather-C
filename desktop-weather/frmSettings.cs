using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using weather_desktop;

namespace DesktopWeather
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Display == "3")
            {
                //Display = 3
                rad8Day.Checked = true;
            }
            if (Properties.Settings.Default.Display == "2")
            {
                //Display = 2
                rad3Day.Checked = true;
            }

            if (Properties.Settings.Default.Display == "1")
            {
                //Display = 1
                radCurrently.Checked = true;
            }
        }

        private void rad8Day_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rad3Day_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radCurrently_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmSettings_FormClosing(Object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rad8Day.Checked)
            {
                //Display = 3
                Properties.Settings.Default.Display = "3";
            }
            if (rad3Day.Checked)
            {
                //Display = 2
                Properties.Settings.Default.Display = "2";
            }

            if (radCurrently.Checked)
            {
                //Display = 1
                Properties.Settings.Default.Display = "1";
            }

            MessageBox.Show("Your settings have been saved." + Environment.NewLine + "Changes will be applied upon restart.", "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
