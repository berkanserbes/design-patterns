package behavioral.chainofresponsibility.example3;

public class Level2SupportHandler extends BaseSupportHandler {
    public Level2SupportHandler() { super("Level2 Support"); }

    @Override
    public void handleTicket(SupportTicket ticket) {
        if (canHandle(ticket, TicketPriority.Medium, TicketCategory.Technical, TicketCategory.Account, TicketCategory.General)) {
            ticket.setResolved(true);
            ticket.setResolvedBy(getHandlerName());
            ticket.setResolution("Issue resolved by Level 2 support.");
            System.out.println("[Level2 Support] Resolved ticket #" + ticket.getTicketId() + ": " + ticket.getIssue());
        } else {
            System.out.println("[Level2 Support] Escalating ticket #" + ticket.getTicketId() + " (Priority: " + ticket.getPriority() + ", Category: " + ticket.getCategory() + ")");
            super.handleTicket(ticket);
        }
    }
}
