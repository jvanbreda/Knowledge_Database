using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks.Behaviours.Fly
{
    class NoFlyer : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This duck can't fly!");

            // Or throw an exception
            //throw new Exception("This duck can't fly!");
        }
    }
}
