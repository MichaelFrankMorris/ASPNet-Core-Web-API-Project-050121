using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNet_Core_Web_API_Project_050121.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            List<WeatherForecast> listForeCast = new List<WeatherForecast>();

            // Using a 1-based rather than zero-based start... because apparently we don't about the weather condition today?
            int i = 1;
            int holdtemp = 0;

            while (i <= 7)
            {
                WeatherForecast oneForeCast = new WeatherForecast();
                // Starting temp

                if (i == 1) holdtemp = 22;
                oneForeCast.Date = DateTime.Now.AddDays(i);
                oneForeCast.TemperatureC += holdtemp + rng.Next(-2, 4);
                // we're in Texas, pretend a spike if i = 3
                if (i == 3) oneForeCast.TemperatureC -= 10;
                oneForeCast.Summary = Summaries[0];
                if (oneForeCast.TemperatureC > 2) oneForeCast.Summary = Summaries[1];
                if (oneForeCast.TemperatureC > 5) oneForeCast.Summary = Summaries[2];
                if (oneForeCast.TemperatureC > 10) oneForeCast.Summary = Summaries[3];
                if (oneForeCast.TemperatureC > 15) oneForeCast.Summary = Summaries[4];
                if (oneForeCast.TemperatureC > 20) oneForeCast.Summary = Summaries[5];
                if (oneForeCast.TemperatureC > 25) oneForeCast.Summary = Summaries[6];
                if (oneForeCast.TemperatureC > 30) oneForeCast.Summary = Summaries[7];
                if (oneForeCast.TemperatureC > 35) oneForeCast.Summary = Summaries[8];
                i++;
                listForeCast.Add(oneForeCast);
                holdtemp = oneForeCast.TemperatureC;
            }

            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            List<WeatherForecast> test = listForeCast;

            return listForeCast.AsEnumerable();
        }
    }
}
