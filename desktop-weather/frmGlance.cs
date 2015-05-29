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
            forecast = data.getForecast(forecast);

            lblCurrentTemp.Text = forecast.tempCurrently.ToString() + "\u00B0" + forecast.Units;
            lblTodayHigh.Text = forecast.highToday.ToString() + "\u00B0" + forecast.Units;
            lblTomorrowHigh.Text = forecast.highTomorrow.ToString() + "\u00B0" + forecast.Units;
            lblDayAfterHigh.Text = forecast.highDayAfter.ToString() + "\u00B0" + forecast.Units;

            lblCurrentConditions.Text = forecast.summaryCurrently;
            lblTodayConditions.Text = forecast.summaryToday;
            lblTomorrowConditions.Text = forecast.summaryTomorrow;
            lblDayAfterConditions.Text = forecast.summaryDayAfter;
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
    }
}
