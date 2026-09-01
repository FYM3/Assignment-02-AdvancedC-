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

    }
}
