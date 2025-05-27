public abstract class Order
{
    public int OrderNumber { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }
    public double DeliveryFee { get; protected set; } = 0; // Default value for delivery fee

    public Order(int orderNumber, string customerName, double totalPrice)
    {
        OrderNumber = orderNumber;
        CustomerName = customerName;
        TotalPrice = totalPrice;
    }

    // Formated basic info
    public virtual string GetBasicInfo()
    {
        return $"Order #{OrderNumber} for {CustomerName}, Total: {TotalPrice} RSD";
    }

    // Method for calculating total price with delivery
    public virtual double CalculateTotalWithDelivery()
    {
        return TotalPrice + DeliveryFee; 
    }

    // Abstract method for dietails
    public abstract void DisplayDetails();
}
