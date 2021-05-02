using System;

namespace ASPNet_Core_Web_API_Project_050121
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        // Below is a stylistic change which doesn't affect the results of this particular program...
        // But mathematically *(1.8), *(9/5), /(5/9) would all have been 'better' than /.5556....
        
        public int TemperatureF => 32 + (int)(TemperatureC * 1.8);

        public string Summary { get; set; }
    }
}
