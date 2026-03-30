package behavioral.chainofresponsibility.example3;

public abstract class BaseSupportHandler implements ISupportHandler {
    private final String handlerName;
    private ISupportHandler nextHandler;

    public BaseSupportHandler(String handlerName) {
        this.handlerName = handlerName;
    }

    @Override
    public ISupportHandler setNext(ISupportHandler handler) {
        this.nextHandler = handler;
        return handler;
    }

    @Override
    public void handleTicket(SupportTicket ticket) {
        if (nextHandler != null) {
            nextHandler.handleTicket(ticket);
        } else {
            System.out.println("[" + handlerName + "] No handler found for ticket #" + ticket.getTicketId());
        }
    }

    protected String getHandlerName() { return handlerName; }

    protected boolean canHandle(SupportTicket ticket, TicketPriority maxPriority, TicketCategory... categories) {
        if (ticket.getPriority().ordinal() > maxPriority.ordinal()) return false;
        if (categories.length == 0) return true;
        for (TicketCategory cat : categories) {
            if (ticket.getCategory() == cat) return true;
        }
        return false;
    }
}
