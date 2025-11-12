namespace ChainOfResponsibilityDesignPattern.Example3.Handlers;

public class Level1SupportHandler : BaseSupportHandler
{
    public Level1SupportHandler() : base("Level 1 Support") { }

    public override void HandleTicket(SupportTicket ticket)
    {
        // Level 1 can handle Low priority tickets and basic General issues
        if (CanHandle(ticket, TicketPriority.Low, new List<TicketCategory> { TicketCategory.General }))
        {
            ticket.Resolve(HandlerName, "Provided basic troubleshooting steps and FAQ links.");
        }
        else
        {
            base.HandleTicket(ticket);
        }
    }
}
