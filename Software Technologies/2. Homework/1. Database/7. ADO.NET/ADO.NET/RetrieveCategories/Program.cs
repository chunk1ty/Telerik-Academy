namespace RetrieveCategories
{
    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;
    

    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection northwindDBConnection = new SqlConnection("Server = .; Database = Northwind; Integrated Security = true");
            northwindDBConnection.Open();
            using (northwindDBConnection)
            {
                //Task1(northwindDBConnection);
                //Task2(northwindDBConnection);
                //Task3(northwindDBConnection);
                //Task4(northwindDBConnection, "ank", 1, 1, "eba ti rukite", 13333.2M, 17, 17, 17, true);
                //Task5(northwindDBConnection);
                Taks8(northwindDBConnection);
            }
        }

        //Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  rows in the Categories table.
        private static void Task1(SqlConnection northwindDBConnection)
        {
            SqlCommand numberOfRowsInCategories = new SqlCommand("Select count(*) from Categories", northwindDBConnection);
            int rows = (int)numberOfRowsInCategories.ExecuteScalar();

            Console.WriteLine(rows);
        }

        //Write a program that retrieves the name and description of all categories in the Northwind DB.
        private static void Task2(SqlConnection northwindDBConnection)
        {
            var descriptionOfCategories = new SqlCommand("Select CategoryName, Description from Categories", northwindDBConnection);
            SqlDataReader reader = descriptionOfCategories.ExecuteReader();
            while (reader.Read())
            {
                string categoryName = (string)reader["CategoryName"];
                string categoryDescription = (string)reader["Description"];
                Console.WriteLine(" {0} |  {1}", categoryName, categoryDescription);
            }
        }

        // Write a program that retrieves from the Northwind database all product categories and the names of the products in each category. Can you do this with a single SQL query (with table join)?
        private static void Task3(SqlConnection northwindDBConnection)
        {
            SqlCommand command = new SqlCommand(@"
        select productName, categoryname 
        from products p 
        join categories c 
        on p.categoryid = c.categoryid", northwindDBConnection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                string productName = (string)read["ProductName"];
                string categoryName = (string)read["CategoryName"];
                Console.WriteLine("{0} | {1}", productName, categoryName);
            }
        }

        //Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.
        private static void Task4(SqlConnection northwindDBConnection, string name, int supplierID, int categoryID, string quantity, decimal price, int unitesInStock, int unitsOnOrder, int level, bool discontinued)
        {
            SqlCommand cmd = new SqlCommand("Insert into products values (@name, @supplierID, @categoryID, @quantityPerUnit, @price, @unitesInStock, @unitsOnOrder, @level, @discontinued)", northwindDBConnection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@supplierID", supplierID);
            cmd.Parameters.AddWithValue("@categoryID", categoryID);
            cmd.Parameters.AddWithValue("@quantityPerUnit", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@unitesInStock", unitesInStock);
            cmd.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@discontinued", discontinued);

            cmd.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
        }

        private static void Task5(SqlConnection northwindDBConnection)
        {
            SqlCommand cmd = new SqlCommand("select picture from categories", northwindDBConnection);
            SqlDataReader read = cmd.ExecuteReader();
            int imageId = 1;
            while (read.Read())
            {
                byte[] imgAsByteArray = (byte[])read["Picture"];
                SaveImgToHardDrive(imageId.ToString(), ".jpg", imgAsByteArray);
                imageId++;
            }
        }

        private static void SaveImgToHardDrive(string imageName, string format, byte[] imageAsByteArray)
        {
            const int StreamStartIndex = 78;

            using (var stream = new MemoryStream(imageAsByteArray, StreamStartIndex, imageAsByteArray.Length - StreamStartIndex))
            {
                using (var convertedImage = Image.FromStream(stream))
                {
                    var fileName = imageName + format;

                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }

                    convertedImage.Save(fileName);
                }
            }
        }

        private static void Taks8(SqlConnection northwindDBConnection)
        {
            string pattern = Console.ReadLine();
            var command = new SqlCommand("SELECT ProductName From Products WHERE CHARINDEX(@searchString, ProductName) > 0", northwindDBConnection);
            command.Parameters.AddWithValue("@searchString", pattern);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var productName = reader["ProductName"];

                    Console.WriteLine("Product name -> {0}", productName);
                }
            }
        }
    }
}