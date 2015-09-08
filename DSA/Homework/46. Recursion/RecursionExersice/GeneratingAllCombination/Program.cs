namespace GeneratingAllCombination
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
            int n = 3;
            int k = 2;
            int[] vector = new int[k];
            GenerateCombination(1,0, n, vector);
        }

        private static void GenerateCombination(int start,int index, int n, int[] vector)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ",vector));
                return;
            }

            for (int i = start; i <= n; i++)
            {               
                vector[index] = i;
                GenerateCombination(i, index + 1, n, vector); 
            }
        }
    }
}
