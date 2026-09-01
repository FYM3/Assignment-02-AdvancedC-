using Assignment_02_AdvancedC_.product;

namespace Assignment_02_AdvancedC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1) => Product Model

            //Product product = new Product();

            //product.Id = 1;
            //product.Name = "Test";
            //product.Price = 50.50;
            //product.Stock = 1;
            //product.Category = "Books";

            //Console.WriteLine($"{product.Id}");
            //Console.WriteLine($"{product.Name}");
            //Console.WriteLine($"{product.Price}");
            //Console.WriteLine($"{product.Stock}");
            //Console.WriteLine($"{product.Category}");

            #endregion

            #region Q2) => Product Catalog

            List<Product> catalog = new()
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            };

            #endregion

            #region Q3) => Task 01 Smart Product Search

            ////1. All Electronics products

            //List<Product> electronics = Product.SearchProducts(catalog, product => product.Category == "Electronics");

            //Console.WriteLine("--- Electronics ---");
            //foreach (Product product in electronics)
            //    Console.WriteLine($"{product.Name} - ${product.Price} (Stock:{product.Stock})");

            ////2.Products cheaper than $50 
            //Console.WriteLine();

            //List<Product> under50 = Product.SearchProducts(catalog, product => product.Price < 50 && product.Price > 0);

            //Console.WriteLine("--- Under $50 ---");
            //foreach (Product product in under50)
            //    Console.WriteLine($"{product.Name} - ${product.Price} (Stock:{product.Stock})");


            ////3. Products that are in stock (Stock > 0)
            //Console.WriteLine();

            //List<Product> InStock = Product.SearchProducts(catalog, product => product.Stock > 0);

            //Console.WriteLine("--- In Stock ---");
            //foreach (Product product in InStock)
            //    Console.WriteLine($"{product.Name} - ${product.Price} (Stock:{product.Stock})");


            ////4. Clothing products under $100
            //Console.WriteLine();

            //List<Product> clothingUnder100 = Product.SearchProducts(catalog, product => product.Category == "Clothing" && product.Price < 100);

            //Console.WriteLine("--- Clothing Under 100 ---");
            //foreach (Product product in clothingUnder100)
            //    Console.WriteLine($"{product.Name} - ${product.Price} (Stock:{product.Stock})");

            #endregion

            #region Q4) => Task 03 Custom Report Generator(3.1 Print Reports)

            //Action<List<Product>> PrintReport = Product.ShortReport;
            //PrintReport(catalog);

            //Console.WriteLine('\n');

            //Action<List<Product>> PrintDetailed = Product.DetailedReport;
            //PrintDetailed(catalog);

            #endregion

        }
    }
}
