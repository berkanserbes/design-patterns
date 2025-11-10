namespace ChainOfResponsibilityDesignPattern.Example1.Handlers;

public class StockValidationHandler : BaseOrderHandler
{
    private readonly Dictionary<string, int> _stockInventory;

    public StockValidationHandler()
    {
        _stockInventory = new Dictionary<string, int>
        {
            { "Laptop", 10 },
            { "Mouse", 50 },
            { "Keyboard", 30 },
            { "Monitor", 5 },
            { "Headphones", 0 }
        };
    }

    public override void Handle(OrderRequest request)
    {
        if (!_stockInventory.ContainsKey(request.ProductName))
        {
            request.AddMessage($"Stock validation failed: Product '{request.ProductName}' not found");
            request.IsApproved = false;
            return;
        }

        var availableStock = _stockInventory[request.ProductName];

        if (availableStock >= request.Quantity)
        {
            _stockInventory[request.ProductName] -= request.Quantity;
            request.AddMessage($"Stock validated: {request.Quantity} units available");
            base.Handle(request);
        }
        else
        {
            request.AddMessage($"Insufficient stock: Need {request.Quantity}, available {availableStock}");
            request.IsApproved = false;
        }
    }
}
