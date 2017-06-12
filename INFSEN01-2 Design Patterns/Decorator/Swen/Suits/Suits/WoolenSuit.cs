using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class WoolenSuit : IGarment
    {
        public double ComputeCost()
        {
            return 120.00d;
        }

        public string GetDescription()
        {
            return "woolen suit";
        }
    }
}
