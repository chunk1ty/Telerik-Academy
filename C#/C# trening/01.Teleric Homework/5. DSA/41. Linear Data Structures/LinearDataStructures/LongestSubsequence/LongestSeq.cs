namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    public class LongestSeq
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 5 };

            var result = GetLongestEqualSubseq(list);
        }

        public static List<int> GetLongestEqualSubseq(List<int> list)
        {
            if (list.Count == 0)
            {
                return new List<int>();
            }

            if (list.Count == 1)
            {
                return list;
            }

            List<int> result = new List<int>();

            int couter = 1;
            int longestSequence = 0;            
            int number = list[0];

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i+1])
                {
                    couter++;
                    
                }
                else
                {
                    if (couter > longestSequence)
                    {
                        longestSequence = couter;                        
                        number = list[i];
                    }

                    couter = 1;
                }

                if (couter > longestSequence)
                {
                    longestSequence = couter;
                    number = list[i];
                }
            }

            for (int i = 0; i < longestSequence; i++)
            {
                result.Add(number);
            }

            return result;
        }
    }
}
