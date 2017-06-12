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

        public double ComputeCost()
        {
            return garment.ComputeCost() + 16.50d;
        }

        public string GetDescription()
        {
            return garment.GetDescription() + ", trouser cuffs";
        }
    }
}
