namespace QueueImplementation
{
    using System;    
    using DoubleListImplementation;
    using System.Collections.Generic;
    using System.Collections;

    public class MyQueue<T> : IEnumerable<T>
    {
        private MyLinkedList<T> elements = null;       

        public MyQueue()
        {
            this.elements = new MyLinkedList<T>();
        }

        public int Count 
        { 
            get
            {
                return this.elements.Count;
            }
        }

        public void Enqueue(T element)
        {
            this.elements.AddLast(element);
        }

        public T Peek()
        {
            if (elements.Count <= 0 )
	        {
		        throw new ArgumentNullException("The MyQueue is empty!");
	        }

            return this.elements.FirstValue();
        }
        public T Dequeue()
        {
            T value = this.Peek();
            this.elements.RemoveFirst();

            return value;
        }

        public void Clear()
        {
            this.elements = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var node in this.elements)
            {
                yield return node;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {            
            return string.Join(" ", this.elements);
        }
    }
}
