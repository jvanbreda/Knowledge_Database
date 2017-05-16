using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearsAndApples
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory()
            {
                Bears = new CustomArray<Bear>(
                    new Bear[] {
                        new Bear() { Name = "Shrek bear", Origin = "The Swamp, get out of it", Stock = 420, Price = 0 },
                        new Bear() { Name = "Another bear", Origin = "Some toy shop", Stock = 120, Price = 5.60d }
                    }
                ),
                Apples = new CustomList<Apple>(
                    new Apple[] {
                        new Apple() { Name = "Pink Lady", Origin = "Australia", Stock = 1600, Price = 0.60d },
                        new Apple() { Name = "Fuji apple", Origin = "Japan", Stock = 2500, Price = 0.55d },
                        new Apple() { Name = "Rotten apple", Origin = "Your average supermarket", Stock = 3, Price = 0.10d }
                    }
                )
            };

            // Print the items in the collections
            inventory.PrintInventory();

            // Wait till user input
            Console.Read();
        }
    }
}
