public class Order
{
    private Customer _Customer;
    private List<Product> _Products;
    private double _ShippingCost;

    public Order(Customer customer)
    {
        _Customer = customer;
        _Products = new List<Product>();
        _ShippingCost = customer.InUSA() ? 5 : 35;
    }
    public void AddProduct(Product product)
    {
        _Products.Add(product);
    }
    public double GetTotalCost()
    {
        double totalProductCost = 0;
        foreach (var product in _Products)
        {
            totalProductCost += product.GetTotalCost();
        }
        return totalProductCost + _ShippingCost;
    }
    public string GetPackingLabel()
    {
        var label = "";
        foreach (var product in _Products)
        {
            label += $"{product.SetProductName} - {product._ProductId}\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"{_Customer.GetCustomerName()}\n{_Customer.GetAddress().GetFullAddress()}";
    }
    public Customer GetCustomer()
    {
        return _Customer;
    }
    public List<Product> GetProducts()
    {
        return _Products;
    }
}
