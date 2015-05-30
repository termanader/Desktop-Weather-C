using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DesktopWeather
{
    class clsForecast
    {
        string forecastUnits = "";

        string currentIcon = "";
        Bitmap currentImage = new Bitmap(Properties.Resources.clear_day);
        string currentSummary = "";
        float currentTemp = 0;
        
        string todayIcon = "";
        Bitmap todayImage = new Bitmap(Properties.Resources.clear_day);
        string todaySummary = "";
        float todayHigh = 0;
        float todayLow = 0;
        string todayDate;

        string tomorrowIcon = "";
        Bitmap tomorrowImage = new Bitmap(Properties.Resources.clear_day);
        string tomorrowSummary = "";
        float tomorrowHigh = 0;
        float tomorrowLow = 0;
        string tomorrowDate;

        string dayAfterIcon = "";
        Bitmap dayAfterImage = new Bitmap(Properties.Resources.clear_day);
        string dayAfterSummary = "";
        float dayAfterHigh = 0;
        float dayAfterLow = 0;
        string dayAfterDate;

        Bitmap icon_tmp = new Bitmap(Properties.Resources.cloudy);

        public void setIconCurrently(string value)
        {
            currentIcon = value;
        }

        public Bitmap getIconCurrently()
        {
            currentImage = convertIcon(currentIcon);
            return currentImage;
        }

        public void setIconToday(string value)
        {
            todayIcon = value;
        }

        public Bitmap getIconToday()
        {
            todayImage = convertIcon(todayIcon);
            return todayImage;
        }

        public void setIconTomorrow(string value)
        {
            tomorrowIcon = value;
        }

        public Bitmap getIconTomorrow()
        {
            tomorrowImage = convertIcon(tomorrowIcon);
            return tomorrowImage;
        }

        public void setIconDayAfter(string value)
        {
            dayAfterIcon = value;
        }

        public Bitmap getIconDayAfter()
        {
            dayAfterImage = convertIcon(dayAfterIcon);
            return dayAfterImage;
        }

        public Bitmap convertIcon(string icon)
        {
            switch (icon)
            {
                case "snow":
                    icon_tmp = Properties.Resources.snow;
                    break;
                case "sleet":
                    icon_tmp = Properties.Resources.sleet;
                    break;
                case "rain":
                    icon_tmp = Properties.Resources.rain;
                    break;
                case "partly-cloudy-night":
                    icon_tmp = Properties.Resources.party_cloudy_night;
                    break;
                case "partly-cloudy-day":
                    icon_tmp = Properties.Resources.partly_cloudy_day;
                    break;
                case "fog":
                    icon_tmp = Properties.Resources.fog;
                    break;
                case "cloudy":
                    icon_tmp = Properties.Resources.cloudy;
                    break;
                case "clear-night":
                    icon_tmp = Properties.Resources.clear_night;
                    break;
                case "clear-day":
                    icon_tmp = Properties.Resources.clear_day;
                    break;
                default:
                    icon_tmp = Properties.Resources.cloudy;
                    break;
            }
            return icon_tmp;
        }

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

        public float lowToday
        {
            get
            {
                return todayLow;
            }
            set
            {

                todayLow = value;
            }
        }

        public float lowTomorrow
        {
            get
            {
                return tomorrowLow;
            }
            set
            {

                tomorrowLow = value;
            }
        }

        public float lowDayAfter
        {
            get
            {
                return dayAfterLow;
            }
            set
            {

                dayAfterLow = value;
            }
        }

        public string dateToday
        {
            get
            {
                return todayDate;
            }
            set
            {
                todayDate = UnixTimeStampToDateTime(double.Parse(value));
            }
        }

        public string dateTomorrow
        {
            get
            {
                return tomorrowDate;
            }
            set
            {
                tomorrowDate = UnixTimeStampToDateTime(double.Parse(value));
            }
        }

        public string dateDayAfter
        {
            get
            {
                return dayAfterDate;
            }
            set
            {
                dayAfterDate = UnixTimeStampToDateTime(double.Parse(value));
            }
        }

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

        public static string UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            string stMonthDay = dtDateTime.Month + "/" + dtDateTime.Day;
            return stMonthDay;
        }
    }
}
