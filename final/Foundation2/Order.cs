public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.TotalCost();
        }
        decimal shippingCost = _customer.InUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string CreatePackingLabel()
    {
        var packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.ProductName} (ID: {product.ProductID})\n";
        }
        return packingLabel;
    }

    public string CreateShippingLabel()
    {
        return $"Shipping Label:\n{_customer.CustomerName}\n{_customer.CustomerAddress.GetAddress()}";
    }
}
