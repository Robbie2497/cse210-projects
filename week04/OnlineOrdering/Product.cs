public class Product
{
    private int _productId;
    private string _productName;
    private double _price;
    private int _quantity;

    public Product(int productId, string productName, double price, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}