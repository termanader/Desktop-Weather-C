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
        string date = "";
        float high = 0;
        string icon = "";
        Bitmap image = new Bitmap(Properties.Resources.clear_day);
        float low = 0;
        string summary = "";
        float temp = 0;

        Bitmap icon_tmp = new Bitmap(Properties.Resources.cloudy);

        public void setIcon(string value)
        {
            icon = value;
        }

        public Bitmap getIcon()
        {
            image = convertIcon(icon);
            return image;
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

        public string getSetSummary
        {
            get
            {
                return summary;
            }
            set
            {

                summary = value;
            }
        }
        
        public float getSetTemp
        {
            get
            {
                return temp;
            }
            set
            {

                temp = value;
            }
        }

        public float getSetHigh
        {
            get
            {
                return high;
            }
            set
            {

                high = value;
            }
        }

        public float getSetLow
        {
            get
            {
                return low;
            }
            set
            {

                low = value;
            }
        }

        public string getSetDate
        {
            get
            {
                return date;
            }
            set
            {
                date = UnixTimeStampToDateTime(double.Parse(value));
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
