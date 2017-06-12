using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class Shorts : GarmentDecorator
    {
        public Shorts(IGarment garment) : base(garment)
        {

        }

        public double ComputeCost()
        {
            return garment.ComputeCost() + 15.50d;
        }

        public string GetDescription()
        {
            return garment.GetDescription() + ", shorts";
        }
    }
}
