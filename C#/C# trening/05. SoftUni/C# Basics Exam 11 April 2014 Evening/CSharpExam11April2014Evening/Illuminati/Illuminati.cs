namespace Illuminati
{
    using System;

    public class Illuminati
    {
        private static void Main()
        {
            string message = Console.ReadLine();

            int countA = 0;
            int countE = 0;
            int countI = 0;
            int countO = 0;
            int countU = 0;
            foreach (var symbol in message)
            {
                if (symbol == 'A' || symbol == 'a')
                {
                    countA++;
                }

                if (symbol == 'E' || symbol == 'e')
                {
                    countE++;
                }

                if (symbol == 'I' || symbol == 'i')
                {
                    countI++;
                }

                if (symbol == 'O' || symbol == 'o')
                {
                    countO++;
                }

                if (symbol == 'U' || symbol == 'u')
                {
                    countU++;
                }
            }

            long sum = countA * 65 + countE * 69 + countI * 73 + countO * 79 + countU * 85;
            long totalCount = countA + countE + countI + countO + countU;

            Console.WriteLine(totalCount);
            Console.WriteLine(sum);
        }
    }
}
