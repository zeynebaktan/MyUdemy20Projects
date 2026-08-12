using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project13_WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/fivedaysforcast?latitude=40.730610&longitude=-73.935242&lang=EN"),
                Headers =
    {
        { "x-rapidapi-key", "38545cd9a7msheda551046ddee02p1938aejsn0d5a5c1fc774" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var fahrenHeit = json["list"][0]["main"]["feels_like"].ToString();
                var windSpeed = json["list"][0]["wind"]["speed"].ToString();
                var humidity = json["list"][0]["main"]["humidity"].ToString();
                lblFahrenHeit.Text = fahrenHeit;
                lblWindSpeed.Text = windSpeed;
                lblHumidity.Text = humidity;
                decimal celcius = decimal.Parse(fahrenHeit) - 273.15m;
                lblCelsius.Text = celcius.ToString("0.0");
            }
        }
    }
}
