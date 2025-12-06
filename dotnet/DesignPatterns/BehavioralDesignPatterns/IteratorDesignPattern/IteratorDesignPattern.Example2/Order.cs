namespace IteratorDesignPattern.Example2;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }

    public Order(int id, string customerName, DateTime orderDate, decimal totalAmount, OrderStatus status)
    {
        Id = id;
        CustomerName = customerName;
        OrderDate = orderDate;
        TotalAmount = totalAmount;
        Status = status;
    }

    public override string ToString()
    {
        return $"Order #{Id} - {CustomerName}, {OrderDate:yyyy-MM-dd}, {TotalAmount:C}, Status: {Status}";
    }
}
