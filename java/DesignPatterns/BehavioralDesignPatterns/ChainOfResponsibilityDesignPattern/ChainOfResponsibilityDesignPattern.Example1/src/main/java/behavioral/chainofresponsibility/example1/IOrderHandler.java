package behavioral.chainofresponsibility.example1;

public interface IOrderHandler {
    IOrderHandler setNext(IOrderHandler handler);
    void handle(OrderRequest request);
}
