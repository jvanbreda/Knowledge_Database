using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class LinenSuit : IGarment
    {
        public double ComputeCost()
        {
            return 142.00d;
        }

        public string GetDescription()
        {
            return "Linen suit";
        }
    }
}
