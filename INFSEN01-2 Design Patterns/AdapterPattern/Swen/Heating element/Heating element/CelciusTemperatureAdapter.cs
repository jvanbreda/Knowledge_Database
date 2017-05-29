using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heating_element
{
    class CelciusTemperatureAdapter : ITemperatureAdapter
    {
        private Model heatingModel;
        public CelciusTemperatureAdapter(Model heatingModel)
        {
            this.heatingModel = heatingModel;
        }
        public double GetExpectedTime(double temp)
        {
            return heatingModel.ComputeExpectedTime(temp);
        }
    }
}
