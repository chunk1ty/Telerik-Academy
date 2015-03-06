using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            Tree<int> tree = new Tree<int>();

            tree.Add(50);

            tree.Add(25);
            
            tree.Add(12);
            tree.Add(6);
            tree.Add(17);

            tree.Add(35);

            tree.Add(100);
            tree.Add(75);
            tree.Add(85);
            tree.Add(60);

            tree.Add(125);


            //tree.DrawTree();
            tree.DrawInOrder();
            //var inOrderResult = tree.GetInOrderValues();

            //Console.WriteLine(string.Join(", ", inOrderResult));
        }
    }
}
