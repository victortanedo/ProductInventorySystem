using System;

public class Order
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime OrderDate { get; set; }
    public bool IsFulfilled { get; set; }

    public Order(int orderId, int productId, int quantity, DateTime orderDate)
    {
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        OrderDate = orderDate;
        IsFulfilled = false;
    }

    public void FulfillOrder(Inventory inventory)
    {
        // Intentional bug: Not checking if product exists before updating
        Product product = inventory.GetProduct(ProductId);
        product.Price -= 1; // Intentional bug: Reducing price instead of updating stock/quantity
        IsFulfilled = true;
    }
}