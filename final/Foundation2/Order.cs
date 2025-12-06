using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    // Holds the customer
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Holds the products
    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    // Get the total price
    public float GetTotalPrice()
    {
        float total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        
        // Shipping cost
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
        
    }
    
    // Get the packing label and format it
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += $"Product: {p.GetName()} ID: {p.GetId()}\n";
        }
        return label;
    }

    // Get the shipping label and format it.
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetShippingAddress()}";
        
    }

}