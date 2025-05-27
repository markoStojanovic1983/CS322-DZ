using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Order deliveryOrder = new DeliveryOrder(1, "Petar Petrović", 1200, "Bulevar kralja Aleksandra 73");
        Order pickupOrder = new PickupOrder(2, "Jelena Jovanović", 800, DateTime.Now.AddHours(1));

        // List to demonstrate polymorphism
        List<Order> orders = new List<Order> { deliveryOrder, pickupOrder };

        // Show details and process orders
        foreach (var order in orders)
        {
            order.DisplayDetails(); 
            Console.WriteLine(order.GetBasicInfo()); 

            if (order is IOrder processableOrder)
            {
                processableOrder.ProcessOrder(); 
                Console.WriteLine($"Total with delivery: {processableOrder.CalculateTotalWithDelivery()} RSD");
            }

            Console.WriteLine();
        }
    }
}
