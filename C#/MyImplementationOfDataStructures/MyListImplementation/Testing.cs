namespace MyListImplementation
{
    using System;
    using System.Collections.Generic;

    public class Testing
    {
        public static void Main(string[] args)
        {           
            var ankList = new MyList<int>();            

            ankList.AddFirst(5);
            ankList.AddFirst(6);
            ankList.AddFirst(7);
            ankList.AddLast(17);
            //ankList.RemoveFirst();

            foreach (var item in ankList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
