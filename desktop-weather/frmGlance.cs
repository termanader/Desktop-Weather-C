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
        clsForecast forecast = new clsForecast();
        clsDataGetter data = new clsDataGetter();

        public frmGlance()
        {
            InitializeComponent();
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

            lblCurrentTemp.Text = forecast.tempCurrently.ToString() + "\u00B0" + forecast.Units;
            lblTodayTemp.Text = forecast.highToday.ToString("0") + "/" + forecast.lowToday.ToString("0") + "\u00B0" + forecast.Units;
            lblTomorrowTemp.Text = forecast.highTomorrow.ToString("0") + "/" + forecast.lowTomorrow.ToString("0") + "\u00B0" + forecast.Units;
            lblDayAfterTemp.Text = forecast.highDayAfter.ToString("0") + "/" + forecast.lowDayAfter.ToString("0") + "\u00B0" + forecast.Units;

            lblCurrentConditions.Text = forecast.summaryCurrently;
            lblTodayConditions.Text = forecast.summaryToday;
            lblTomorrowConditions.Text = forecast.summaryTomorrow;
            lblDayAfterConditions.Text = forecast.summaryDayAfter;

            pbCurrentConditions.Image = forecast.getIconCurrently();
            pbTodayConditions.Image = forecast.getIconToday();
            pbTomorrowConditions.Image = forecast.getIconTomorrow();
            pbDayAfterConditions.Image = forecast.getIconDayAfter();

            lblTodayDate.Text = forecast.dateToday;
            lblTomorrowDate.Text = forecast.dateTomorrow;
            lblDayAfterDate.Text = forecast.dateDayAfter;

            lblLastUpdate.Text = "Last Updated: " + DateTime.Now.ToString();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forecast.io/");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
