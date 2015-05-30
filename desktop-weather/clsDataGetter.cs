using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ForecastIO;
using System.Globalization;

namespace DesktopWeather
{
    class clsDataGetter
    {
        const string API_KEY = "";

        float flat = 0;
        float flon = 0;
        string lat = "";
        string lon = "";

        WebClient wcLatLon = new WebClient();

        public void getLatLon()
        {
            var data = wcLatLon.DownloadString("http://ip-api.com/json");
            JObject o = JObject.Parse(data);
            lat = o["lat"].ToString();
            lon = o["lon"].ToString();
            flat = float.Parse(lat, CultureInfo.InvariantCulture.NumberFormat);
            flon = float.Parse(lon, CultureInfo.InvariantCulture.NumberFormat);
        }

        public clsForecast getForecast(clsForecast forecast)
        {
            // API Key, Lat, Long, Unit
            var request = new ForecastIORequest(API_KEY, flat, flon, Unit.auto);
            var response = request.Get();

            forecast.setIconCurrently(response.currently.icon);
            forecast.summaryCurrently = response.currently.summary;
            forecast.tempCurrently = response.currently.temperature;

            forecast.setIconToday(response.daily.data[0].icon);
            forecast.summaryToday = response.daily.data[0].summary;
            forecast.highToday = response.daily.data[0].temperatureMax;

            forecast.setIconTomorrow(response.daily.data[1].icon);
            forecast.summaryTomorrow = response.daily.data[1].summary;
            forecast.highTomorrow = response.daily.data[1].temperatureMax;

            forecast.setIconDayAfter(response.daily.data[2].icon);
            forecast.summaryDayAfter = response.daily.data[2].summary;
            forecast.highDayAfter = response.daily.data[2].temperatureMax;

            forecast.Units = response.flags.units;
            return forecast;
        }
    }
}
