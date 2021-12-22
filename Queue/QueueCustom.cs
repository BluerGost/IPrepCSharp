using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class UnderflowException : Exception
    {
        public UnderflowException(string message):base(message)
        {

        }
    }
    internal class QueueCustom<T> : IQueueCustom<T>
    {
        private class Node<T>
        {
            public T value;
            public Node<T> next;

            public Node(T value, Node<T> node = null)
            {
                this.value = value;
                this.next = node;
            }
        }

        public int Count { get; private set; }
        private Node<T> _front;
        private Node<T> _back;
        public QueueCustom()
        {
            Count = 0;
        }
        public T Dequeue()
        {
            if (Count <= 0)
                throw new UnderflowException("Dequeue not possible in empty queue.");

            T tempVar = _front.value;
            _front = _front.next;
            return tempVar; ;
        }

        public void Enqueue(T value)
        {
            if(Count == 0)
            {
                _front = new(value);
                _back = _front;
                Count++;
                return;
            }

            _back.next = new(value);
            _back = _back.next;
            Count++;
        }

        public T Peek()
        {
            return _front.value;
        }
    }
}
