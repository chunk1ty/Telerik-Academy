using System;
using System.Collections.Generic;
using System.Diagnostics;

class CompareListAndHashSet
{
    static void Main()
    {
        const int elements = 64000;
        Random rand = new Random();

        var beforeList = GC.GetTotalMemory(true);
        List<int> list = new List<int>();
        for (int i = 0; i < elements; i++)
        {
            list.Add(rand.Next());
        }
        var afterList = GC.GetTotalMemory(true);
        Console.WriteLine("Memory used by List<int>:\t{0}",
            afterList - beforeList);

        var beforeHashSet = GC.GetTotalMemory(true);
        HashSet<int> hashSet = new HashSet<int>();
        for (int i = 0; i < elements; i++)
        {
            hashSet.Add(rand.Next());
        }
        var afterHashSet = GC.GetTotalMemory(true);
        Console.WriteLine("Memory used by HashSet<int>:\t{0}",
            afterHashSet - beforeHashSet);

        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < elements; i++)
        {
            list.Contains(rand.Next());
        }
        sw.Stop();
        Console.WriteLine("Time used by List<int>:\t\t{0}", sw.Elapsed);

        sw.Reset();
        sw.Start();
        for (int i = 0; i < elements; i++)
        {
            hashSet.Contains(rand.Next());
        }
        sw.Stop();
        Console.WriteLine("Time used by HasthSet<int>:\t{0}", sw.Elapsed);
    }
}
