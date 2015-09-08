namespace MyLinkList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkListList<int> ank = new LinkListList<int>();

            ank.Add(5);
            ank.Add(6);
            ank.Add(7);

            LinkListList<Node> ankk = new LinkListList<Node>();
            foreach (var item in ankk)
            {
                
            }
            //LinkedList2<int> ank = new LinkedList2<int>();

            //ank.AddLast(5);
            //ank.AddLast(6);
            //ank.AddLast(7);

            foreach (var item in ank)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
