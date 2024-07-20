public class Product
{
    private string _productName;
    private string _productId;
    private decimal _productPrice;
    private int _quantity;

    public Product(string productName, string productId, decimal productPrice, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public decimal TotalCost()
    {
        return _productPrice * _quantity;
    }

    public string ProductName => _productName;
    public string ProductID => _productId;
}
