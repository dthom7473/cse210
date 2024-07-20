public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string CustomerName => _customerName;
    public Address CustomerAddress => _customerAddress;

    public bool InUSA()
    {
        return _customerAddress.InUSA();
    }
}
