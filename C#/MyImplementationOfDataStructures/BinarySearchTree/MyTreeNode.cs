namespace BinarySearchTree
{
    using System;

    public class MyTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public MyTreeNode<T> LeftChild { get; set; }
        public MyTreeNode<T> RightChild { get; set; }
        public MyTreeNode<T> Parent { get; set; }

        public MyTreeNode(T value)
        {
            this.Value = value;
            this.LeftChild = null;
            this.RightChild = null;
            this.Parent = null;
        }

        public override string ToString()
        {
            return string.Format("Value->{0} ", this.Value);
        }
    }
}
