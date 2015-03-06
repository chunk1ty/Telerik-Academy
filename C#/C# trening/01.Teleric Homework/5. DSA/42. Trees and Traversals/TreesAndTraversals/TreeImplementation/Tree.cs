namespace TreeImplementation
{
    using System;
    using System.Collections.Generic;

    public class Tree
    {
        //static int N;
        //static Node<int>[] nodes;

        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 0; i < N - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parendID = int.Parse(edgeParts[0]);
                int childID = int.Parse(edgeParts[1]);

                //create relationship between parent and child
                nodes[parendID].Children.Add(nodes[childID]);
                nodes[childID].HasParent = true;
            }

            //1.Find Root
            Console.Write("Root ");
            var root = FindRoot(nodes);
            Console.WriteLine(root.Value);

            //2. Find all leafs
            var leafs = FindAllLeafs(nodes);
            Console.WriteLine("Leafs");
            foreach (var leaf in leafs)
            {
                Console.Write("{0}, ",leaf);
            }
            Console.WriteLine();

            //3. Find all middle nodes
            var middleNodes = FindAllMiddleNode(nodes);
            Console.WriteLine("Middle nodes");
            foreach (var node in middleNodes)
            {
                Console.Write("{0}, ", node);
            }
            Console.WriteLine();

            //4. Find the longest path from the root
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.WriteLine("The longest path " + longestPath);

            //5. All paths in the tree with given sum S of their nodes
            int sum = int.Parse(Console.ReadLine());
            //var allPathsWithGivenSum = PathWithGivenSum(sum, root);
        }

        //private static List<Node<int>> PathWithGivenSum(int sum, Node<int> root)
        //{
            
        //}

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }

        private static List<Node<int>> FindAllMiddleNode(Node<int>[] nodes)
        {
            var middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            var leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }

        static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException();
        }
    }
}
