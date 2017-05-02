using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class GoodFlyer : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This duck is now flying!");
        }
    }
}
