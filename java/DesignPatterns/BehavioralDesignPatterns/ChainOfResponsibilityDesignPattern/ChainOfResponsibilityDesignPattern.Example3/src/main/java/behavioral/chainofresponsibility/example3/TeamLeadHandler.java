package behavioral.chainofresponsibility.example3;

public class TeamLeadHandler extends BaseSupportHandler {
    public TeamLeadHandler() { super("Team Lead"); }

    @Override
    public void handleTicket(SupportTicket ticket) {
        if (canHandle(ticket, TicketPriority.High)) {
            ticket.setResolved(true);
            ticket.setResolvedBy(getHandlerName());
            ticket.setResolution("Issue resolved by Team Lead.");
            System.out.println("[Team Lead] Resolved ticket #" + ticket.getTicketId() + ": " + ticket.getIssue());
        } else {
            System.out.println("[Team Lead] Escalating ticket #" + ticket.getTicketId() + " (Priority: " + ticket.getPriority() + ")");
            super.handleTicket(ticket);
        }
    }
}
