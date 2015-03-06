namespace ReverseIntUsingStack
{
    using System;
    using System.Collections.Generic;
    class ReverseInt
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                stack.Push(number);    
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
