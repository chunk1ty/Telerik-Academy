namespace Company.SampleGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class RandomGenerator : IRandomGenerator
    {
        private const string LETTERS = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz";

        private Random random;
        private static IRandomGenerator randomGenerator;

        private RandomGenerator()
        {
            this.random = new Random();
        }

        public static IRandomGenerator Instance
        {
            get
            {
                if (randomGenerator == null)
                {
                    randomGenerator = new RandomGenerator();
                }

                return randomGenerator;
            }            
        }

        public int GetRandomNumber(int min, int max)
        {
            return this.random.Next(min, max);
        }

        public string GetRandomString(int length)
        {
            var result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = LETTERS[this.GetRandomNumber(0, LETTERS.Length - 1)];
            }

            return new string(result);
        }

        public string GetRandomStringWithRandomRange(int min, int max)
        {
            return this.GetRandomString(this.GetRandomNumber(min, max));
        }

        public bool GetChance(int percent)
        {
            return this.GetRandomNumber(0, 101) <= percent;
        }
    }
}
