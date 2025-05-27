using System;

// Class for deliver orders
public class DeliveryOrder : Order, IOrder
{
    public string DeliveryAddress { get; set; }

    public DeliveryOrder(int orderNumber, string customerName, double totalPrice, string deliveryAddress)
        : base(orderNumber, customerName, totalPrice)
    {
        DeliveryAddress = deliveryAddress;
        DeliveryFee = 200; 

    }

    // 
    public override void DisplayDetails()
    {
        Console.WriteLine($"Delivery Order - Number: {OrderNumber}, Customer: {CustomerName}, Price: {TotalPrice} RSD, Address: {DeliveryAddress}, Delivery Fee: {DeliveryFee} RSD");
    }

    public void ProcessOrder()
    {
        Console.WriteLine($"Order {OrderNumber} for delivery processed. It will be delivered to: {DeliveryAddress}.");
    }

    public override double CalculateTotalWithDelivery()
    {
        return TotalPrice + DeliveryFee; 
    }
}
