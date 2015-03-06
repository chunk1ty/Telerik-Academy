namespace QueueImplementation
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> ank = new MyQueue<int>();

            ank.Enqueue(1);
            ank.Enqueue(2);
            ank.Enqueue(3);

            var firstElement = ank.Peek();

            foreach (var item in ank)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(ank.ToString());

            //Queue<int> ank1 = new Queue<int>();

            //ank1.Enqueue(1);
            //ank1.Enqueue(2);
            //ank1.Enqueue(3);

            //var firstElementA = ank1.Peek();

            //foreach (var item in ank1)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
