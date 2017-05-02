using Ducks.Behaviours.Fly;
using Ducks.Behaviours.Quack;
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
        IQuackBehaviour mouth;

        public Duck(IFlyBehaviour wings, IQuackBehaviour mouth)
        {
            this.wings = wings;
            this.mouth = mouth;
        }

        public void Fly()
        {
            this.wings.Fly();
        }

        public void Quack()
        {
            this.mouth.Quack();
        }
    }
}
