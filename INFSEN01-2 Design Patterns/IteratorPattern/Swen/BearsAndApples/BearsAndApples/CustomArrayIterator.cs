using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearsAndApples
{
    class CustomArrayIterator<T> : IIterator<T>
    {
        //public CustomArray<T> aggregate; Pass reference instead of queue?
        public Queue<T> Content { get; private set; }
        public CustomArrayIterator(T[] content)
        {
            Content = new Queue<T>();
            for (int i = 0; i < content.Length; i++)
            {
                Content.Enqueue(content[i]);
            }
        }
        public bool HasNext()
        {
            return Content.Count > 0;
        }

        public T Next()
        {
            return Content.Dequeue();
        }
    }
}
