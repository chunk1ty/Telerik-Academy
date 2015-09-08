using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightmareOnCodeStreet
{
    class Nightmare
    {
        static void Main()
        {
            string numberAsString = Console.ReadLine();            

            int counter = 0;
            long sum = 0;
            int position = 0;
            foreach (char ch in numberAsString)
            {
                if (position % 2 != 0)
                {
                    if (char.IsDigit(ch))
                    {
                        int currentNumber = ch - '0';
                        sum += currentNumber;
                        counter++; 
                    }                    
                }
                position++;
            }
                
                      

           Console.WriteLine("{0} {1}",counter,sum);
        }
    }
}
