using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindData;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace NothwindTwin
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var dbContext = new NorthwindEntities())
            //{
            //    string generatedScript = ((IObjectContextAdapter)dbContext).ObjectContext.CreateDatabaseScript();

            //    StringBuilder dbScript = new StringBuilder();
            //    dbScript.Append("USE NorthwindTwin ");
            //    dbScript.Append(generatedScript);

            //    dbContext.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "CREATE DATABASE NorthwindTwin");
            //    dbContext.Database.ExecuteSqlCommand(dbScript.ToString());
            //}

            //using (var firstDbContext = new NorthwindEntities())
            //{
            //    var firstEmployeeFromFirstDbContext = firstDbContext.Employees.First();
            //    Console.WriteLine("First user see: {0}", firstEmployeeFromFirstDbContext.FirstName);
            //    firstEmployeeFromFirstDbContext.FirstName = "First";
            //    Console.WriteLine("First user changes the name with new value: {0}\n", firstEmployeeFromFirstDbContext.FirstName);

            //    firstDbContext.SaveChanges();

            //    using (var secondDbContext = new NorthwindEntities())
            //    {
            //        var firstEmployeeFromSecondDbContext = secondDbContext.Employees.First();

            //        Console.WriteLine("Second user see: {0}", firstEmployeeFromSecondDbContext.FirstName);
            //        firstEmployeeFromSecondDbContext.FirstName = "Second";
            //        Console.WriteLine("Second user changes the name with new value: {0}\n", firstEmployeeFromSecondDbContext.FirstName);

            //        secondDbContext.SaveChanges();
            //    }

            //    Console.WriteLine("After all changes:");
            //    Console.WriteLine("First user see: {0}\n", firstEmployeeFromFirstDbContext.FirstName);
            //}

            //using (var northwindEntities = new NorthwindEntities())
            //{
            //    Console.WriteLine("Actual result: {0}", northwindEntities.Employees.First().FirstName);
            //}


        }

        private static int TestWithTransaction()
        {
            var affectedRows = 0;
            var customerId = "RATTC";
            var employeeId = 5;

            var invalidEmployeeId = 5000;

            using (var dbContext = new NorthwindEntities())
            {
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        // To test with invalid data and see what happens, change employeeId with invalidEmployeeId
                        // then the transaction will rollback and there will be no added orders
                        var firstOrder = new Order()
                        {
                            CustomerID = customerId,
                            EmployeeID = employeeId
                        };

                        dbContext.Orders.Add(firstOrder);

                        var secondOrder = new Order()
                        {
                            CustomerID = customerId,
                            EmployeeID = employeeId
                        };

                        dbContext.Orders.Add(secondOrder);

                        affectedRows = dbContext.SaveChanges();

                        transaction.Commit();

                        Console.WriteLine("- Finish successfully => Commit transaction");
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();

                        Console.WriteLine("- Exception: Finish Unsuccessfully => Rollback transaction");
                    }
                }
            }

            return affectedRows;
        }

        /// <summary>
        /// Entity framework by default works with transactions, so it is not neccessary to explicity use transaction
        /// You can use only save changes and if an error occurs the entity framework will rollback and nothing will happen to the database
        /// </summary>
        /// <returns>The number of affected rows</returns>
        private static int TestWithSaveChanges()
        {
            var affectedRows = 0;
            var customerId = "RATTC";
            var employeeId = 6;

            var invalidEmployeeId = 5000;

            using (var dbContext = new NorthwindEntities())
            {
                try
                {
                    // To test with invalid data and see what happens, change employeeId with invalidEmployeeId
                    // then the transaction will rollback and there will be no added orders
                    var firstOrder = new Order()
                    {
                        CustomerID = customerId,
                        EmployeeID = employeeId
                    };

                    dbContext.Orders.Add(firstOrder);

                    var secondOrder = new Order()
                    {
                        CustomerID = customerId,
                        EmployeeID = employeeId
                    };

                    dbContext.Orders.Add(secondOrder);

                    affectedRows = dbContext.SaveChanges();

                    Console.WriteLine("- Finish successfully => Commit transaction");
                }
                catch (Exception)
                {
                    Console.WriteLine("- Exception: Finish Unsuccessfully => Rollback transaction");
                }
            }

            return affectedRows;
        }
    }
}
