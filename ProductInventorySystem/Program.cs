using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        List<Supplier> suppliers = new List<Supplier>();
        List<Order> orders = new List<Order>();
        int supplierCounter = 0;
        int orderCounter = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Product");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. View Products");
            Console.WriteLine("5. Add Supplier");
            Console.WriteLine("6. View Suppliers");
            Console.WriteLine("7. Add Order");
            Console.WriteLine("8. View Orders");
            Console.WriteLine("9. Exit");
            Console.Write("Choose an option: ");

            // Intentional bug: Not validating user input properly
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Intentional bug: Not handling input correctly
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Product Price: ");
                    decimal price = Convert.ToDecimal(Console.ReadLine()); // Potential exception if input is invalid
                    Product newProduct = new Product(inventory.GetAllProducts().Count, name, price);
                    inventory.AddProduct(newProduct);

                    Console.Write("Assign to Supplier? (y/n): ");
                    string assign = Console.ReadLine();
                    if (assign == "y")
                    {
                        Console.Write("Enter Supplier ID: ");
                        int supId = int.Parse(Console.ReadLine()); // Intentional bug: No error handling
                        Supplier foundSupplier = suppliers.Find(s => s.SupplierId == supId);
                        if (foundSupplier != null)
                        {
                            inventory.AddProductWithSupplier(newProduct, foundSupplier);
                        }
                        else
                        {
                            Console.WriteLine("Supplier not found.");
                        }
                    }
                    break;

                case "2":
                    Console.Write("Enter Product ID to update: ");
                    int updateId = int.Parse(Console.ReadLine()); // Intentional bug: No error handling for invalid input
                    Console.Write("Enter new Product Name: ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter new Product Price: ");
                    decimal newPrice = Convert.ToDecimal(Console.ReadLine());
                    Product updatedProduct = new Product(updateId, newName, newPrice);
                    inventory.UpdateProduct(updateId, updatedProduct);
                    break;

                case "3":
                    Console.Write("Enter Product ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    inventory.DeleteProduct(deleteId);
                    break;

                case "4":
                    List<Product> allProducts = inventory.GetAllProducts();
                    foreach (var prod in allProducts)
                    {
                        prod.DisplayProductDetails();
                    }
                    break;

                case "5":
                    Console.Write("Enter Supplier Name: ");
                    string supplierName = Console.ReadLine();
                    Console.Write("Enter Supplier Contact Info: ");
                    string contact = Console.ReadLine();
                    Supplier supplier = new Supplier(supplierCounter++, supplierName, contact);
                    suppliers.Add(supplier);
                    break;

                case "6":
                    foreach (var sup in suppliers)
                    {
                        sup.DisplaySupplierInfo();
                    }
                    break;

                case "7":
                    Console.Write("Enter Product ID for Order: ");
                    int orderProdId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Quantity: ");
                    int qty = int.Parse(Console.ReadLine());
                    Order order = new Order(orderCounter++, orderProdId, qty, DateTime.Now);
                    orders.Add(order);
                    Console.Write("Fulfill order now? (y/n): ");
                    string fulfill = Console.ReadLine();
                    if (fulfill == "y")
                    {
                        order.FulfillOrder(inventory);
                    }
                    break;

                case "8":
                    foreach (var o in orders)
                    {
                        o.DisplayOrderDetails();
                    }
                    break;

                case "9":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again."); // Intentional bug: Not handling unexpected input gracefully
                    break;
            }
        }
    }
}

