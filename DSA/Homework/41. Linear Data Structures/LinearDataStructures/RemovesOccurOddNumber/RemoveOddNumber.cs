namespace RemovesOccurOddNumber
{
    using System;
    using System.Collections.Generic;

    public class RemoveOddNumber
    {
        //TO SLOW !!!!
        static void Main()
        {
            List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var result = OccurOddNumberOfTimes(numbers);
        }

        public static List<int> OccurOddNumberOfTimes(List<int> numbers)
        {
            int counter = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                for (int j = 0; j < numbers.Count; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        counter++;
                    }
                }

                if (counter % 2 == 0)
                {
                    result.Add(currentNumber);
                }

                counter = 0;
            }

            return result;
        }
    }
}
