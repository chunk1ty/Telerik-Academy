namespace DataAccessObject
{
    using NorthwindData;
    using System;
    using System.Linq;

    public static class DAO
    {
        public static void InsertCustomer(
            string customerID,
            string companyName,
            string contactName = null,
            string city = null,
            string contactTitle = null,
            string address = null,
            string region = null,
            string postalCode = null,
            string country = null,
            string phone = null,
            string fax = null)
        {
            Customer newCustomer = new Customer
            {
                CustomerID = customerID,
                CompanyName = companyName,
                ContactName = contactName,
                City = city,
                ContactTitle = contactTitle,
                Address = address,
                Region = region,
                PostalCode = postalCode,
                Country = country,
                Phone = phone,
                Fax = fax
            };

            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(newCustomer);
                db.SaveChanges();
            }
        }

        public static void ModifyCustomer(string customerID, string newCompany)
        {
            using(var db = new NorthwindEntities())
            {
                var customer = db.Customers.Find(customerID);
                customer.CompanyName = newCompany;
                db.SaveChanges();
            }
        }

        public static void DeleteCustomer(string customerID)
        {
            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers.Find(customerID);
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }
    }
}
