using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterTenNumbers
{
    class Numbers
    {
        static void Main()
        {      
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = inputNumber; i < inputNumber+10; i++)
            {
                ReadNumber(inputNumber, inputNumber + 10);
                Console.WriteLine(i);
            }
        }

        static void ReadNumber(int start, int end)
        { 
            if (start <= 1)
            {
                throw new ArgumentOutOfRangeException("Incorrect start argument!");
            }
            if (end > 100)
            {
                throw new ArgumentOutOfRangeException("Incorrect end argument!");
            }

        }
    }
}
