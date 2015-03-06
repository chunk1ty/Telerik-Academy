namespace PriorityQueueImplementation
{
    ﻿using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private readonly BinaryHeap<T> heap;

        public PriorityQueue(bool minPriority)
        {
            this.heap = new BinaryHeap<T>(minPriority);
        }

        public T Peek()
        {
            return this.heap.First();
        }

        public void Enqueue(T element)
        {
            this.heap.Add(element);
        }

        public T Dequeue()
        {
            var element = this.heap.First();
            this.heap.DeleteFirst();
            return element;
        }
    }
}