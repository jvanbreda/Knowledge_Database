using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heating_element
{
    class FahrenheitTemperatureAdapter : ITemperatureAdapter
    {
        private Model heatingModel;
        public FahrenheitTemperatureAdapter(Model heatingModel)
        {
            this.heatingModel = heatingModel;
        }
        public double GetExpectedTime(double temp)
        {
            var celcius = (temp - 32) * 5 / 9;
            return heatingModel.ComputeExpectedTime(celcius);
        }
    }
}
