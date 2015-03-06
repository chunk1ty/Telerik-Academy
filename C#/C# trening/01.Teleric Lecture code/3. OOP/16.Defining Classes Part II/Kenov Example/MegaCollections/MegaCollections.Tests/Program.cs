namespace MegaCollections.Tests
{

    class Program
    {
        static void Main()
        {
            Deque<int> deque = new Deque<int>(40);

            deque.AddFront(10);
            deque.AddBack(50);
            
            // 10 50

            Deque<int> anotherDeque = new Deque<int>();

            anotherDeque.AddFront(5);
            anotherDeque.AddFront(10);

            // 10 5

            Deque<int> result = deque + anotherDeque; // 10 50 10 5
        }
    }
}
