using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinarySearchTree<int> ank = new MyBinarySearchTree<int>();
            ank.Add(6);
            ank.Add(5);
            ank.Add(3);
            ank.Add(1);
            ank.Add(4);
            ank.Add(10);
            ank.Add(8);
            ank.Add(7);
            ank.Add(13);
            ank.Add(11);
            ank.Add(14);
            ank.Add(12);

            var result = ank.Find(24);
            //ank.Remove(8);
            Console.WriteLine("DFS");
            ank.dfs();            
            Console.WriteLine(result);
            ank.AnkDfs();
            Console.WriteLine("BFS");
            ank.AnkBfs();

            //int size = 1000000;
            //int[] arr = new int[size];
            //Random rnd = new Random();

            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = rnd.Next(-1000, 1000);
            //}

            //MyBinarySearchTree<int> ank = new MyBinarySearchTree<int>();
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //ank.Add(0);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    ank.Add(arr[i]);
            //}

            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);
        }
    }
}
