using System;


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    // Constructor to initialize product details
    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    // Method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product ID: {Id}, Name: {Name}, Price: {Price}");
    }

    // Intentional bug: Incorrect data type for price
    public void SetPrice(string price)
    {
        Price = decimal.Parse(price); // This will throw an error if price is not a valid decimal
    }
}
