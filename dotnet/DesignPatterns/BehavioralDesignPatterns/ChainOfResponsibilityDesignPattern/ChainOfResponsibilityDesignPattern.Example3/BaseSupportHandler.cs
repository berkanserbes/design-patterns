namespace ChainOfResponsibilityDesignPattern.Example3;

public abstract class BaseSupportHandler : ISupportHandler
{
    private ISupportHandler? _nextHandler;
    protected string HandlerName { get; set; }

    protected BaseSupportHandler(string handlerName)
    {
        HandlerName = handlerName;
    }

    public ISupportHandler SetNext(ISupportHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual void HandleTicket(SupportTicket ticket)
    {
        if (_nextHandler != null)
        {
            _nextHandler.HandleTicket(ticket);
        }
    }

    protected bool CanHandle(SupportTicket ticket, TicketPriority maxPriority, List<TicketCategory>? categories = null)
    {
        bool priorityMatch = ticket.Priority <= maxPriority;
        bool categoryMatch = categories == null || categories.Contains(ticket.Category);
        
        return priorityMatch && categoryMatch;
    }
}
