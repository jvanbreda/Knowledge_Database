using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits
{
    class Program
    {
        static void Main(string[] args)
        {
            var endGameSuit = new BreastPocket(new Lining(new Pocket(new Shorts(new TrouserCuffs(new TrouserPleats(new WaistCoat(new LinenSuit()))))))); // Dat shi cray
            var specialPocketSuit = new Pocket(new Pocket(new Pocket(new Pocket(new Pocket(new WoolenSuit())))));

            Console.WriteLine("End game suit");
            Console.WriteLine(endGameSuit.GetDescription());
            Console.WriteLine(endGameSuit.ComputeCost());

            Console.WriteLine("The 'you can never have too pockets suit'");
            Console.WriteLine(specialPocketSuit.GetDescription());
            Console.WriteLine(specialPocketSuit.ComputeCost());
        }
    }
}
