using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks.Behaviours.Quack
{
    class MuteQuacker : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine();

            // Or throw an exception
            //throw new Exception("This duck cannot quack!");
        }
    }
}
