public class Customer
{
    private string _CustomerName;
    private Address _Address;

    public Customer(string customerName, Address address)
    {
        _CustomerName = customerName;
        _Address = address;
    }
    public bool InUSA()
    {
        return _Address._Country.Equals("USA");
    }
    public string GetCustomerName()
    {
        return _CustomerName;
    }
    public Address GetAddress()
    {
        return _Address;
    }
    public void SetCustomerName(string customerName)
    {
        _CustomerName = customerName;
    }

    public void SetAddress(Address address)
    {
        _Address = address;
    }
}

