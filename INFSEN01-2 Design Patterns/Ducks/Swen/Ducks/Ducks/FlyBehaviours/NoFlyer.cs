using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class NoFlyer : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This duck can't fly!");
        }
    }
}
