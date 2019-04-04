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
        WeatherDAO wa = new WeatherDAO();

        public string GetHelloWorld()
        {
            string hello = wa.WeatherHelloWorld();
            return hello;
        }
    }
}
