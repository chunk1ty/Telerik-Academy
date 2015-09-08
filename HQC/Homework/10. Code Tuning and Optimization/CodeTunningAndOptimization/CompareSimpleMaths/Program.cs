namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            OperationPerformanceTester.TestPerformance(Operation.Addition);
            OperationPerformanceTester.TestPerformance(Operation.Subtraction);
            OperationPerformanceTester.TestPerformance(Operation.Multiplication);
            OperationPerformanceTester.TestPerformance(Operation.Division);
        }
    }
}
