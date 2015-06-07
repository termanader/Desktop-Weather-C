using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopWeather;
using System.Timers;

namespace DesktopWeather
{
    public partial class frmCurrently : Form
    {
        clsForecast[] forecast = new clsForecast[10];
        clsDataGetter data = new clsDataGetter();
        frmSettings Settings = new frmSettings();

        public frmCurrently()
        {
            InitializeComponent();

            data.getLatLon();

            updateData();

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 3600000; // 1 Hour
            aTimer.Enabled = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            PlaceLowerRight();
            base.OnLoad(e);
        }

        // Specify what you want to happen when the Elapsed event is raised.
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            updateData();
        }

        private void updateData()
        {
            forecast = data.getForecast(forecast);

            lblCurrentTemp.Text = forecast[9].getSetTemp.ToString() + "\u00B0" + forecast[9].Units;
            
            lblCurrentConditions.Text = forecast[9].getSetSummary;
            
            pbCurrentConditions.Image = forecast[9].getIcon();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings.ShowDialog();
        }

        private void PlaceLowerRight()
        {
            //Determine "rightmost" screen
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }
    }
}
