namespace NumberOfOccurrencesElements
{
    using System;
    using System.Collections.Generic;  

    class OccurrencesElement
    {
        static void Main()
        {
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            Dictionary<double, int> myDictionary = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                if (myDictionary.ContainsKey(array[i]))
                {
                    count = myDictionary[array[i]] + 1;
                }
                else
                {
                    myDictionary.Add(array[i], 1);
                }

                myDictionary[array[i]] = count;
            }
        }
    }
}
