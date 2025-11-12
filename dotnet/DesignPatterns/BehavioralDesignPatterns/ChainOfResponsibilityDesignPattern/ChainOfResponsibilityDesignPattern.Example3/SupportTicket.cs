namespace ChainOfResponsibilityDesignPattern.Example3;

public enum TicketPriority
{
    Low,
    Medium,
    High,
    Critical
}

public enum TicketCategory
{
    Technical,
    Billing,
    Account,
    General
}

public class SupportTicket
{
    public int TicketId { get; set; }
    public string CustomerName { get; set; }
    public string Issue { get; set; }
    public TicketPriority Priority { get; set; }
    public TicketCategory Category { get; set; }
    public bool IsResolved { get; set; }
    public string? ResolvedBy { get; set; }
    public string? Resolution { get; set; }

    public SupportTicket(int ticketId, string customerName, string issue, TicketPriority priority, TicketCategory category)
    {
        TicketId = ticketId;
        CustomerName = customerName;
        Issue = issue;
        Priority = priority;
        Category = category;
        IsResolved = false;
    }

    public void Resolve(string handler, string resolution)
    {
        IsResolved = true;
        ResolvedBy = handler;
        Resolution = resolution;
    }
}
