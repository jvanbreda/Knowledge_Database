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

        public override double ComputeCost()
        {
            return garment.ComputeCost() + 14.00d;
        }

        public override string GetDescription()
        {
            return garment.GetDescription() + ", breast pocket";
        }
    }
}
