using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("529 Florest Ave", "Hialeh", "Florida", "58387", "USA");
        var address2 = new Address("363 Davis St", "Hayward", "California", "94528", "USA");

        var customer1 = new Customer("Maria Gonzalez", address1);
        var customer2 = new Customer("Helen Wilson", address2);

        var product1 = new Product("White T-Shirt", "B25", 2299, 1);
        var product2 = new Product("Black Jogger", "J55", 3599, 1);
        var product3 = new Product("Black shoe", "2585", 12299, 1);

        var order1 = new Order(customer1);
        order1.AddProduct(product3);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Price: {product3} and {product2}");
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Price: {product1} and {product2}");
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}\n");
    } 
}
 