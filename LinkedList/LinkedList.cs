using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T> : ILinkedList<T>
    {
        private class Node<T>
        {
            public T value;
            public Node<T> next;
            public Node(T value, Node<T> next = null)
            {
                this.value = value;
                this.next = next;
            }
        }
        public int Count { get; private set; }

        private Node<T> _head;
        private Node<T> _tail;

        public LinkedList()
        {
            Count = 0;
        }

        // O(1)
        public void Append(T value)
        {
            if (Count == 0)
            {
                _head = new(value);
                _tail = _head;
                Count++;
                return;
            }

            _tail.next = new(value);
            _tail = _tail.next;
            Count++;
        }



        public bool Delete(T value)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAll()
        {
            throw new NotImplementedException();
        }

        // Not complete
        public void Insert(int index, T value)
        {
            if (index > Count - 1)
            {
                throw new InvalidOperationException();
            }

            Node<T> prevNode;
            var tempHead = _head;
            for (int i = 0; i < Count && i == index; i++)
            {
                prevNode = tempHead;
                tempHead = tempHead.next;
            }

        }
    }
}
