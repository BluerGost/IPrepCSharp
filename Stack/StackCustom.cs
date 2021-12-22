using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class StackCustom<T> : IStackCustom<T>
    {
        public int MyProperty { get; set; }
        public StackCustom()
        {

        }
        public T Peek()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T value)
        {
            throw new NotImplementedException();
        }
    }
}
