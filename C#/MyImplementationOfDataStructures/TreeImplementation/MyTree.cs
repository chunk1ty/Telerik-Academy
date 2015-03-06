namespace TreeImplementation
{
    using System;
    using System.Collections.Generic;

    public class MyTree<T>
    {
        private MyTreeNode<T> root;

        public MyTree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value!");
            }

            this.Root = new MyTreeNode<T>(value);
        }

        public MyTree(T value, params MyTree<T>[] children)
            : this(value)
        {
            foreach (MyTree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        /// <summary>
        /// The root node or null if the tree is empty
        /// </summary>
        public MyTreeNode<T> Root
        {
            get
            {
                return this.root;
            }
            private set
            {
                this.root = value;
            }
        }

        private void TraverseDFS(MyTreeNode<T> root, string spaces)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            MyTreeNode<T> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                this.TraverseDFS(child, spaces + "   ");
            }
        }

        public void TraverseDFS()
        {
            this.TraverseDFS(this.root, string.Empty);
        }

        public void TraverseBFS()
        {
            Queue<MyTreeNode<T>> queue = new Queue<MyTreeNode<T>>();
            queue.Enqueue(this.root);
            while (queue.Count > 0)
            {
                MyTreeNode<T> currentNode = queue.Dequeue();
                Console.Write("{0} ", currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    MyTreeNode<T> childNode = currentNode.GetChild(i);
                    queue.Enqueue(childNode);
                }
            }
        }

        public void TraverseDFSWithStack()
        {
            Stack<MyTreeNode<T>> stack = new Stack<MyTreeNode<T>>();
            stack.Push(this.root);
            while (stack.Count > 0)
            {
                MyTreeNode<T> currentNode = stack.Pop();
                Console.Write("{0} ", currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount; i++)
                {
                    MyTreeNode<T> childNode = currentNode.GetChild(i);
                    stack.Push(childNode);
                }
            }
        }
    }
}

