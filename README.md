# Product Inventory System

A simple C# console application for managing products, suppliers, and orders in an inventory system. This project is designed for beginners to practice debugging and understanding object-oriented programming concepts. Some intentional bugs are included for educational purposes.

## Project Structure

- **Product.cs**: Represents a product in the inventory.
- **Supplier.cs**: Represents a supplier and the products they supply.
- **Inventory.cs**: Manages the collection of products and their association with suppliers.
- **Order.cs**: Represents an order for a product.
- **Program.cs**: The main entry point and user interface for the application.

---

## Class and Method Overview

### Product
Represents a product with an ID, name, and price.

- **Properties:**
  - `int Id`: Unique identifier for the product.
  - `string Name`: Name of the product.
  - `decimal Price`: Price of the product.
- **Constructor:**
  - `Product(int id, string name, decimal price)`: Initializes a new product.
- **Methods:**
  - `void DisplayProductDetails()`: Prints product details to the console.

### Supplier
Represents a supplier with an ID, name, contact info, and a list of supplied product IDs.

- **Properties:**
  - `int SupplierId`: Unique identifier for the supplier.
  - `string Name`: Name of the supplier.
  - `string ContactInfo`: Contact information.
  - `List<int> ProductIds`: List of product IDs supplied.
- **Constructor:**
  - `Supplier(int supplierId, string name, string contactInfo)`: Initializes a new supplier.
- **Methods:**
  - `void AddProduct(int productId)`: Adds a product ID to the supplier's list.
  - `void RemoveProduct(int productId)`: Removes a product ID from the supplier's list.
  - `void DisplaySupplierInfo()`: Prints supplier details and supplied product IDs.

### Inventory
Manages the collection of products and their association with suppliers.

- **Fields:**
  - `List<Product> products`: Internal list of products.
- **Constructor:**
  - `Inventory()`: Initializes the inventory.
- **Methods:**
  - `void AddProduct(Product product)`: Adds a product to the inventory.
  - `void UpdateProduct(int id, Product updatedProduct)`: Updates a product at the given index.
  - `void DeleteProduct(int id)`: Removes a product at the given index.
  - `Product GetProduct(int id)`: Gets a product at the given index.
  - `List<Product> GetAllProducts()`: Returns all products.
  - `List<Product> GetProductsBySupplier(Supplier supplier)`: Gets products supplied by a specific supplier.
  - `void AddProductWithSupplier(Product product, Supplier supplier)`: Adds a product and associates it with a supplier.

### Order
Represents an order for a product.

- **Properties:**
  - `int OrderId`: Unique identifier for the order.
  - `int ProductId`: ID of the product being ordered.
  - `int Quantity`: Quantity ordered.
  - `DateTime OrderDate`: Date of the order.
  - `bool IsFulfilled`: Whether the order has been fulfilled.
- **Constructor:**
  - `Order(int orderId, int productId, int quantity, DateTime orderDate)`: Initializes a new order.
- **Methods:**
  - `void FulfillOrder(Inventory inventory)`: Fulfills the order (contains intentional bugs for practice).
  - `void DisplayOrderDetails()`: Prints order details to the console.

### Program
The main entry point for the application. Handles user interaction and menu navigation.

- **Main(string[] args)**: Runs the main menu loop, allowing users to add, update, delete, and view products, suppliers, and orders.

---

## Notes
- This project is for educational purposes and contains intentional bugs for debugging practice.
- To run the project, open it in Visual Studio or your preferred .NET IDE and build/run the solution.
