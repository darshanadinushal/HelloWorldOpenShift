using System;

namespace HelloWorldOpenShift
{
    public class WeatherForecast
    {
        public string Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string HostMachine { get; set; }


    }
}
