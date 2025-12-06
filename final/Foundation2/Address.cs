using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Store the address
    public Address(string street, string city, string state, string country)
    {
       _street = street;
       _city = city;
       _state = state;
       _country = country; 
    }

    // Check if user lives in the USA
    public bool IsInUSA()
    {
        return _country.Trim().ToLower() == "usa";
    }
    
    // Get the addrress
    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}