namespace Traps.RandomNumbers
{
    using System;
    using System.Security.Cryptography;

    public class HighQualityRandomNumbers : IRandomNumbersPrinter
    {
        private readonly int numberOfRandomNumbers;

        private readonly RandomNumberGenerator firstRandomNumberGenerator;

        private readonly RandomNumberGenerator secondRandomNumberGenerator;

        public HighQualityRandomNumbers(int numberOfRandomNumbers)
        {
            this.numberOfRandomNumbers = numberOfRandomNumbers;
            this.firstRandomNumberGenerator = RandomNumberGenerator.Create();
            this.secondRandomNumberGenerator = RandomNumberGenerator.Create();
        }

        public void PrintRandomNumbers()
        {
            Console.Write("First RNGCryptoServiceProvider: ");
            for (int i = 0; i < this.numberOfRandomNumbers; i++)
            {
                var randomInt32Value = GenerateRandomInt32Value(this.firstRandomNumberGenerator);
                Console.Write("{0} ", randomInt32Value);
            }

            Console.WriteLine();

            Console.Write("Second RNGCryptoServiceProvider: ");
            for (int i = 0; i < this.numberOfRandomNumbers; i++)
            {
                var randomInt32Value = GenerateRandomInt32Value(this.secondRandomNumberGenerator);
                Console.Write("{0} ", randomInt32Value);
            }

            Console.WriteLine();
        }

        private static int GenerateRandomInt32Value(RandomNumberGenerator randomNumberGenerator)
        {
            var fourRandomBytes = new byte[4]; // 4 bytes = 32 bits = Int32
            randomNumberGenerator.GetBytes(fourRandomBytes);
            var randomInt32Value = BitConverter.ToInt32(fourRandomBytes, 0);
            return randomInt32Value;
        }
    }
}
