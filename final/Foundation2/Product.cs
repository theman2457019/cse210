using System.ComponentModel;

class Product
{
    private string _name;
    private string _productid;
    private double _price;
    private int _quantity;

    public Product()
    {
        _name = "Unknown";
        _productid = "Unknown";
        _price = 0.0;
        _quantity = 0;
    }
    public Product(string name, string productid, double price, int quantity)
    {
        _name = name;
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }

    public double gettotalprice()
    {
        double totalprice = _price * _quantity;
        return totalprice;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productid;
    }




}