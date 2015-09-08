using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTree<int> tree = new MyTree<int>
                (7, 
                new MyTree<int>(17));
                          
        }
    }
}
