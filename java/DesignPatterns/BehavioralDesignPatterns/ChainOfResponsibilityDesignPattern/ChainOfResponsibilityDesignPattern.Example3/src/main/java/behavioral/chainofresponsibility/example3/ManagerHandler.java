package behavioral.chainofresponsibility.example3;

public class ManagerHandler extends BaseSupportHandler {
    public ManagerHandler() { super("Manager"); }

    @Override
    public void handleTicket(SupportTicket ticket) {
        ticket.setResolved(true);
        ticket.setResolvedBy(getHandlerName());
        ticket.setResolution("Critical issue handled by Manager.");
        System.out.println("[Manager] Resolved ticket #" + ticket.getTicketId() + ": " + ticket.getIssue());
    }
}
