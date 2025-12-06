using System;

class Program
{
    static void Main(string[] args)
    {
         //  Order 1 
        Address a1 = new Address("123 Maple St", "Phoenix", "AZ", "USA");
        Customer c1 = new Customer("Jayden Pierce", a1);
        Order o1 = new Order(c1);

        o1.AddProduct(new Product("Laptop", 101, 899.99f, 1));
        o1.AddProduct(new Product("Mouse", 102, 19.99f, 2));

        //  Order 2 
        Address a2 = new Address("55 Ocean Ave", "Vancouver", "BC", "Canada");
        Customer c2 = new Customer("Samantha Lee", a2);
        Order o2 = new Order(c2);

        o2.AddProduct(new Product("Keyboard", 201, 45.50f, 1));
        o2.AddProduct(new Product("Monitor", 202, 129.99f, 2));

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${o1.GetTotalPrice()}");

        // Display Order 2 
        Console.WriteLine("\n===== ORDER 2 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${o2.GetTotalPrice()}");

    }
}