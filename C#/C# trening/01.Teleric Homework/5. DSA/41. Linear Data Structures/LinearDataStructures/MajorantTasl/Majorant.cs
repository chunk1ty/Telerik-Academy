namespace MajorantTasl
{
    using System;
    using System.Collections.Generic;
    
    public class Majorant
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };

            int majorant = FindMajorant(numbers);

            Console.WriteLine(majorant);
        }

        private static int FindMajorant(List<int> numbers)
        {
            numbers.Sort();

            int counter = 1;
            int firstNumber = 0;
            int secondNumber = 0;
            int majorantCondition = numbers.Count / 2 + 1;

            for (int index = 0; index < numbers.Count -1; index++)
            {
                firstNumber = numbers[index];
                secondNumber = numbers[index + 1];

                if (firstNumber == secondNumber)
                {
                    counter++;
                }
                else
                {
                    if (counter >= majorantCondition)
                    {
                        return firstNumber;
                    }

                    counter = 1;
                }

                if (index > majorantCondition && (counter == 1))
                {
                    return -1;
                }

                if (counter >= majorantCondition)
                {
                    return firstNumber;
                }
            }

            return -1;
        }

        //Dictionary<int, int> occures = new Dictionary<int, int>();
        //    foreach (var item in numbers)
        //    {
        //        if (occures.ContainsKey(item))
        //        {
        //            occures[item]++;
        //        }
        //        else
        //        {
        //            occures.Add(item, 1);
        //        }
        //    }

        //    int maxOccures = occures.Max(x => x.Value);
        //    //int countAllElements = occures.Sum(x => x.Value);
        //    int countAllElements = numbers.Count;
        //    if (maxOccures >= countAllElements / 2 + 1)
        //    {
        //        Console.WriteLine("majorant is: {0}", maxOccures);
        //    }
        //    else
        //    {
        //        Console.WriteLine("majorant not exist");
        //    }
    }
}
