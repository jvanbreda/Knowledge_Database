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

        public override double ComputeCost()
        {
            return base.ComputeCost() + 12.05d;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", pocket";            
        }
    }
}
