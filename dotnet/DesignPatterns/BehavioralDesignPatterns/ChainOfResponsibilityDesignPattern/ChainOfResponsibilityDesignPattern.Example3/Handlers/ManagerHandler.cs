namespace ChainOfResponsibilityDesignPattern.Example3.Handlers;

public class ManagerHandler : BaseSupportHandler
{
    public ManagerHandler() : base("Support Manager") { }

    public override void HandleTicket(SupportTicket ticket)
    {
        // Manager handles all Critical priority tickets
        if (ticket.Priority == TicketPriority.Critical)
        {
            ticket.Resolve(HandlerName, "Escalated to engineering team, provided temporary workaround, and scheduled priority fix.");
        }
        else
        {
            base.HandleTicket(ticket);
        }
    }
}
