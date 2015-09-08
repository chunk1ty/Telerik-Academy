using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
    }

    public class Tree<T> where T : IComparable<T>
    {
        public TreeNode<T> Root { get; set; }
        public void Add(T value)
        {
            var newNode = new TreeNode<T>()
                {
                    Value = value
                };
            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                var parent = this.FindParentOf(value);
                if (parent.Value.CompareTo(value) < 0)
                {
                    parent.Right = newNode;
                }
                else
                {
                    parent.Left = newNode;
                }
            }

        }

        private TreeNode<T> FindParentOf(T value)
        {
            var node = this.Root;
            while (true)
            {
                //go right
                if (node.Value.CompareTo(value) < 0)
                {
                    if (node.Right == null)
                    {
                        return node;
                    }
                    else
                    {
                        node = node.Right;
                    }
                }
                //go left
                else
                {
                    if (node.Left == null)
                    {
                        return node;
                    }
                    else
                    {
                        node = node.Left;
                    }
                }
            }
        }

        public bool Search(T value)
        {
            var node = this.Root;

            while (node != null)
            {
                if (node.Value.CompareTo(value) == 0)
                {
                    return true;
                }
                //search right
                else if (node.Value.CompareTo(value) < 0)
                {
                    node = node.Right;
                }
                //search left
                else
                {
                    node = node.Left;
                }
            }
            return false;
        }

        public IEnumerable<T> GetInOrderValues()
        {
            var values = new List<T>();
            this.PerformInOrder(this.Root, values);
            return values;
        }

        public void DrawInOrder()
        {
            this.DrawInOrder(this.Root, "");
        }

        private void PerformInOrder(TreeNode<T> node, List<T> values)
        {
            if (node == null)
            {
                return;
            }
            this.PerformInOrder(node.Left, values);
            values.Add(node.Value);
            this.PerformInOrder(node.Right, values);
        }

        private void DrawInOrder(TreeNode<T> node, string indent)
        {
            if (node == null)
            {
                return;
            }
            this.DrawInOrder(node.Left, indent + "   ");
            Console.WriteLine(indent + node.Value);
            this.DrawInOrder(node.Right, indent + "   ");

        }


        class BfsPathNode<V> where V : IComparable<V>
        {
            public TreeNode<V> Node { get; set; }
            public int Level { get; set; }
        }

        public void DrawTree()
        {
            var queue = new Queue<BfsPathNode<T>>();

            queue.Enqueue(new BfsPathNode<T>()
            {
                Node = this.Root,
                Level = 0
            });

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(new string('-', 3 * current.Level) +
                    current.Node.Value);
                //for node in children
                //queue.Enqueue(node);
                if (current.Node.Left != null)
                {
                    queue.Enqueue(new BfsPathNode<T>()
                    {
                        Node = current.Node.Left,
                        Level = current.Level + 1
                    });
                }
                if (current.Node.Right != null)
                {
                    queue.Enqueue(new BfsPathNode<T>()
                    {
                        Node = current.Node.Right,
                        Level = current.Level + 1
                    });
                }
            }
        }



    }
}
