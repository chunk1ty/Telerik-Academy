namespace NumbersDivisibleby7And3
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    class DivisibleBy
    {
        static void Main()
        {
            List<int> numbers = new List<int>{ 3, 7, 21, 15, 11, 19 };
            var divitedBy3And7 = numbers.Where(x => (x % 3) == 0 && (x % 7) == 0);

            foreach (var item in divitedBy3And7)
            {
                Console.WriteLine(item);
            }

            var numberAnk =
                from number in numbers
                where number % 3 == 0 && number % 7 == 0
                select number;

            foreach (var element in numberAnk)
            {
                Console.WriteLine(element);
            }
        }
    }
}
