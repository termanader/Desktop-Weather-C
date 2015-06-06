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

        clsForecast current = new clsForecast();
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

        public clsForecast[] getForecast(clsForecast[] forecast)
        {
            // API Key, Lat, Long, Unit
            var request = new ForecastIORequest(API_KEY, flat, flon, Unit.auto);
            var response = request.Get();

            for (int i = 0; i < 8; i++)
            {
                clsForecast tempForecast = new clsForecast();
                tempForecast.setIcon(response.daily.data[i].icon);
                tempForecast.getSetSummary = response.daily.data[i].summary;
                tempForecast.getSetHigh = response.daily.data[i].temperatureMax;
                tempForecast.getSetLow = response.daily.data[i].temperatureMin;
                tempForecast.getSetDate = response.daily.data[i].time.ToString();
                tempForecast.Units = response.flags.units;

                forecast[i] = tempForecast;
            }

            current.setIcon(response.currently.icon);
            current.getSetSummary = response.currently.summary;
            current.getSetTemp = response.currently.temperature;

            current.Units = response.flags.units;

            forecast[9] = current;
            return forecast;
        }
    }
}
