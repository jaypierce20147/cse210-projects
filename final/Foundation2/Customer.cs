using System;
using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    // Store the customers name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Asks the address if its in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Get the name of the customer
    public string GetName()
    {
        return _name;
    }

    // Get the shipping address
    public string GetShippingAddress()
    {
        return _address.GetAddressString();
    }
}