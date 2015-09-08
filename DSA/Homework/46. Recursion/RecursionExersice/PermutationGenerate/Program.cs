namespace PermutationGenerate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
           Perm(arr, 0);
        }

        static void Perm(int[] arr, int k)
        {
            if (k >= arr.Length)
                Print(arr);
            else
            {
                Perm(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    Perm(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        private static void Print(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void Swap(ref int firstValue, ref int secondValue)
        {
            firstValue ^= secondValue;
            secondValue ^= firstValue;
            firstValue ^= secondValue;
        }
    }
}
