namespace DoubleListImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            //MyLinkedList<int> ank = new MyLinkedList<int>();

            //ank.AddFirst(1);
            //ank.AddFirst(2);
            //ank.AddLast(3);
            //ank.AddFirst(4);
            //ank.AddLast(5);

            //ank.RemoveFirst();
            //ank.RemoveLast();

            //foreach (var item in ank)
            //{
            //    Console.WriteLine(item);
            //}

            //var find = ank.Find(17);
            //var find1 = ank.Find(1);

            MyLinkedList<string> ank1 = new MyLinkedList<string>();
            ank1.AddFirst("ank");
            ank1.AddFirst("pesho");

            var result = ank1.Find("ank");
        }
    }
}
