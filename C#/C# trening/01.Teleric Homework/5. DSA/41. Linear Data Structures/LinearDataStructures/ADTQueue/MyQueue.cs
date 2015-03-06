namespace ADTQueue
{
    using System;
    using System.Collections.Generic;

    public class MyQueue<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Count { get; set; }

        public MyQueue()
        {
            this.Count = 0;
        }

        public void Enqueue(T value)
        {
            var newElement = new Node<T> { Value = value };

            if (this.Head == null && this.Tail == null)
            {
                this.Head = newElement;
                this.Tail = newElement;
            }
            else
            {
                this.Tail.Next = newElement;                
                this.Tail = newElement;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Head == null)
            {
                throw new ArgumentException();
            }

            T result = this.Head.Value;
            this.Head = this.Head.Next;
            this.Count--;

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = this.Head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }
    }
}
