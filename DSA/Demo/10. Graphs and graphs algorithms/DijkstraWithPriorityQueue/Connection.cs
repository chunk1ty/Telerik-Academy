namespace DijkstraWithPriorityQueue
{
    public class Connection
    {
        public Connection(Node node, double distance)
        {
            this.Node = node;
            this.Distance = distance;
        }

        public Node Node { get; set; }

        public double Distance { get; set; }

        public override string ToString()
        {
            return string.Format("{0} distance {1}", this.Node, this.Distance);
        }
    }
}
