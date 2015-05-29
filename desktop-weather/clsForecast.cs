using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopWeather
{
    class clsForecast
    {
        string forecastUnits = "";

        string currentIcon = "";
        string currentSummary = "";
        float currentTemp = 0;
        
        string todayIcon = "";
        string todaySummary = "";
        float todayHigh = 0;

        string tomorrowIcon = "";
        string tomorrowSummary = "";
        float tomorrowHigh = 0;

        string dayAfterIcon = "";
        string dayAfterSummary = "";
        float dayAfterHigh = 0;

        #region Forecast Icons
        public string iconCurrently
        {
            get
            {
                return currentIcon;
            }
            set
            {

                currentIcon = value;
            }
        }

        public string iconToday
        {
            get
            {
                return todayIcon;
            }
            set
            {

                todayIcon = value;
            }
        }

        public string iconTomorrow
        {
            get
            {
                return tomorrowIcon;
            }
            set
            {

                tomorrowIcon = value;
            }
        }

        public string iconDayAfter
        {
            get
            {
                return dayAfterIcon;
            }
            set
            {

                dayAfterIcon = value;
            }
        }
        #endregion

        #region Forecast Summaries
        public string summaryCurrently
        {
            get
            {
                return currentSummary;
            }
            set
            {

                currentSummary = value;
            }
        }

        public string summaryToday
        {
            get
            {
                return todaySummary;
            }
            set
            {

                todaySummary = value;
            }
        }

        public string summaryTomorrow
        {
            get
            {
                return tomorrowSummary;
            }
            set
            {

                tomorrowSummary = value;
            }
        }

        public string summaryDayAfter
        {
            get
            {
                return dayAfterSummary;
            }
            set
            {

                dayAfterSummary = value;
            }
        }
        #endregion

        #region Forecast Temperatures
        public float tempCurrently
        {
            get
            {
                return currentTemp;
            }
            set
            {

                currentTemp = value;
            }
        }

        public float highToday
        {
            get
            {
                return todayHigh;
            }
            set
            {

                todayHigh = value;
            }
        }

        public float highTomorrow
        {
            get
            {
                return tomorrowHigh;
            }
            set
            {

                tomorrowHigh = value;
            }
        }

        public float highDayAfter
        {
            get
            {
                return dayAfterHigh;
            }
            set
            {

                dayAfterHigh = value;
            }
        }
        #endregion

        public string Units
        {
            get
            {
                if (forecastUnits == "si") {
                    return "C";
                } else {
                    return "F";
                }
            }
            set
            {
                forecastUnits = value;
            }
        }
    }
}
