namespace LatticePaths
{
    using System;   
   
    public class Program
    {
        static void Main()
        {
            int gridSize = 20;
            long path =1;
 
            for(int i=0 ; i < gridSize ;i++)
            {
                 path *= 2*gridSize-i;
                 path /= (i+1);
             }
            Console.WriteLine(path);
         }
        }
    }

