namespace MaximumPathSum
{
    using System;
    public  class MaxPath
    {
        static void Main()
        {
            string input = @"..\..\input.txt";
            MaxPathSolution solution = new MaxPathSolution();            
            Console.WriteLine(solution.Solution(input));
  
        }
    }
}
