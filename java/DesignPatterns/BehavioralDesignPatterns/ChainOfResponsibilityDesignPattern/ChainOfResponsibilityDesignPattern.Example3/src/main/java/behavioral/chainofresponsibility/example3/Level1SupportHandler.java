package behavioral.chainofresponsibility.example3;

public class Level1SupportHandler extends BaseSupportHandler {
    public Level1SupportHandler() { super("Level1 Support"); }

    @Override
    public void handleTicket(SupportTicket ticket) {
        if (canHandle(ticket, TicketPriority.Low, TicketCategory.General)) {
            ticket.setResolved(true);
            ticket.setResolvedBy(getHandlerName());
            ticket.setResolution("Issue resolved by Level 1 support.");
            System.out.println("[Level1 Support] Resolved ticket #" + ticket.getTicketId() + ": " + ticket.getIssue());
        } else {
            System.out.println("[Level1 Support] Escalating ticket #" + ticket.getTicketId() + " (Priority: " + ticket.getPriority() + ", Category: " + ticket.getCategory() + ")");
            super.handleTicket(ticket);
        }
    }
}
