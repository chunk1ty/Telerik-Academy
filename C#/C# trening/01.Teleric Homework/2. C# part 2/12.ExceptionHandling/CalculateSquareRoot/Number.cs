using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquareRoot
{
    class Number
    {
        static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                ulong product = ulong.Parse(input);
                Console.WriteLine(CalcSquare(product));
            }
            catch (FormatException fe)
            {
                Console.WriteLine(("Invalid number " + fe.Message));
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(("Invalid number" + oe.Message));
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        static ulong CalcSquare(ulong number)
        {
            ulong product = (ulong)Math.Sqrt(number);
            return product;
        }
    }
}
