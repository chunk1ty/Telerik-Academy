namespace ADTQueue
{
    public class Program
    {
        static void Main()
        {
            MyQueue<int> ank = new MyQueue<int>();

            ank.Enqueue(5);
            ank.Enqueue(6);
            ank.Enqueue(1);

            var ff = ank.Dequeue();
            foreach (var item in ank)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
