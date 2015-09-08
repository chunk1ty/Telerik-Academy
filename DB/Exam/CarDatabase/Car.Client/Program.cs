namespace Car.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using Car.Data;
    using Car.Data.Migrations;
    using Car.Models;

    public class Program
    {
        static void Main(string[] args)
        {
            var db = new CarContext();

            var json = new JsonImporter(db);
            json.ImportDirectory("../../../Data.Json.Files");
        }
    }
}
