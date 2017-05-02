using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construct some ducks
            var rubberDuck = DuckFactory.GetDuckByType(DuckType.RUBBER_DUCK);
            var flyingDuck = DuckFactory.GetDuckByType(DuckType.FLYING_BUT_LOUD_DUCK);

            // Keep the console open until a key is pressed
            Console.Read();
        }
    }
}
