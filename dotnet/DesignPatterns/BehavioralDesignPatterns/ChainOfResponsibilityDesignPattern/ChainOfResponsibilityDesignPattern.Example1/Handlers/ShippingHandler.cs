namespace ChainOfResponsibilityDesignPattern.Example1.Handlers;

public class ShippingHandler : BaseOrderHandler
{
    private readonly Random _random = new();

    public override void Handle(OrderRequest request)
    {
        var shippingMethod = request.TotalAmount > 1000 ? "Express" : "Standard";
        var trackingNumber = $"TRK{_random.Next(100000, 999999)}";

        request.AddMessage($"Shipping arranged: {shippingMethod} ({trackingNumber})");
        request.IsApproved = true;
        
        base.Handle(request);
    }
}
