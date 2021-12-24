using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Node <T> 
    {
        T val;
        Node<T> next;

        public int Count { get; private set; }


        public Node()
        {
        }

        public Node(T val, Node<T> node = null)
        {
            this.val = val;
            this.next = node;
            Count++;
        }

        public void Append(T val)
        {
            if (Count == 0)
            {
                this.val = val;
                Count++;
                return;
            }

            Node<T> head = this;

            Node<T> curr = head;
            Node<T> prev = null;
            
            while (curr != null)
            {
                prev = curr;
                curr = curr.next;
            }
            prev.next = new(val);
            Count++;
        }

        public bool Insert(int index, T val)
        {
            Node<T> head = this;
            if (Count == 0)
                return false;

            if (index > head.Count - 1)
            {
                return false;
            }

            var tempHead = head;
            Node<T> prevNode = null;
            for (int i = 0; tempHead.next != null && i < index; i++)
            {
                prevNode = tempHead;
                tempHead = tempHead.next; 
            }
            prevNode.next = new(val, prevNode.next);
            Count++;
            return true;
        }

        public bool Delete()
        {
            var tempHead = this;

            Node<T> prevNode = null;
            while(tempHead != null)
            {
                prevNode = tempHead;
                tempHead = tempHead.next;
                prevNode.next = null;
                Count--;
            }

            return true;
        }

        public void Print()
        {
            var tempHead = this;

            Console.WriteLine("---   LinkedList   ---");
            for (int i = 0; i < Count && tempHead != null; i++)
            {
                Console.WriteLine(tempHead.val);
                tempHead = tempHead.next;
            }
            Console.WriteLine("---   xxxxxxxxxx   ---");
        }

        //public Node<T> Merge(Node<T> rightLL)
        //{
        //    var leftLL = this;

        //    if (leftLL == null && rightLL == null)
        //        return null;

        //    if (leftLL == null)
        //        return rightLL;

        //    if (rightLL == null)
        //        return leftLL;

        //    // Merge code.

        //    int leftLLCounter = 0;
        //    int rightLLCounter = 0;
        //    while (leftLLCounter < leftLL.Count & rightLLCounter < rightLL.Count)
        //    {
        //        if (leftLL.val <= rightLL.val)
        //        {

        //        }
        //    }
        //}

        //public int CompareTo(T other)
        //{
        //    if (this.val == other.val)
        //    {
        //        return
        //    }
        //}
    }

    


    class Program
    {
        static void Main(string[] args)
        {
            Node<int> list = new();

            list.Append(1);
            list.Append(4);
            list.Append(6);

            list.Print();

            list.Insert(1, 11);

            list.Print();

            list.Delete();
            list.Print();
        }
    }
}
