using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class TrouserPleats : GarmentDecorator
    {
        public TrouserPleats(IGarment garment) : base(garment)
        {
            
        }

        public override double ComputeCost()
        {
            return garment.ComputeCost() + 18.25d;
        }

        public override string GetDescription()
        {
            return garment.GetDescription() + ", trouser pleats";
        }
    }
}
