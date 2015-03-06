using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pesho = "Pesho".GetHashCode();
            //var a = "a".GetHashCode();
            //var g = "Pefdssfsdfsfsdfffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffsho".GetHashCode();
            //Console.WriteLine(pesho);
            //Console.WriteLine(a);
            //Console.WriteLine(g);

            Console.WriteLine( Test("ank"));
            
        }

        public static bool Test(string name)
        {
            if (name == "ank")
            {
                return true;
            }

            return false;
        }
    }
}
