using System;
using System.Collections.Generic;

public class Store
{
    public List<Product> Products { get; private set; }
    public double Profit { get; private set; }

    public Store()
    {
        Products = new List<Product>
        {
            new Product("Товар 1", 100, 10),
            new Product("Товар 2", 200, 5),
            new Product("Товар 3", 300, 2)
        };
        Profit = 0;
    }

    public void SellProduct(Product product)
    {
        Profit += product.Price;
    }
}
