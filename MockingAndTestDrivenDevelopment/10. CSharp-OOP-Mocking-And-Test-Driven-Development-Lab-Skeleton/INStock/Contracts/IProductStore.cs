using System;
using System.Collections.Generic;
using System.Text;

namespace INStock.Contracts
{
    public interface IProductStore
    {
        void Add(Product product);
        bool Contains(Product product);
        int Count { get; }
        Product Find(int index);
        Product FindByLabel(string name);
        Product[] FindAllInPriceRange(decimal start, decimal end);
        Product[] FindAllByPrice(decimal price);
        Product FindMostExpensiveProducts(int price);
        Product[] FindAllByQuantity(int quantity);

    }
}
