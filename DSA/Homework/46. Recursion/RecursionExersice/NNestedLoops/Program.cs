namespace NNestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            int loopsNumber = 3;
            GenerateCombination(0, new int[loopsNumber]);
        }

        private static void GenerateCombination(int index, int[] vector)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(",", vector));
                return;
            }

            for (int i = 1; i <= vector.Length; i++)
            {
                vector[index] = i;
                GenerateCombination(index + 1, vector);
            }
        }
    }
}
