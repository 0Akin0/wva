using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wva
{
    public class WeatherData
    {
        public WeatherData() {
        }

        public WeatherData(double temperature, int windStrength, WeatherStatus status) {
            Temperature = temperature;
            WindStrength = windStrength;
            Status = status;
        }
        /// <summary>
        /// Temperature in Celsius. Example: 23°C
        /// </summary>
        public double Temperature { get; set; }
        /// <summary>
        /// Wind strength in km per hour. Example: 50 km/h
        /// </summary>
        public int WindStrength { get; set; }
        public WeatherStatus Status { get; set; }
    }
}
