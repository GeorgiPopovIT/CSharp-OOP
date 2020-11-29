using INStock.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace INStock
{
    public class Product : IProduct
    {
        public Product(string name,decimal price,int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
