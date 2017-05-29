using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heating_element
{
    interface ITemperatureAdapter
    {
        double GetExpectedTime(double temp);
    }
}
