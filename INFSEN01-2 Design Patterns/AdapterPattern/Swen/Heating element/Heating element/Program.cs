using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heating_element
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal human temperature
            var celcius = 36.8d;
            var fahrenheit = 98.24d;
            var kelvin = 309.95d;

            // It should print the same values
            // Adapter for celcius
            ITemperatureAdapter celciusTemperatureAdapter = new CelciusTemperatureAdapter(new Model());
            Console.WriteLine("Input celcius - Expected time: {0}", celciusTemperatureAdapter.GetExpectedTime(celcius));

            // Adapter for fahrenheit
            ITemperatureAdapter fahrenheitTemperatureAdapter = new FahrenheitTemperatureAdapter(new Model());
            Console.WriteLine("Input fahrenheit - Expected time: {0}", fahrenheitTemperatureAdapter.GetExpectedTime(fahrenheit));

            // Adapter for kelvin
            ITemperatureAdapter kelvinTemperatureAdapter = new KelvinTemperatureAdapter(new Model());
            Console.WriteLine("Input kelvin - Expected time: {0}", kelvinTemperatureAdapter.GetExpectedTime(kelvin));            

            // Halt program
            Console.Read();
        }
    }
}
