using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class TrouserCuffs : GarmentDecorator
    {
        public TrouserCuffs(IGarment garment) : base(garment)
        {

        }

        public override double ComputeCost()
        {
            return garment.ComputeCost() + 16.50d;
        }

        public override string GetDescription()
        {
            return garment.GetDescription() + ", trouser cuffs";
        }
    }
}
