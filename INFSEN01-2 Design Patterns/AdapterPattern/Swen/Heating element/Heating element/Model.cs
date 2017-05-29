using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heating_element
{
    class Model
    {
        public double ComputeExpectedTime(double tempCelcius)
        {
            return tempCelcius * 10;
        }
    }
}
