namespace ChainOfResponsibilityDesignPattern.Example3.Handlers;

public class TeamLeadHandler : BaseSupportHandler
{
    public TeamLeadHandler() : base("Team Lead") { }

    public override void HandleTicket(SupportTicket ticket)
    {
        // Team Lead can handle High priority tickets
        if (CanHandle(ticket, TicketPriority.High))
        {
            ticket.Resolve(HandlerName, "Coordinated with technical team and implemented custom solution.");
        }
        else
        {
            base.HandleTicket(ticket);
        }
    }
}
