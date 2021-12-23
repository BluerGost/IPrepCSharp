using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class StackCustom<T> : IStackCustom<T>
    {
        /// <summary>
        /// A single node in stack.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class Node<T>
        {
            internal T value;
            internal Node<T> next;

            public Node(T value, Node<T> next = null)
            {
                this.value = value;
                this.next = next;
            }
        }

        /// <summary>
        /// Total number of items in stack.
        /// </summary>
        public int Count { get; set; }
        
        /// <summary>
        /// Top of the stack
        /// </summary>
        private Node<T> _top;
        
        public StackCustom()
        {
            Count = 0;
        }
        public T Peek()
        {
            return _top.value;
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            var result = _top.value;
            _top = _top.next;
            Count--;
            return result;
        }

        /// <summary>
        /// Push the value at the top of the stack.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            if(Count == 0)
            {
                _top = new(value);
                Count++;
                return;
            }

            var newNode = new Node<T>(value);
            newNode.next = _top;
            _top = newNode;
            Count++;
        }
    }
}
