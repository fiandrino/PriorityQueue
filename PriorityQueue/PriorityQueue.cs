﻿using System;
using System.Collections.Generic;

namespace PriorityQueue
{

    /// <summary>
    /// This class represents a priority queue where T is a generic type parameter. 
    /// The type T must implement the IComparable<T> interface, ensuring that items
    /// can be compared for ordering.
    /// </summary>
    /// <typeparam name="T">T must implement the IComparable<T> interface</typeparam>
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> _heapTree;

        public PriorityQueue()
        {
            _heapTree = new List<T>();
        }

        /// <summary>
        /// Adds an item to the priority queue.
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            _heapTree.Add(item);
            _heapTree.Sort();
        }

        /// <summary>
        /// Removes and returns the item with the highest priority.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Checks if the priority queue is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return _heapTree.Count == 0;
        }

        /// <summary>
        /// Returns the item with the minimum priority (highest value)
        /// </summary>
        /// <returns></returns>
        public T Min()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _heapTree[0];
        }

        /// <summary>
        /// Returns the item with the maximum priority (lowest value)
        /// </summary>
        /// <returns></returns>
        public T Max()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _heapTree[_heapTree.Count - 1];
        }

        /// <summary>
        ///  Returns the item with the highest priority without removing it
        /// </summary>
        /// <returns></returns>
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
