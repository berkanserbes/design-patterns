namespace ChainOfResponsibilityDesignPattern.Example1;

public class OrderRequest
{
    public string OrderId { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal TotalAmount { get; set; }
    public string? DiscountCode { get; set; }
    public bool IsApproved { get; set; }
    public List<string> ProcessMessages { get; set; } = new();

    public void AddMessage(string message)
    {
        ProcessMessages.Add(message);
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"\n--- Order {OrderId} ---");
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Product: {ProductName} (Qty: {Quantity})");
        Console.WriteLine($"Total: ${TotalAmount:F2}");
        Console.WriteLine($"Status: {(IsApproved ? "APPROVED" : "REJECTED")}");
        Console.WriteLine("\nProcess Log:");
        foreach (var message in ProcessMessages)
        {
            Console.WriteLine($"  {message}");
        }
        Console.WriteLine();
    }
}
