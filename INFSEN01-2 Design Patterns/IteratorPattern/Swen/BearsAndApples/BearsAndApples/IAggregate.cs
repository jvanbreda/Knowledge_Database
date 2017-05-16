using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearsAndApples
{
    interface IAggregate<T>
    {
        IIterator<T> GetIterator();
    }
}
