using System;
using System.Text;

namespace ReverseString
{
    class ReverseStringClass
    {
        static void Main()
        {
            string text = "sample";

            char[] asCharArray = text.ToCharArray();
            Array.Reverse(asCharArray);

            Console.WriteLine(asCharArray);

            Console.WriteLine(asCharArray,1,2);

        }
    }
}
