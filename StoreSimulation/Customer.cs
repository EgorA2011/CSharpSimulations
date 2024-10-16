using System;

public class Customer
{
    public int CardNumber { get; private set; }
    public double Money { get; set; }
    public int ItemsPurchased { get; private set; }

    public Customer(int cardNumber, double money)
    {
        CardNumber = cardNumber;
        Money = money;
        ItemsPurchased = 0;
    }

    public void Purchase(Product product)
    {
        if (product.Quantity > 0 && Money >= product.Price)
        {
            product.Quantity--;
            Money -= product.Price;
            ItemsPurchased++;
        }
    }
}
