using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laser
{
    class LaserTask
    {
        static void Main()
        {
            int[] dims = GetThreeNumbersFromConsole();
            int[] pos = GetThreeNumbersFromConsole();
            int[] vect = GetThreeNumbersFromConsole();

            bool[, ,] visited = new bool[dims[0] + 1, dims[1] + 1, dims[2] + 1];

            while (true)
            {
                
            }
        }
        static int[] GetThreeNumbersFromConsole()
        {
            string input = Console.ReadLine();
            string[] split = input.Split();
            int[] array = new int[3];

            for (int i = 0; i < 3; i++)
			{
			    array[i] =int.Parse(split[i]);
			}
            return array;
        }
    }
}
