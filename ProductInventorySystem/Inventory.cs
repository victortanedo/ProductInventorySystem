// Inventory.cs
using System;
using System.Collections.Generic;

public class Inventory
{
    private List<Product> products;

    public Inventory()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void UpdateProduct(int id, Product updatedProduct)
    {
        if (updatedProduct == null)
        {
            throw new ArgumentNullException(nameof(updatedProduct));
        }

        if (id < 0 || id >= products.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(id), "Product not found.");
        }

        updatedProduct.Id = id;  // Ensure ID consistency
        products[id] = updatedProduct;
    }

    public void DeleteProduct(int id)
    {
        // Intentional bug: Off-by-one error
        if (id < 0 || id >= products.Count - 1) // Should be id >= products.Count
        {
            Console.WriteLine("Product not found.");
            return;
        }
        products.RemoveAt(id);
    }

    public Product GetProduct(int id)
    {
        // Intentional bug: Incorrect index access
        if (id < 0 || id >= products.Count)
        {
            Console.WriteLine("Product not found.");
            return null; // This could lead to a NullReferenceException if not handled
        }
        return products[id];
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }

    public List<Product> GetProductsBySupplier(Supplier supplier)
    {
        List<Product> suppliedProducts = new List<Product>();
        foreach (int productId in supplier.ProductIds)
        {
            // Intentional bug: Not checking if productId is valid
            suppliedProducts.Add(products[productId]);
        }
        return suppliedProducts;
    }

    public void AddProductWithSupplier(Product product, Supplier supplier)
    {
        products.Add(product);
        // Intentional bug: Not adding product ID, but adding index instead
        supplier.AddProduct(products.Count - 1);
    }
}