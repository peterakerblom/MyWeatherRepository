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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void helloWorldBtn_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = c.GetHelloWorld();
        }
    }
}
