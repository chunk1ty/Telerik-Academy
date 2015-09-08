using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //DAO.InsertCustomer("ank", "chunk1ty Inds", "Andriyan Krastev");
            //DAO.ModifyCustomer("ank", "Chunk1ty");
            DAO.DeleteCustomer("ank");
        }
    }
}
