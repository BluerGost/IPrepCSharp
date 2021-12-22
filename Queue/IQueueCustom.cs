using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal interface IQueue<T>
    {
        public void Enqueue(T value);
        public T Dequeue();
        public T Peek();
    }
}
