using INStock.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INStock
{
    public class ProductStock : IProductStore
    {
        private List<Product> products;
        public ProductStock()
        {
            this.products = new List<Product>();
        }
        public int Count => products.Count;

        public void Add(Product product)
        {
            this.products.Add(product);
        }

        public bool Contains(Product product)
        {
            if (products.Contains(product))
            {
                return true;
            }
            return false;
        }

        public Product Find(int index)
        {
            return (Product)products.ElementAt(index);
        }

        public Product[] FindAllByPrice(decimal price)
        {
            return products.FindAll(p => p.Price == price).ToArray();
        }

        public Product[] FindAllByQuantity(int quantity)
        {
            throw new NotImplementedException();
        }

        public Product[] FindAllInPriceRange(decimal start, decimal end)
        {
            throw new NotImplementedException();
        }
        public Product FindByLabel(string name)
        {
            throw new NotImplementedException();
        }

        public Product FindMostExpensiveProducts(int price)
        {
            throw new NotImplementedException();
        }
    }
}
