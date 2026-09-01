using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_02_AdvancedC_.product
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Stock { get; set; }


        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> factory)
        {
            List<Product> Listproducts = new List<Product>();

            foreach (Product pro in products)
            {
                if (factory(pro))
                    Listproducts.Add(pro);
            }

            return Listproducts;
        }

        public static void ShortReport(List<Product> products)
        {
            Console.WriteLine("--- Short Report ---");

            foreach(Product pro in products)
                Console.WriteLine($"{pro.Name} - ${pro.Price}");
        }

        public static void DetailedReport(List<Product> products)
        {
            Console.WriteLine("--- Detailed Report ---");

            foreach (Product pro in products)
                Console.WriteLine($"[{pro.Category}] {pro.Name} | Price:${pro.Price} | Stock:{pro.Stock}");
        }

        //public static bool IsElectronics(Product product) => (product.Category == "Electronics") ? true : false;
        //public static bool IsCheaperThan50(Product product) => (product.Price < 50 && product.Price > 0) ? true : false;
        //public static bool IsInStock(Product product) => (product.Stock > 0) ? true : false;
        //public static bool IsCheaperThan100(Product product) => (product.Price < 100 && product.Category == "Clothing") ? true : false;
    }
}
