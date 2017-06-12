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

        public override double ComputeCost()
        {
            return garment.ComputeCost() + 24.00d;
        }

        public override string GetDescription()
        {
            return garment.GetDescription() + ", lining";
        }
    }
}
