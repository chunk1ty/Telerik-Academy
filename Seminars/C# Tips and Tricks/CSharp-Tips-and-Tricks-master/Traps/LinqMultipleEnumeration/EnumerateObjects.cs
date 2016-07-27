namespace Traps.LinqMultipleEnumeration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EnumerateObjects
    {
        private readonly IEnumerable<int> numbers = new List<int> { 1, 2, 3 };

        public void LinqQueryMultipleEnumeration()
        {
            var results = this.numbers.Select(x => new { Number = x, Time = DateTime.Now.ToString("O") });

            Console.WriteLine("First enumeration:");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("Second enumeration:");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        public void LinqQuerySingleEnumeration()
        {
            var results = this.numbers.Select(x => new { Number = x, Time = DateTime.Now.ToString("O") }).ToList();

            Console.WriteLine("First enumeration:");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("Second enumeration:");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
