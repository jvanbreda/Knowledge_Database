using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearsAndApples
{
    class Apple
    {
        public string Name { get; set; }
        public string Origin { get; set; }

        public override string ToString()
        {
            return string.Format("[Apple(Name: {0}; Origin: {1};)]", Name, Origin);
        }
    }
}
