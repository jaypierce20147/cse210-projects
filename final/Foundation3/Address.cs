using System;
public class Address
{
    private string _street;
    private string _city;
    private string _state;

    // Get the addrress
    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
    }

    // Return the address
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}";
    }
}