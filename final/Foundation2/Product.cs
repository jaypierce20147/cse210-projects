using System;

public class Product
{
    private string _name;
    private int _id;
    private float _pricePerUnit;
    private int _quantity;
    
    // Get the name, id, price per unit, and the quantity of the items
    public Product(string name, int id, float pricePerUnit, int quantity)
    {
        _name = name;
        _id = id;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Get the total cost of order
    public float GetTotalCost()
    {
        return _pricePerUnit * _quantity;

    }

    // Get the name of the item
    public string GetName()
    {
        return _name;
    }

    // Get the Id of the item
    public int GetId()
    {
        return _id;
    }
}