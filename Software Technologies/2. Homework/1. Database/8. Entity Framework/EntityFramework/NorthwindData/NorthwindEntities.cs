namespace DataAccessObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NorthwindData;

    class Program
    {
        static void Main(string[] args)
        {
            //Task3();
            //Task4();
            var shipRegion = "RJ";
            var startDate = new DateTime(1996, 1, 1);
            var endDate = new DateTime(1996, 12, 30);
            Task5(shipRegion, startDate, endDate);

            
        }

        public static void Task3()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var customers = northwindEntities.Orders
                                                 .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                                                 .Select(o => o.Customer)
                                                 .GroupBy(o => o.ContactName);

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Key);
                }
            }
        }

        public static void Task4()
        {
            using (var db = new NorthwindEntities())
            {
                var query = 
@"Select distinct c.ContactName
  from Orders o
  join Customers c
  on c.CustomerID = o.customerID
  where year(o.orderdate) = 1997 and o.shipcountry = 'Canada'";

                var result = db.Database.SqlQuery<string>(query);

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void Task5(string region, DateTime start, DateTime end)
        {
            using (var db = new NorthwindEntities())
            {
                var result = db.Orders
                                .Where(o => o.ShipRegion == region && o.OrderDate >= start && o.OrderDate <= end)
                                .Select(o => o);

                foreach (var sale in result)
                {
                    Console.WriteLine("Ship name: {0}, address: {1}, country: {2}", sale.ShipName, sale.ShipAddress, sale.ShipCountry);
                }
            }
        }
    }
}
