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

namespace weather_desktop
{
    public partial class frmGlance : Form
    {
        frmAbout About = new frmAbout();
        frmCurrently weatherCurrently = new frmCurrently();
        clsForecast[] forecast = new clsForecast[10];
        clsDataGetter data = new clsDataGetter();
        frmSettings Settings = new frmSettings();

        private void frmGlance_Activated(object sender, System.EventArgs e)
        {
            
        }

        public frmGlance()
        {
            InitializeComponent();

            if (DesktopWeather.Properties.Settings.Default.Display == "3")
            {
                //Start 8-day form
                //eight.ShowDialog();
                //Close this form
                //Close();
            }

            //  If Display == 2
            //  Start this form
            //  Carry on

            if (DesktopWeather.Properties.Settings.Default.Display == "1")
            {
                //Start Currently form
                weatherCurrently.ShowDialog();
                //Close this form
                Dispose();
                Close();
            }

            data.getLatLon();

            updateData();

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 3600000; // 1 Hour
            aTimer.Enabled = true;
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
            lblTodayTemp.Text = forecast[0].getSetHigh.ToString("0") + "/" + forecast[0].getSetLow.ToString("0") + "\u00B0" + forecast[0].Units;
            lblTomorrowTemp.Text = forecast[1].getSetHigh.ToString("0") + "/" + forecast[1].getSetLow.ToString("0") + "\u00B0" + forecast[1].Units;
            lblDayAfterTemp.Text = forecast[2].getSetHigh.ToString("0") + "/" + forecast[2].getSetLow.ToString("0") + "\u00B0" + forecast[2].Units;

            lblCurrentConditions.Text = forecast[9].getSetSummary;
            lblTodayConditions.Text = forecast[0].getSetSummary;
            lblTomorrowConditions.Text = forecast[1].getSetSummary;
            lblDayAfterConditions.Text = forecast[2].getSetSummary;

            pbCurrentConditions.Image = forecast[9].getIcon();
            pbTodayConditions.Image = forecast[0].getIcon();
            pbTomorrowConditions.Image = forecast[1].getIcon();
            pbDayAfterConditions.Image = forecast[2].getIcon();

            lblTodayDate.Text = forecast[0].getSetDate;
            lblTomorrowDate.Text = forecast[1].getSetDate;
            lblDayAfterDate.Text = forecast[2].getSetDate;

            lblLastUpdate.Text = "Last Updated: " + DateTime.Now.ToString();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forecast.io/");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings.ShowDialog();
        }
    }
}
