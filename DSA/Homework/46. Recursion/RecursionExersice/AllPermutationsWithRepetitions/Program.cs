using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPermutationsWithRepetitions
{
    class Program
    {
        public static HashSet<string> answer = new HashSet<string>();

        public static int[] multiSet = new int[] { 1, 5, 5, 5, 5, 5, 5, 5 };

        public static void Main()
        {
            var sw = new Stopwatch();
            sw.Start();
            Permute(new int[multiSet.Length], new bool[multiSet.Length], 0);
            Console.WriteLine("Time: {0}", sw.Elapsed);

            Console.WriteLine(string.Join(Environment.NewLine, answer));
        }

        public static void Permute(int[] vector, bool[] used, int index)
        {
            if (index == vector.Length)
            {
                answer.Add(string.Join(" ", vector));
                return;
            }

            for (int i = 0; i < multiSet.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    vector[index] = multiSet[i];

                    Permute(vector, used, index + 1);

                    used[i] = false;
                }
            }
        }

    }
}
