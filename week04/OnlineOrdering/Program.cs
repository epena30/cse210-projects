using System;
using System.Collections.Generic;

public class Address
    {
    private string _Street;
    private string _City;
    private string _StateorProvince;
    private string _Country;

    public Address(string street, string city, string stateorprovince, string country)
    {
        _Street = street;
        _City = city;
        _StateorProvince = stateorprovince;
        _Country = country;

    }
    public bool USA()
    {
        return CountdownEvent.ToLower() == "usa";
    }
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";

    }
    public string _Street { street => value; }
    public string _City { city => value; }
    public string _StateorProvince { stateorprovince => value; }
    public string _Country { country => value; }
}
public class Product
{
    private string _productName;
    public string _productId;
    public int _price;
    public int _qty;
}
public double GetTotalCost()
{
    return price * qty

} 
    public string _productName {producname => value; }
    public string __productId {productid => value; }
    public string _price {price => value; }
    public string _qty {qty => value; }


public class Customer
{
    private string _CustomerName;
    private string _Address;

    public Customer(string customername, string address)
    {
        _CustomerName = customername;
        _Address = address;
    }
    public bool InUSA()
    {
        return Address.InUSA();
    }
    public string GetName()
    {
        return _CustomerName;
    }
    public string GetAddress()
    {
        return _Address;
    }
    public string _CustomerName(Customer=>customerName = value;)
    public string _Address(Address=>Address = value;)
    }

public class Order
{
    private _Customer
    private List<Product> products;
    private double ShippingCost;
}
public Order (Customer)
{
    _Customer = Customer;
    products = new List<Product>();
    _ShippingCost = Customer.InUSA() ? 5 : 35;
}
public void AddProduct(Product product)
{
    products.Add(product);
}
public double GetTotalCost()
{
    double GetTotalCost = 0;
    foreach (var product in products)
    {
        totalProductCost += product.GetTotalCost();
    }
    return totalProductCost + shippingcost;
}
public string GetpackingLabel()
{
    var label = "";
    foreach (var product in products)
    {
        label += $"{product._productName} - {product.__productId}\n";
    }
    return label;
}
public string GetShippingLabel()
{
    return $"{customer.GetName()}\n{Customer.GetAddress().GetFullAddress()}";
}
public Customer Customer { customer => value; }
public List<Product> Products { products => value; }

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("529 Florest Ave", "Hialeh", "Florida", "58387", "USA");
        var address2 = new Address("363", "Davis St", "Hayward", "California", "94528", "USA");

        var customer1 = new Customer("Maria Gonzalez", address1);
        var customer2 = new Customer("Helen Wilson", address2);

        var product1 = new Product("White T-Shirt", B25, 22.99, 1);
        var product2 = new Product("Black Jogger", J55, 35.99, 1);
        var product3 = new Product("Black shoe", 2585, 122.99, 1);

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
 