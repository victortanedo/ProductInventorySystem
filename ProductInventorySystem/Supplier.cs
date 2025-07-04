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
        Name = name; // Fixed: Initialize Name
        ContactInfo = contactInfo;
        ProductIds = new List<int>();
    }

    public void AddProduct(int productId)
    {
        if (!ProductIds.Contains(productId)) // Prevent adding duplicate productId
        {
            ProductIds.Add(productId);
        }
    }

    public void RemoveProduct(int productId)
    {
        if (ProductIds.Contains(productId)) // Check if productId exists before removing
        {
            ProductIds.Remove(productId);
        }
    }

    public void DisplaySupplierInfo()
    {
        Console.WriteLine($"Supplier ID: {SupplierId}, Name: {Name}, Contact: {ContactInfo}");
        Console.WriteLine("Supplied Product IDs: " + string.Join(", ", ProductIds)); // Use string.Join for display
    }
}
