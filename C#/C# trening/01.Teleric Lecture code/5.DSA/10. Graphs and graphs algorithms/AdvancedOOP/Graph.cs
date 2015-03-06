namespace AdvancedOOP
{
    using System.Collections.Generic;
    using System.Text;

    public class Graph
    {
        internal IDictionary<string, Node> Nodes { get; private set; }

        public Graph()
        {
            this.Nodes = new Dictionary<string, Node>();
        }

        public void AddNode(string name)
        {
            var node = new Node(name);
            this.Nodes.Add(name, node);
        }

        public void AddConnection(string fromNode, string toNode, int distance, bool twoWay)
        {
            this.Nodes[fromNode].AddConnection(this.Nodes[toNode], distance, twoWay);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var node in this.Nodes)
            {
                result.Append(node.Key + " -> ");

                foreach (var connection in node.Value.Connections)
                {
                    result.Append(connection.Target + "-" + connection.Distance + " ");
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
