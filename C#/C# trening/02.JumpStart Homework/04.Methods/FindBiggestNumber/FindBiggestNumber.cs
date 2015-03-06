using System;

namespace FindBiggestNumberFromThree
{
    class FindBiggestNumber
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(GetMax(max,thirdNumber));
        }

        static int GetMax(int firstValue,int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            return secondValue;
        }
    }
}
