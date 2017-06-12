using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class Lining : GarmentDecorator
    {
        public Lining(IGarment garment) : base(garment)
        {

        }

        public double ComputeCost()
        {
            return garment.ComputeCost() + 24.00d;
        }

        public string GetDescription()
        {
            return garment.GetDescription() + ", lining";
        }
    }
}
