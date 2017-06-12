using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class WaistCoat : GarmentDecorator
    {
        public WaistCoat(IGarment garment) : base(garment)
        {

        }

        public double ComputeCost()
        {
            return garment.ComputeCost() + 32.00d;
        }

        public string GetDescription()
        {
            return garment.GetDescription() + ", waist coat";
        }
    }
}
