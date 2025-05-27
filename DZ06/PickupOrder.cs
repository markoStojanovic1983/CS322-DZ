using System;

// Class for pickup orders
public class PickupOrder : Order, IOrder
{
    public DateTime PickupTime { get; set; }

    public PickupOrder(int orderNumber, string customerName, double totalPrice, DateTime pickupTime)
        : base(orderNumber, customerName, totalPrice)
    {
        PickupTime = pickupTime;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Pickup Order - Number: {OrderNumber}, Customer: {CustomerName}, Price: {TotalPrice} RSD, Pickup Time: {PickupTime}");
    }

    public void ProcessOrder()
    {
        Console.WriteLine($"Order {OrderNumber} for pickup processed. It will be ready at: {PickupTime}.");
    }

    public override double CalculateTotalWithDelivery()
    {
        return TotalPrice;
    }
}
