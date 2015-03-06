using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_8
{
    class Code248
    {
        static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());

            //•	If the code is 2 – find the remainder after A is divided by C. Example: A = 5, C = 3, A % C = 2.
            //•	If the code is 4 – find the sum of A and C. Example: A = 5, C = 3, A + C = 8.
            //• If the code is 8 – find the product of A and C. Example: A = 5, C = 3, A * C = 15.
            long result = 0;

            switch (secondNumber)
            {
                case 2: result = firstNumber % thirdNumber; break;
                case 4: result = firstNumber + thirdNumber; break;
                case 8: result = firstNumber * thirdNumber; break;
                default: Console.WriteLine("Incorrect input!");break;
            }

            long modulo = result % 4;
            if (modulo == 0)
            {
                long remainder = result / 4;
                Console.WriteLine(remainder);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(modulo);
                Console.WriteLine(result);
            }
        }
    }
}
