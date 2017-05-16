using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearsAndApples
{
    class Inventory
    {
        public IAggregate<Bear> Bears { get; set; }
        public IAggregate<Apple> Apples { get; set; }

        public void PrintInventory()
        {
            IIterator<Bear> bearIterator = Bears.GetIterator();
            IIterator<Apple> appleIterator = Apples.GetIterator();

            Console.WriteLine("At this moment the inventory consists of: ");
            while(bearIterator.HasNext())
            {
                Console.WriteLine(bearIterator.Next());
            }

            while (appleIterator.HasNext())
            {
                Console.WriteLine(appleIterator.Next());
            }
        }
    }
}
