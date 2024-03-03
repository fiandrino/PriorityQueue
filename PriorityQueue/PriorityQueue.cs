using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueue
{
    public class PriorityQueue<T> where T : class, IComparable<T>
    {
        private List<T> _heapTree;

        public PriorityQueue()
        {
            _heapTree = new List<T>();
        }

        public void Enqueue(T item)
        {
            _heapTree.Add(item);
            _heapTree.Sort();
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = _heapTree[0];
            _heapTree.RemoveAt(0);
            return item;
        }

        public bool IsEmpty()
        {
            return _heapTree.Count == 0;
        }

        public T Min()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _heapTree[0];
        }

        public T Max()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _heapTree[_heapTree.Count - 1];
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _heapTree[0];
        }
    }
}
