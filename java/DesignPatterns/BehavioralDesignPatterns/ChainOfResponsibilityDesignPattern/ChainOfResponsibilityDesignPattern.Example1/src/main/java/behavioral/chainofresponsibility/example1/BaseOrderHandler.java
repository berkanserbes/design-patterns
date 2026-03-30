package behavioral.chainofresponsibility.example1;

public abstract class BaseOrderHandler implements IOrderHandler {
    private IOrderHandler nextHandler;

    @Override
    public IOrderHandler setNext(IOrderHandler handler) {
        this.nextHandler = handler;
        return handler;
    }

    @Override
    public void handle(OrderRequest request) {
        if (nextHandler != null) {
            nextHandler.handle(request);
        }
    }
}
