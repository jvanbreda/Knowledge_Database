using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Duck
    {
        IFlyBehaviour wings;

        public Duck(IFlyBehaviour wings)
        {
            this.wings = wings;
        }

        public void Fly()
        {
            this.wings.Fly();
        }
    }
}
