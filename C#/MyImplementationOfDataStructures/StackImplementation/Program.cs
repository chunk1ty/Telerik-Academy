using System;
using System.Collections.Generic;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {

            MyStack<int> ank = new MyStack<int>(2);

            ank.Push(1);
            ank.Push(2);
            ank.Push(3);
            ank.Push(4);
            ank.Push(5);

            Console.WriteLine(ank.Peek());
            Console.WriteLine(ank.Pop());

            foreach (var item in ank)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(ank.Count);
        }
    }
}
