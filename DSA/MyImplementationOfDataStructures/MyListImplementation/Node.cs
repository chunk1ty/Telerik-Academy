namespace MyListImplementation
{
    using System;
    
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
        }

        public override string ToString()
        {
            return string.Format("Value -> {0}", this.Value);
        }
    }
}
