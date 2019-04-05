using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService;


namespace WhatsTheWeatherDesktopApp
{

    class Controller
    {
        
        

        public string GetHelloWorld()
        {
            string hello = "HelloWorld";
            return hello;
        }

        public WeatherDAO GetWeather(string tempCity)
        {
            WeatherDAO wa = new WeatherDAO(tempCity);
            wa.CheckWeather();
            return wa;
        }
    }
}
