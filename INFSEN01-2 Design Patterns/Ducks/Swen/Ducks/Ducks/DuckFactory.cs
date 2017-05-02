using Ducks.Behaviours.Fly;
using Ducks.Behaviours.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    class DuckFactory
    {
        public static Duck GetDuckByType(DuckType duckType)
        {
            switch(duckType)
            {
                case DuckType.RUBBER_DUCK:
                    return new Duck(
                        new NoFlyer(),
                        new MutedQuacker()
                    );
                case DuckType.FLYING_BUT_LOUD_DUCK:
                    return new Duck(
                        new GoodFlyer(),
                        new LoudQuacker()
                    );
                default:
                    throw new Exception("There is no duck defined with the type: " + duckType.ToString());
            }
        }
    }
}
