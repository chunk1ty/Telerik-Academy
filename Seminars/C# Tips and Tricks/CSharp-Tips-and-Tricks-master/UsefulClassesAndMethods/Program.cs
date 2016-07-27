namespace UsefulClassesAndMethods
{
    using System;
    using System.Collections.Generic;

    using UsefulClassesAndMethods.MethodDeprecation;
    using UsefulClassesAndMethods.Tuple;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(new string('=', 75));
            TupleDemo();
            Console.WriteLine(new string('=', 75));
            MethodDeprecationDemo();
            Console.WriteLine(new string('=', 75));
        }

        private static void TupleDemo()
        {
            var countAndAverageCalculator = new CountAndAverageCalculator();
            var result = countAndAverageCalculator.GetCountAndAverage(new List<int> { 1, 2, 3, 4 });
            Console.WriteLine("Count: {0}", result.Item1);
            Console.WriteLine("Average: {0}", result.Item2);
            
            var anotherResult = countAndAverageCalculator.GetCountAndAverage(new List<int> { 4, 3, 2, 1 });
            Console.WriteLine(anotherResult.Equals(result)); // anotherResult == result => reference comparison

            // Property or indexer 'System.Tuple<int,decimal>.Item1' cannot be assigned to -- it is read only
            // result.Item1 = 1;
        }

        private static void MethodDeprecationDemo()
        {
            var xmlReaderFactory = new XmlReaderFactory();
            xmlReaderFactory.CreateXmlReader();

            // Compilation warning:
            // xmlReaderFactory.CreateXml();
            
            // Compilation error:
            // xmlReaderFactory.Create();
        }
    }
}
