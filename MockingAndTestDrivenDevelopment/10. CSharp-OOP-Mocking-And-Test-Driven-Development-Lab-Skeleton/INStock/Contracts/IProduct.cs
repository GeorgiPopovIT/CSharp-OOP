using System;
using System.Collections.Generic;
using System.Text;

namespace INStock.Contracts
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }
    }
}
