using System;

namespace Demos
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Previous { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }

    public class LinkedList2<T> : System.Collections.Generic.IEnumerable<T>
    {
        private LinkedListNode<T> Head { get; set; }
        private LinkedListNode<T> Tail { get; set; }
		
        public void AddLast(T value)
        {
            var newNode = new LinkedListNode<T>()
                {
                    Value = value
                };

            if (this.Head == null && this.Tail == null)
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            else
            {
                this.Tail.Next = newNode;
                newNode.Previous = this.Tail;
                this.Tail = newNode;
            }
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var node = this.Head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
