namespace DoubleListImplementation
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public T Value { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
            this.Previous = null;
        }

        public override string ToString()
        {
            return string.Format("Value -> {0}", this.Value);
        }
    }
}
