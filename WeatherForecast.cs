using System;

namespace ASPNet_Core_Web_API_Project_050121
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC * 1.8);

        public string Summary { get; set; }
    }
}
