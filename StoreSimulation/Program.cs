using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        Console.Write("Введите количество покупателей: ");
        int customerCount = int.Parse(Console.ReadLine());
        
        List<Customer> customers = new List<Customer>();
        Store store = new Store();

        // Создаем покупателей
        for (int i = 0; i < customerCount; i++)
        {
            int cardNumber = rnd.Next(1, 1001);
            double money = rnd.Next(1000, 10001);
            customers.Add(new Customer(cardNumber, money));
        }

        // Процесс покупок
        foreach (var customer in customers)
        {
            while (customer.Money > 0)
            {
                foreach (var product in store.Products)
                {
                    customer.Purchase(product);
                    if (product.Quantity == 0) break;
                }
            }
        }

        // Вывод прибыли и максимального покупателя
        Console.WriteLine($"Общая прибыль магазина: {store.Profit}");
    }
}
