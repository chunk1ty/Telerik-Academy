namespace UsefulClassesAndMethods.Tuple
{
    using System;
    using System.Collections.Generic;

    public class CountAndAverageCalculator
    {
        public Tuple<int, decimal> GetCountAndAverage(IEnumerable<int> numbers)
        {
            var count = 0;
            long sum = 0;
            foreach (var number in numbers)
            {
                count++;
                sum += number;
            }

            var average = (decimal)sum / count;
            return new Tuple<int, decimal>(count, average);
        }
    }
}
