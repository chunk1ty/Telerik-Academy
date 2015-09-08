namespace SubsetOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static string[] arr = { "test", "rock", "fun" };
        private static int k = 2;
        private static string[] set = new string[k];

        static void Main(string[] args)
        {
            GenerateVariations(0,0);
        }

        static void GenerateVariations(int index,int start)
        {
            if (index >= set.Length)
                Console.WriteLine(string.Join(" ", set));
            else
                for (int i = start; i < arr.Length; i++)
                {
                    set[index] = arr[i];
                    GenerateVariations(index + 1,i+1);
                }
        }
    }
}
