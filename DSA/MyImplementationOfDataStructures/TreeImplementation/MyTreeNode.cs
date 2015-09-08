namespace TreeImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents a tree node.
    /// </summary>
    /// <typeparam name="T">the type of the values in nodes</typeparam>
    public class MyTreeNode<T>
    {
        private T value;
        private bool hasParent;
        private List<MyTreeNode<T>> children;
        
        /// <summary>
        /// Constructs a tree node
        /// </summary>
        /// <param name="value">the value of the node</param>
        public MyTreeNode(T value)
        {
            this.Value = value;
            this.children = new List<MyTreeNode<T>>();
        }

        /// <summary>
        /// The value of the node
        /// </summary>
        public T Value 
        { 
            get
            {
                return this.value;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The value can not be null!");
                }

                this.value = value;
            }
        }

        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        /// <summary>
        /// Adds child to the node
        /// </summary>
        /// <param name="child"></param>
        public void AddChild(MyTreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value");
            }

            if (child.hasParent)
            {
                throw new ArgumentNullException("The node already has a parent");
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        /// <summary>
        /// Gets the child of the node at given index
        /// </summary>
        /// <param name="index">the index of the desired child</param>
        /// <returns>the child on the given position</returns>
        public MyTreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
    }
}
