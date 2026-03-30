package behavioral.chainofresponsibility.example3;

public interface ISupportHandler {
    ISupportHandler setNext(ISupportHandler handler);
    void handleTicket(SupportTicket ticket);
}
