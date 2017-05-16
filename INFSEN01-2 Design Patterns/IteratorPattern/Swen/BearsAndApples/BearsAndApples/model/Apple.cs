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
        public int Stock { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return string.Format("[Apple(Name: {0}; Origin: {1}; Stock: {2}; Price: {3};)]", Name, Origin, Stock, Price);
        }
    }
}
