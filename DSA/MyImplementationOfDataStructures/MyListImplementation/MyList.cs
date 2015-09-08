namespace MyListImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private int size;

        private Node<T> Head { get; set; }
        public int Count
        {
            get
            {
                return this.size;
            }
            private set
            {
                this.size = value;
            }
        }

        public MyList()
        {
            this.Count = 0;
            this.Head = null;
        }

        public void AddFirst(T value)
        {
            var newNode = new Node<T>(value);

            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {                
                newNode.Next = this.Head;
                this.Head = newNode;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);

            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {                
                Node<T> lastNode = this.Head;

                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }

                lastNode.Next = newNode;
            }

            this.Count++;
        }

        public void RemoveFirst()
        {
            if (this.Count <= 0)
            {
                throw new ArgumentNullException("My list is Empty");
            }

            this.Head = this.Head.Next;
            this.Count--;
        }

        public void RemoveLast()
        {
            var lastNode = this.Head;

            while (lastNode.Next != null)
            {
                lastNode = lastNode.Next;
            }

            var node = this.Head;

            while (node.Next != lastNode)
            {
                node = node.Next;
            }

            node.Next = null;

            this.Count--;
        }

        public T Find(T value)
        {
            for (var currentNode = this.Head; currentNode != null; currentNode = currentNode.Next)
            {
                if (value.CompareTo(currentNode.Value) == 0)
                {
                    return currentNode.Value;
                }
            }

            return default(T);
        }

        public void Clear()
        {
            this.Head = null;            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var current = this.Head; current != null; current = current.Next)
            {
                yield return current.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
