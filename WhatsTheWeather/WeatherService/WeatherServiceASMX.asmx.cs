using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net;
using System.Web.Script.Serialization;
using System.Xml;


namespace WeatherService
{
    /// <summary>
    /// Summary description for WeatherServiceASMX
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WeatherServiceASMX : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public void GetWeatherInfo(string city)
        {
            string appId = "f83067ab6f4665f0d882b861dc4cc49f";
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&mode=xml&units=metric&cnt=1&APPID={1}", city, appId);
            using (WebClient client = new WebClient())
            {
                // kolla: https://codereview.stackexchange.com/questions/150981/getting-weather-data-from-open-weather-map-api;
            }
        }
    }
}
