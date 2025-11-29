using System.Runtime.CompilerServices;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;

    }

    public string GetCustomerName()
    {
        return _name;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetAddressString()
    {
        return _address.GetFullAddress();
    }
}