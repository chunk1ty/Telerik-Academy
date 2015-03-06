namespace SequenceOfPositiveNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PositiveNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> positiveNumbers = new List<int>();

            while (input != string.Empty)
            {
                positiveNumbers.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            Console.WriteLine(positiveNumbers.Sum());
            Console.WriteLine(positiveNumbers.Average());

            //Console.WriteLine("Enter some positive numbers: ");
            //string input = Console.ReadLine();
            //if (string.IsNullOrEmpty(input))
            //{
            //    return;
            //}

            //List<int> numbers = new List<int>();

            //while (!string.IsNullOrEmpty(input))
            //{
            //    int num;
            //    if (int.TryParse(input, out num))
            //    {
            //        if (num < 0)
            //        {
            //            throw new ArgumentException("We take only positive numbers!");
            //        }

            //        numbers.Add(num);
            //    }
            //    else
            //    {
            //        throw new ArgumentException("Enter only positive numbers!");
            //    }

            //    input = Console.ReadLine();
            //}

            //decimal sum = numbers.Sum();

            //Console.WriteLine("The sum is: {0}", sum);

            //var average = numbers.Average();
            //Console.WriteLine("the average is : {0}", average);
        }
    }
}
