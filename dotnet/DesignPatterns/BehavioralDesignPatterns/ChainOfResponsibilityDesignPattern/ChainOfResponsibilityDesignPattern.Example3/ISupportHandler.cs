namespace ChainOfResponsibilityDesignPattern.Example3;

public interface ISupportHandler
{
    ISupportHandler SetNext(ISupportHandler handler);
    void HandleTicket(SupportTicket ticket);
}
