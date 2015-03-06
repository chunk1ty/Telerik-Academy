namespace DoubleListImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyLinkedList<T> : IEnumerable<T> 
        //where T : IComparable<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Count { get; private set; }

        public MyLinkedList()
        {
            this.Count = 0;
            this.Head = null;
            this.Tail = null;
        }

        public void AddFirst(T value)
        {
            var currentNode = new Node<T>(value);

            if (this.Head == null && this.Tail == null)
            {
                this.Head = currentNode;
                this.Tail = currentNode;
            }
            else
            {
                currentNode.Next = this.Head;
                this.Head.Previous = currentNode;
                this.Head = currentNode;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            var currentNode = new Node<T>(value);

            if (this.Head == null && this.Tail == null)
            {
                this.Head = currentNode;
                this.Tail = currentNode;
            }
            else
            {
                currentNode.Previous = this.Tail;
                this.Tail.Next = currentNode;
                this.Tail = currentNode;
            }

            this.Count++;
        }

        public void RemoveFirst()
        {
            if (this.Count <= 0)
            {
                throw new ArgumentNullException("The MyLinkedList is empty");
            }

            if (this.Count == 1)
            {
                this.Head = null;
                this.Tail = null;
            }

            this.Head = this.Head.Next;
            this.Head.Previous = null;

            this.Count--;
        }

        public void RemoveLast()
        {
            if (this.Count <= 0)
            {
                throw new ArgumentNullException("The MyLinkedList is empty");
            }

            if (this.Count == 1)
            {
                this.Head = null;
                this.Tail = null;
            }

            this.Tail = this.Tail.Previous;
            this.Tail.Next = null;

            this.Count--;
        }

        public T Find(T value)
        {
            for (var currentNode = this.Head; currentNode != null; currentNode = currentNode.Next)
            {
                if (value.Equals(currentNode.Value))
                {
                    return currentNode.Value;
                }
            }

            return default(T);
        }

        public void Clear()
        {
            this.Head = null;
            this.Tail = null;
        }

        public T FirstValue()
        {
            return this.Head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var currentNode = this.Head; currentNode != null; currentNode = currentNode.Next)
            {
                yield return currentNode.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
