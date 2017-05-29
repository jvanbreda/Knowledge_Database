using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heating_element
{
    class KelvinTemperatureAdapter : ITemperatureAdapter
    {
        private Model heatingModel;
        public KelvinTemperatureAdapter(Model heatingModel)
        {
            this.heatingModel = heatingModel;
        }
        public double GetExpectedTime(double temp)
        {
            var celcius = temp - 273.15;
            return heatingModel.ComputeExpectedTime(celcius);
        }
    }
}
