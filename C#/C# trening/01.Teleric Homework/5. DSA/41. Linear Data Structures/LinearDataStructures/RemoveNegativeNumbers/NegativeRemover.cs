using System.Collections.Generic;
namespace RemoveNegativeNumbers
{
    public class NegativeRemover
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, -6, 10, -9, 10, -99 };

            var result = Remover(list);
        }

        public static List<int> Remover(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var number in list)
            {
                if (number > 0)
                {
                    result.Add(number);
                }
            }

            return result;
        }
    }
}
