namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyBinarySearchTree<T> where T : IComparable<T>
    {
        private MyTreeNode<T> Root { get; set; }

        public MyBinarySearchTree()
        {
            this.Root = null;
        }

        public int Count { get; private set; }

        public void Add(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("The value can not be null!");
            }

            var newNode = new MyTreeNode<T>(value);

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                var parent = this.FindParent(value);

                newNode.Parent = parent;
                ///TODO: check newNode.Value
                if (newNode.Value.CompareTo(parent.Value) > 0)
                {
                    parent.RightChild = newNode;
                }
                else
                {
                    parent.LeftChild = newNode;
                }
            }

            this.Count++;
        }

        public MyTreeNode<T> Find(T value)
        {
            var currentNode = this.Root;

            while (currentNode != null)
            {
                // value > currentNode.Value
                //go right

                if (value.CompareTo(currentNode.Value) == 0)
                {
                    return currentNode;
                }
                else if (value.CompareTo(currentNode.Value) > 0)
                {
                    currentNode = currentNode.RightChild;
                }
                else
                {
                    currentNode = currentNode.LeftChild;
                }
            }

            return null;
        }

        public void Remove(T value)
        {
            var nodeToDelete = this.Find(value);

            //The element has two childes
            if (nodeToDelete.LeftChild != null && nodeToDelete.RightChild != null)
            {
                var replacementNode = nodeToDelete.RightChild;

                while (replacementNode.LeftChild != null)
                {
                    replacementNode = replacementNode.LeftChild;
                }

                nodeToDelete.Value = replacementNode.Value;
                nodeToDelete = replacementNode;
            }

            //Where is the child ? In the left or right
            MyTreeNode<T> theChildOfNodeToDelete;
            if (nodeToDelete.LeftChild != null)
            {
                theChildOfNodeToDelete = nodeToDelete.LeftChild;
            }
            else
            {
                theChildOfNodeToDelete = nodeToDelete.RightChild;
            }

            //The element has one child
            if (theChildOfNodeToDelete != null)
            {
                //The element is a root of the tree
                if (nodeToDelete.Parent == null)
                {
                    this.Root = theChildOfNodeToDelete;
                }
                else
                {
                    if (nodeToDelete.Parent.LeftChild == nodeToDelete)
                    {
                        nodeToDelete.Parent.LeftChild = theChildOfNodeToDelete;
                    }
                    else
                    {
                        nodeToDelete.Parent.RightChild = theChildOfNodeToDelete;
                    }
                }

                theChildOfNodeToDelete.Parent = nodeToDelete.Parent;
            }
            // The element has 0 or 1 subtrees
            else
            {
                var parent = nodeToDelete.Parent;

                //The element is root
                if (parent == null)
                {
                    this.Root = null;
                }
                //The element is leaf
                else
                {
                    if (parent.LeftChild == nodeToDelete)
                    {
                        parent.LeftChild = null;
                    }
                    else
                    {
                        parent.RightChild = null;
                    }
                }
            }
        }

        private MyTreeNode<T> FindParent(T value)
        {
            var node = this.Root;

            while (true)
            {
                //go right
                if (node.Value.CompareTo(value) < 0)
                {
                    if (node.RightChild == null)
                    {
                        return node;
                    }
                    else
                    {
                        node = node.RightChild;
                    }
                }
                // go left
                else
                {
                    if (node.LeftChild == null)
                    {
                        return node;
                    }
                    else
                    {
                        node = node.LeftChild;
                    }
                }
            }
        }

        public void dfs()
        {
            PrintDFS(this.Root);
        }

        private void PrintDFS(MyTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.Value + " ");
            PrintDFS(node.LeftChild);
            PrintDFS(node.RightChild);
        }

        public void AnkDfs()
        {
            Stack<MyTreeNode<T>> stack = new Stack<MyTreeNode<T>>();

            stack.Push(this.Root);

            while (stack.Count > 0)
            {
                var V = stack.Pop();
                Console.WriteLine(V);
                if (V.RightChild != null)
                {
                    stack.Push(V.RightChild);
                }
                if (V.LeftChild != null)
                {
                    stack.Push(V.LeftChild);
                }               
            }
        }

        public void AnkBfs()
        {
            Queue<MyTreeNode<T>> queue = new Queue<MyTreeNode<T>>();

            queue.Enqueue(this.Root);

            while (queue.Count > 0)
            {
                var V = queue.Dequeue();
                Console.WriteLine(V);
                if (V.LeftChild != null)
                {
                    queue.Enqueue(V.LeftChild);
                }
                if (V.RightChild != null)
                {
                    queue.Enqueue(V.RightChild);
                }
            }
        }

        //RECURSION IMPLEMENTATION OF ADD NODE
        //public void Add(T value)
        //{
        //    var newNode = new MyTreeNode<T>(value);

        //    this.Root = this.Insert(value, this.Root);
        //}

        //private MyTreeNode<T> Insert(T value, MyTreeNode<T> node)
        //{           

        //    if (node == null)
        //    {
        //        node = new MyTreeNode<T>(value);
        //    }
        //    else
        //    {  
        //        if (value.CompareTo(node.Value) > 0)
        //        {
        //            node.RightChild = Insert(value,node.RightChild);
        //        }
        //        else
        //        {
        //            node.LeftChild = Insert(value, node.LeftChild);
        //        }
        //    }

        //    return node;
        //}
    }
}
