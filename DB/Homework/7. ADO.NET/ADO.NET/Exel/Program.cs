namespace Exel
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main()
        {
            OleDbConnection dbConn = new OleDbConnection(
          @"Provider=Microsoft.Jet.OLEDB.4.0; 
            Data Source=..\..\task6.xls;
            Persist Security Info=False;
            Extended Properties=Excel 12.0;
            HDR=Yes;");

            using (dbConn)
            {
                dbConn.Open();
                OleDbCommand command = new OleDbCommand("select * from [Shteet1$]", dbConn);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var name = dr["name"];
                        var score = dr["score"];
                        Console.WriteLine(name + " " + score);
                    }
                }
            }

        }
    }
}
