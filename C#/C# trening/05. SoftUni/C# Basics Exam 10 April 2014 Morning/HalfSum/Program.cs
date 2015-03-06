namespace HalfSum
{
    using System;
    class Program
    {
        static void Main()
        {            
            int number = int.Parse(Console.ReadLine());
            int[] myArray = new int[number * 2];

            for (int i = 0; i < number * 2; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int firstNumbersSum = 0;
            int secondNumbersSum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i < number)
                {
                    firstNumbersSum += myArray[i];
                }
                else
                {
                    secondNumbersSum += myArray[i];
                }
            }

            
            if (firstNumbersSum > secondNumbersSum)
            {
                
            }
            if (firstNumbersSum == secondNumbersSum)
            {
                Console.WriteLine("Yes, sum={0}",firstNumbersSum);   
            }
            else
            {
                if (firstNumbersSum > secondNumbersSum)
                {
                    Console.WriteLine("No, diff={0}", firstNumbersSum - secondNumbersSum); 
                }
                else
                {
                    Console.WriteLine("No, diff={0}", secondNumbersSum - firstNumbersSum);
                }                
            }
        }
    }
}
