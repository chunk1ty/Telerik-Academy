using System;

namespace FeaturingWithGrisko
{
    class Grisko
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] inputAsCharArray = input.ToCharArray();
            Array.Sort(inputAsCharArray);
            int counter = 0;

            do
            {
                if (IsMatch(inputAsCharArray))
                {
                    counter++;
                }
            } while (NextPermutation(inputAsCharArray));
            Console.WriteLine(counter);

        }

        static bool IsMatch(char[] word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == word[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool NextPermutation(char[] numList)
        {
            var largestIndex = -1;
            for (var i = numList.Length - 2; i >= 0; i--)
            {
                if (numList[i] < numList[i + 1])
                {
                    largestIndex = i;
                    break;
                }
            }

            if (largestIndex < 0) return false;

            var largestIndex2 = -1;
            for (var i = numList.Length - 1; i >= 0; i--)
            {
                if (numList[largestIndex] < numList[i])
                {
                    largestIndex2 = i;
                    break;
                }
            }

            var tmp = numList[largestIndex];
            numList[largestIndex] = numList[largestIndex2];
            numList[largestIndex2] = tmp;

            for (int i = largestIndex + 1, j = numList.Length - 1; i < j; i++, j--)
            {
                tmp = numList[i];
                numList[i] = numList[j];
                numList[j] = tmp;
            }

            return true;
        }
    }
}
