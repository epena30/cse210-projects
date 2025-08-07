public class Product
{
    private string _ProductName;
    public string _ProductId;
    public int _Price;
    public int _Qty;

    public Product(string productName, string productid, int price, int qyt)
    {
        _ProductName = productName;
        _ProductId = productid;
        _Price = price;
        _Qty = qyt;

    }

    public double GetTotalCost()
    {
        return (_Price * _Qty) / 100.0;
    }

    public override string ToString()
    {
        return $"{_ProductName}({_ProductId}) - ${_Price / 100.0} * {_Qty}";
    }
    public string GetProductId()
    {
        return _ProductId;
    }

    public double GetPrice()
    {
        return _Price;
    }

    public int GetQty()
    {
        return _Qty;
    }

    public void SetProductName(string productname)
    {
        _ProductName = productname;
    }

    public void SetPrice(int price)
    {
        _Price = price;
    }

    public void SetQty(int qty)
    {
        _Qty = qty;
    }
}
