namespace AmicableNumbers
{
    using System;    
    public class AmicableNumber
    {
        static void Main()
        {
            Console.WriteLine(CalculateAmicableNumbers());

            int sumAmicible = 0;
            int factorsi, factorsj;

            for (int i = 2; i <= 10000; i++)
            {
                factorsi = sumOfFactors(i);
                if (factorsi > i && factorsi <= 10000)
                {
                    factorsj = sumOfFactors(factorsi);
                    if (factorsj == i)
                    {
                        sumAmicible += i + factorsi;
                    }
                }
            }

            Console.WriteLine(sumAmicible);
        }

        private static int CalculateAmicableNumbers()
        {
            //d(a) = b and d(b) = a
            // d(220) = 284   d(284) = 220
            // d(i) = sum   d(proper) = i
            int overall = 0;

            for (int i = 1; i < 10000; i++)
            {
                int sum = SumOfNumber(i);

                if (sum > i && sum < 10000)           // WTF ???
                {
                    int properDivisor = SumOfNumber(sum);


                    if (properDivisor == i) //&& (sum != properDivisor))
                    {
                        overall += sum + properDivisor;
                    }
                }                
            }

            return overall;
        }        

        private static int SumOfNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }    
            }

            return sum;
        }

        private static int sumOfFactors(int number)
        {
            int sqrtOfNumber = (int)Math.Sqrt(number);
            int sum = 1;

            //If the number is a perfect square
            //Count the squareroot once in the sum of factors
            if (number == sqrtOfNumber * sqrtOfNumber)
            {
                sum += sqrtOfNumber;
                sqrtOfNumber--;
            }

            for (int i = 2; i <= sqrtOfNumber; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i + (number / i);
                }
            }

            return sum;
        }
    }
}
