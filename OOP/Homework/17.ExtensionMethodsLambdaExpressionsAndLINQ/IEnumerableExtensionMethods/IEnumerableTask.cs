namespace IEnumerableExtensionMethods
{
    using System;
    using System.Collections.Generic;
    class IEnumerableTask
    {
        static void Main()
        {
            IEnumerable<double> collection = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            Console.WriteLine(collection.Min());
            Console.WriteLine(collection.Max());
            Console.WriteLine(collection.Product());
            Console.WriteLine(collection.Sum());
            Console.WriteLine(collection.Average());
        }
    }
}
