namespace ChainOfResponsibilityDesignPattern.Example1.Handlers;

public class PaymentValidationHandler : BaseOrderHandler
{
    private readonly Dictionary<string, decimal> _customerBalances;

    public PaymentValidationHandler()
    {
        _customerBalances = new Dictionary<string, decimal>
        {
            { "John Doe", 5000m },
            { "Jane Smith", 1500m },
            { "Bob Johnson", 500m },
            { "Alice Williams", 10000m }
        };
    }

    public override void Handle(OrderRequest request)
    {
        if (!_customerBalances.ContainsKey(request.CustomerName))
        {
            request.AddMessage($"Payment failed: Customer '{request.CustomerName}' not found");
            request.IsApproved = false;
            return;
        }

        var customerBalance = _customerBalances[request.CustomerName];

        if (customerBalance >= request.TotalAmount)
        {
            _customerBalances[request.CustomerName] -= request.TotalAmount;
            request.AddMessage($"Payment validated: ${request.TotalAmount:F2} charged");
            base.Handle(request);
        }
        else
        {
            request.AddMessage($"Insufficient balance: Need ${request.TotalAmount:F2}, available ${customerBalance:F2}");
            request.IsApproved = false;
        }
    }
}
