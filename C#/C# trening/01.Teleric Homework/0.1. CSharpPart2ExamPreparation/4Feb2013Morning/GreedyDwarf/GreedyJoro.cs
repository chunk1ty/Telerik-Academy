using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    class GreedyJoro
    {
        static void Main()
        {
            string[] valley = Console.ReadLine().Split(new char[] {',', ' '},StringSplitOptions.RemoveEmptyEntries);
            int[] vallyNumbers = new int[valley.Length];

            for (int i = 0; i < valley.Length; i++)
            {
                vallyNumbers[i] = int.Parse(valley[i]);
            }

            int numbersOfPatterns = int.Parse(Console.ReadLine());
            long maxValue = long.MinValue;

            for (int i = 0; i < numbersOfPatterns; i++)
            {
                long currentValue = ProccessPattern(vallyNumbers);
                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }
            }

            Console.WriteLine(maxValue);
        }

        private static long ProccessPattern(int[] valley)
        {
            string[] valleyAsString = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[valleyAsString.Length];

            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(valleyAsString[i]);
            }

            bool[] visited = new bool[valley.Length];
            long coinSum = 0;
            coinSum += valley[0];
            visited[0] = true;
            int currentPosition = 0;

            while (true)
            {            
                for (int i = 0; i < pattern.Length; i++)
                {
                    int nextMove = currentPosition + pattern[i];
                    if (nextMove >= 0 && nextMove < valley.Length && !visited[nextMove])
                    {
                        coinSum += valley[nextMove];
                        visited[nextMove] = true;
                        currentPosition = nextMove;
                    }
                    else
                    {
                        return coinSum;
                    }
                }
            }               
        }            
    }
}

