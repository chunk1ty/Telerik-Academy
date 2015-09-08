namespace QueueTask
{
    using System;
    using System.Collections.Generic;
    
    public class QueueEx
    {
        static void Main(string[] args)
        {
            int n = 2;
            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(n);
       
            for (int i = 0; i < 50; i++)
            {
                int currentNumber = sequence.Dequeue();
 
                Console.WriteLine(currentNumber);

                int firstNumber = currentNumber + 1;
                int secondNumber = 2 * currentNumber + 1;
                int thirdNumber = currentNumber + 2;

                sequence.Enqueue(firstNumber);
                sequence.Enqueue(secondNumber);
                sequence.Enqueue(thirdNumber);
            }
    
        }
    }
}
