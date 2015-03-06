using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {

        static List<int> FindPrimes(int start, int end)
        {
            List<int> primes = new List<int>();

            for (var number = start; number <= end; number++)
            {
                var sqrt = Math.Sqrt(number);
                bool isPrime = true;
                for (var divider = 2; divider <= sqrt; divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(number);
                }
            }

            return primes;
        }


        static List<string> FindSubExpression(string expression)
        {
            List<string> subExpressions = new List<string>();

            var openingBrackets = new Stack<int>();

            for (var i = 0; i < expression.Length; i++)
            {
                var ch = expression[i];
                if (ch == '(')
                {
                    openingBrackets.Push(i);
                }
                else if (ch == ')')
                {
                    var opening = openingBrackets.Pop();
                    var length = i - opening - 1;
                    var subExpression =
                        expression.Substring(opening + 1, length);

                    subExpressions.Add(subExpression);
                }
            }

            return subExpressions;
        }

        static Random rand = new Random();

        static void Main(string[] args)
        {

            int n = 3;
            int p = 16;
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(n);

            int index = 0;

            while (true)
            {
                int current = queue.Dequeue();
                index++;
                if (current == p)
                {
                    break;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }

            Console.WriteLine("{0} found at {1}", p, index);

        }
    }
}
