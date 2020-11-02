using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
        private List<Product> products;
        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public int Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public IReadOnlyList<Product> Products
        {
            get
            {
                return this.products.AsReadOnly();
            }
        }
        public void BuyProduct(Product product)
        {
            if (product.Cost > Money)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
            else
            {
                products.Add(product);
                Money -= product.Cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
        }
        public override string ToString()
        {
            if (this.Products.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            var sel = products.Select(p => p.Name);
            return $"{this.Name} - {string.Join(", ", sel)}";
        }
    }
}
