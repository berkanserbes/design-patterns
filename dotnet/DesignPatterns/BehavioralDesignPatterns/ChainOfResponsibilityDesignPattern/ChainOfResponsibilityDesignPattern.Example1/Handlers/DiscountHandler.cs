namespace ChainOfResponsibilityDesignPattern.Example1.Handlers;

public class DiscountHandler : BaseOrderHandler
{
    private readonly Dictionary<string, decimal> _discountCodes;

    public DiscountHandler()
    {
        _discountCodes = new Dictionary<string, decimal>
        {
            { "SUMMER20", 0.20m },
            { "WELCOME10", 0.10m },
            { "VIP30", 0.30m },
            { "NEWYEAR15", 0.15m }
        };
    }

    public override void Handle(OrderRequest request)
    {
        if (string.IsNullOrEmpty(request.DiscountCode))
        {
            request.AddMessage("No discount code applied");
            base.Handle(request);
            return;
        }

        if (_discountCodes.ContainsKey(request.DiscountCode))
        {
            var discountPercentage = _discountCodes[request.DiscountCode];
            var discountAmount = request.TotalAmount * discountPercentage;
            request.TotalAmount -= discountAmount;
            
            request.AddMessage($"Discount applied: {discountPercentage * 100}% off, saved ${discountAmount:F2}");
        }
        else
        {
            request.AddMessage($"Invalid discount code: '{request.DiscountCode}'");
        }
        
        base.Handle(request);
    }
}
