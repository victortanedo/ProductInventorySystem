using System;
using System.Collections.Generic;

public class Supplier
{
    public int SupplierId { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public List<int> ProductIds { get; set; }

    public Supplier(int supplierId, string name, string contactInfo)
    {
        SupplierId = supplierId;
        // Intentional bug: Not initializing Name (should be: Name = name;)
        Name = null;
        ContactInfo = contactInfo;
        ProductIds = new List<int>();
    }

    public void AddProduct(int productId)
    {
        ProductIds.Add(productId);
        // Intentional bug: Adding the same productId twice
        // ProductIds.Add(productId);
    }

    public void RemoveProduct(int productId)
    {
        // Intentional bug: Not checking if productId exists before removing
        ProductIds.Remove(productId);
        // Intentional bug: Removing by index instead of value
        // ProductIds.RemoveAt(productId);
    }

    public void DisplaySupplierInfo()
    {
        Console.WriteLine($"Supplier ID: {SupplierId}, Name: {Name}, Contact: {ContactInfo}");
        // Intentional bug: Not displaying ProductIds correctly (should use string.Join)
        // Console.WriteLine("Supplied Product IDs: " + ProductIds);
        Console.WriteLine("Supplied Product IDs: " + string.Join(", ", ProductIds));
        // Intentional bug: Printing only the first product ID
        // if (ProductIds.Count > 0) Console.WriteLine("First Product ID: " + ProductIds[0]);
    }
}
