using System;
using ResolvingTheNplus1QueryProblem;
using System.Linq;

class SolvingTheNplus1QueryProblem
{
	static void Main()
	{
        NorthwindEntities northwindEntities = new NorthwindEntities();
        //PrintCustomersAndRegionsWithQueryProblem(northwindEntities);
		//PrintCustomersAndRegionsWithoutQueryProblem(northwindEntities);
        PrintCustomersAndRegionsWithAnonomusProection(northwindEntities);
	}

	static void PrintCustomersAndRegionsWithQueryProblem(NorthwindEntities context)
    {
        foreach (var product in context.Products)
        {
            Console.WriteLine("Product: {0}; Supplier: {1}; Category: {2}",
                product.ProductName, product.Supplier.CompanyName,
                product.Category.CategoryName);
        }
    }

	static void PrintCustomersAndRegionsWithoutQueryProblem(NorthwindEntities context)
    {
        foreach (var product in context.Products.Include("Supplier").Include("Category"))
        {
            Console.WriteLine("Product: {0}; Supplier: {1}; Category: {2}",
                product.ProductName, product.Supplier.CompanyName,
                product.Category.CategoryName);
        }
    }

    static void PrintCustomersAndRegionsWithAnonomusProection(NorthwindEntities context)
    {
        var categories = context.Categories.Select(c =>
            new
            {
                CategoryName = c.CategoryName,
                Description = c.Description
            });

        foreach (var category in categories)
        {
            Console.WriteLine("{0} {1}",category.CategoryName, category.Description);
        }

    }
}
