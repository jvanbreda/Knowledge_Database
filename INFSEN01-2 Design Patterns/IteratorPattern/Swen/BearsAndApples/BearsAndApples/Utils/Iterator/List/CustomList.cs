﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearsAndApples
{
    class CustomList<T> : IAggregate<T>
    {
        public T[] Content { get; private set; }
        public CustomList(T[] content)
        {
            Content = content;
        }

        public IIterator<T> GetIterator()
        {
            return new CustomArrayIterator<T>(Content);
        }
    }
}
