using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class BreastPocket : GarmentDecorator
    {
        public BreastPocket(IGarment garment) : base(garment)
        {

        }

        public double ComputeCost()
        {
            return garment.ComputeCost() + 14.00d;
        }

        public string GetDescription()
        {
            return garment.GetDescription() + ", breast pocket";
        }
    }
}
