using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal interface IStackCustom<T>
    {
        public void Push(T value);
        public T Pop();
        public T Peek();
    }
}
