namespace ChainOfResponsibilityDesignPattern.Example3.Handlers;

public class Level2SupportHandler : BaseSupportHandler
{
    public Level2SupportHandler() : base("Level 2 Support") { }

    public override void HandleTicket(SupportTicket ticket)
    {
        // Level 2 can handle Medium priority tickets and Technical/Account issues
        if (CanHandle(ticket, TicketPriority.Medium, new List<TicketCategory> 
            { TicketCategory.Technical, TicketCategory.Account, TicketCategory.General }))
        {
            ticket.Resolve(HandlerName, "Performed advanced diagnostics and applied technical solution.");
        }
        else
        {
            base.HandleTicket(ticket);
        }
    }
}
