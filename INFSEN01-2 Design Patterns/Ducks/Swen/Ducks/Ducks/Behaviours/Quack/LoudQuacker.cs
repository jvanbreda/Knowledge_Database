using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks.Behaviours.Quack
{
    class LoudQuacker : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("QUACK QUACK QUACK");
        }
    }
}
