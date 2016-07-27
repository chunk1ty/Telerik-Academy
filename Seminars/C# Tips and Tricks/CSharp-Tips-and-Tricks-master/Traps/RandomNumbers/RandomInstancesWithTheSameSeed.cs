namespace Traps.RandomNumbers
{
    using System;

    public class RandomInstancesWithTheSameSeed : IRandomNumbersPrinter
    {
        private readonly int numberOfRandomNumbers;

        private readonly Random firstRandomNumbersGenerator;

        private readonly Random secondRandomNumbersGenerator;

        public RandomInstancesWithTheSameSeed(int numberOfRandomNumbers)
        {
            this.numberOfRandomNumbers = numberOfRandomNumbers;
            this.firstRandomNumbersGenerator = new Random();
            this.secondRandomNumbersGenerator = new Random();
        }

        public void PrintRandomNumbers()
        {
            Console.Write("firstRandomNumbersGenerator: ");
            for (int i = 0; i < this.numberOfRandomNumbers; i++)
            {
                Console.Write("{0} ", this.firstRandomNumbersGenerator.Next());
            }

            Console.WriteLine();
            
            Console.Write("secondRandomNumbersGenerator: ");
            for (int i = 0; i < this.numberOfRandomNumbers; i++)
            {
                Console.Write("{0} ", this.secondRandomNumbersGenerator.Next());
            }

            Console.WriteLine();
        }
    }
}
