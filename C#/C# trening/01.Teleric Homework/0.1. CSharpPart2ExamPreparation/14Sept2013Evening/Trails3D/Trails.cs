using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails3D
{
    class Trails
    {
        static void Main()
        {
            string[] xyz = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int x = int.Parse(xyz[0]);
            int y = int.Parse(xyz[1]);
            int z = int.Parse(xyz[2]);

            string redCommands = Console.ReadLine();
            string blueCommands = Console.ReadLine();
        }
    }
}
