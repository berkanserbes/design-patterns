namespace ChainOfResponsibilityDesignPattern.Example1;

public interface IOrderHandler
{
    IOrderHandler SetNext(IOrderHandler handler);
    void Handle(OrderRequest request);
}
