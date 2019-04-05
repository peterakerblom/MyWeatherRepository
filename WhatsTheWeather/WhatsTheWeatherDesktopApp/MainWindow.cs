using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsTheWeatherDesktopApp
{
    public partial class MainWindow : Form
    {
        Controller c = new Controller();
        WeatherDAO weatherDAO = new WeatherDAO();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void helloWorldBtn_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = c.GetHelloWorld();
        }

        private void getDataBtn_Click(object sender, EventArgs e)
        {
            string city = enterCityTextBox.Text;
            weatherDAO = c.GetWeather(city);
            resultTextBox.Text = weatherDAO.Temp.ToString();
        }

        // WeatherData WarsawWeather = new WeatherData("Warsaw");
        //WarsawWeather.CheckWeather();
        //System.Console.WriteLine(WarsawWeather.Temp);
    }
}
