using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask.models
{
    internal class TemperatureConverter
    {
        public double Celsius { get; set; }
        public double Farhanheit { get; set; }

      

        public void ConvertToFhranheit()
        {
            double Fahranheit = ( Celsius * 9 / 5)  + 32;
            Console.WriteLine($"Converted to Faranheit = {Fahranheit}");
        }
        public void ConvertToCelsius()
        {
            double celsius = (Farhanheit - 32) * 5 / 9;
            Console.WriteLine($"Converted to celcius = {celsius}");
        }
    }
}
