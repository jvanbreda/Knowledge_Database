using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class Pocket : GarmentDecorator
    {
        public Pocket(IGarment garment) : base(garment)
        {

        }

        public double ComputeCost()
        {
            return garment.ComputeCost() + 12.05d;
        }

        public string GetDescription()
        {
            return garment.GetDescription() + ", pocket";
        }
    }
}
