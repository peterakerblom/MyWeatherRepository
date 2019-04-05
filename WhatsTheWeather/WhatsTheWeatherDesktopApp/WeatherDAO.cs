using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService;
using System.Xml;
using System.Net;

namespace WhatsTheWeatherDesktopApp
{
    class WeatherDAO
    {
        public WeatherDAO()
        {

        }
        public WeatherDAO(string City)
        {
            city = City;
        }
        private string city;
        private float temp;
        private float tempMax;
        private float tempMin;

        public void CheckWeather()
        {
            WeatherAPI DataAPI = new WeatherAPI(City);
            temp = DataAPI.GetTemp();
        }

        public string City { get => city; set => city = value; }
        public float Temp { get => temp; set => temp = value; }
        public float TempMax { get => tempMax; set => tempMax = value; }
        public float TempMin { get => tempMin; set => tempMin = value; }

        public string WeatherHelloWorld() //Test method
        {
            WeatherServiceASMX service = new WeatherServiceASMX();
            string hw = service.HelloWorld();
            return hw;
        }
    }
    class WeatherAPI
    {
        public WeatherAPI(string city)
        {
            SetCurrentURL(city);
            xmlDocument = GetXML(CurrentURL);
        }

        public float GetTemp()
        {
            System.Globalization.CultureInfo usCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            XmlNode temp_node = xmlDocument.SelectSingleNode("//temperature");
            XmlAttribute temp_value = temp_node.Attributes["value"];
            string temp_string = temp_value.Value;
            return float.Parse(temp_string, usCulture);
        }

        private const string APIKEY = "f83067ab6f4665f0d882b861dc4cc49f";
        private string CurrentURL;
        private XmlDocument xmlDocument;

        private void SetCurrentURL(string location)
        {
            CurrentURL = "http://api.openweathermap.org/data/2.5/weather?q="
                + location + "&mode=xml&units=metric&APPID=" + APIKEY;
        }

        private XmlDocument GetXML(string CurrentURL)
        {
            using (WebClient client = new WebClient())
            {
                string xmlContent = client.DownloadString(CurrentURL);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlContent);
                return xmlDocument;
            }
        }
    }
}
