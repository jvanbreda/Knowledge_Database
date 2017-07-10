using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    interface IGarment
    {
        string GetDescription();
        double ComputeCost();
    }
}
