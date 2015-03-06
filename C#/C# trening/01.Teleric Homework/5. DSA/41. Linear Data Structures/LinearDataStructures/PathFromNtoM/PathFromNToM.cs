using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFromNtoM
{
    public class PathFromNToM
    {
        public static void Main()
        {            
            Console.WriteLine("Insert a positive number for starting sequence:");
            int n = 0;
            while (n == 0)
            {
                int.TryParse(Console.ReadLine(), out n);
            }

            Console.WriteLine("Insert a positive number for finishing sequence:");
            int m = 0;
            while (m == 0)
            {
                int.TryParse(Console.ReadLine(), out m);
            }

            //List<int> numbers = new List<int>();
            Stack<int> stack = new Stack<int>();
            stack.Push(m);
            while (m / 2 >= n)
            {
                m = m / 2;
                stack.Push(m);
            }

            while (m - 2 >= n)
            {
                m = m - 2;
                stack.Push(m);
            }

            while (m - 1 >= n)
            {
                m = m - 1;
                stack.Push(m);
            }

            PrintNumbers(stack);
        }

        private static void PrintNumbers(IEnumerable<int> numbers)
        {
            Console.WriteLine("Print numbers.");
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
