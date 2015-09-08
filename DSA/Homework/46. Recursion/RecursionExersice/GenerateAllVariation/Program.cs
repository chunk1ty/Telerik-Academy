namespace GenerateAllVariation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static string[] arr = { "hi", "a", "b" };
        static byte k = 2;
        static byte n = 3;
        static string[] set = new string[n];

        static void Main(string[] args)
        {
            GenerateVariations(0);
        }

        static void GenerateVariations(int index)
        {
            if (index >= arr.Length)
                Console.WriteLine(string.Join(" ",set));
            else
                for (int i = 0; i < n; i++)
                {
                    set[index] = arr[i];
                    GenerateVariations(index + 1);
                }
        }

    }
}
