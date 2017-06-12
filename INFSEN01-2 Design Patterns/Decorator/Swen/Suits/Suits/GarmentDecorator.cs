using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class GarmentDecorator : IGarment
    {
        protected IGarment garment;
        public GarmentDecorator(IGarment garment)
        {
            this.garment = garment;
        }

        public virtual double ComputeCost()
        {
            return garment.ComputeCost();
        }

        public virtual string GetDescription()
        {
            return garment.GetDescription();
        }
    }
}
