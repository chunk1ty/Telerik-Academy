using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerOccurInArray
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = {  3, 4, 4, 2, 3, 3, 4, 3, 2 };

            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (!occurrences.Keys.Contains(number))
                {
                    occurrences.Add(number, 1);
                }
                else
                {
                    occurrences[number]++;
                }
            }

            var resul = occurrences.OrderBy(x => x.Key);

            foreach (var pair in resul)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
