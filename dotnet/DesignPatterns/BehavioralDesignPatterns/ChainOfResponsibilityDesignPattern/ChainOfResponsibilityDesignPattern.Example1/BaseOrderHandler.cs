namespace ChainOfResponsibilityDesignPattern.Example1;

public abstract class BaseOrderHandler : IOrderHandler
{
    private IOrderHandler? _nextHandler;

    public IOrderHandler SetNext(IOrderHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual void Handle(OrderRequest request)
    {
        if (_nextHandler != null)
        {
            _nextHandler.Handle(request);
        }
    }
}
