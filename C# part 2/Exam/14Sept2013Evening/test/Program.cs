using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            char result = (char)((0^15)+65);
            Console.WriteLine(result);
        }
    }
}
