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
                        new Bear() { Name = "Shrek bear", Origin = "The Swamp, get out of it" },
                        new Bear() { Name = "xXx_ThatBear420_xXx", Origin = "Straight out of the MLG scene" }
                    }
                ),
                Apples = new CustomList<Apple>(
                    new Apple[] {
                        new Apple() { Name = "Swamp apple", Origin = "Shrek's swamp" },
                        new Apple() { Name = "Rotten apple", Origin = "Your average supermarket" }
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
