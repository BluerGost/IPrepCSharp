using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface ILinkedList<T>
    {
        void Append(T value);
        void Insert(int index, T value);
        bool Delete(T value);
        bool DeleteAll();
    }
}
