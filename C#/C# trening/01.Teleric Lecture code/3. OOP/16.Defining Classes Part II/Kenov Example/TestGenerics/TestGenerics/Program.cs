using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<Bunny, int> generic = new GenericClass<Bunny, int>();

            int max = Max(new int[] { 5, 6, 7 });
        }

        static T Max<T>(T[] data)
        {
            return data[0];
        }
    }
}
