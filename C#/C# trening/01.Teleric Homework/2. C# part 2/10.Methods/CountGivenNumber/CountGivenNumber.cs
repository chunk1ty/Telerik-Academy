using System;

    class CountGivenNumber
    {
        static void Main()
        {
            int[] myArray = { 1, 2, 3, 5, 1, 2, 1, 8, 2, 1, 7, 1 };
            int someNumber = 17;
            CountGivenNumberInArray(myArray,someNumber);
        }

        static void CountGivenNumberInArray(int[] array,int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }
            CountNumber(number, counter);
        }

        static void CountNumber(int number, int counter)
        {
            if (counter == 0)
            {
                Console.WriteLine("Number {0} not exist in this array!", number);
            }
            else
            {
                Console.WriteLine("Number {0} is found in the array {1} times ", number, counter);
            }
        }

    }

