namespace ProxyDesignPattern.RemoteProxyExample;

/// <summary>
/// Simulates a remote payment server running on a different machine.
/// In real scenarios, this would be an actual remote service.
/// </summary>
public class RemotePaymentServer
{
    private readonly Dictionary<string, decimal> _accounts = new()
    {
        { "ACC-001", 5000.00m },
        { "ACC-002", 1500.00m },
        { "ACC-003", 250.00m }
    };

    public string HandleRequest(string requestType, Dictionary<string, string> parameters)
    {
        Console.WriteLine($"[RemoteServer] Received request: {requestType}");
        Thread.Sleep(500); // Simulate network latency

        return requestType switch
        {
            "PROCESS_PAYMENT" => ProcessPaymentRequest(parameters),
            "GET_BALANCE" => GetBalanceRequest(parameters),
            _ => "ERROR|Unknown request type"
        };
    }

    private string ProcessPaymentRequest(Dictionary<string, string> parameters)
    {
        var amount = decimal.Parse(parameters["amount"]);
        var cardNumber = parameters["cardNumber"];
        
        Console.WriteLine($"[RemoteServer] Processing payment: {amount:C}");
        Thread.Sleep(1000); // Simulate processing time

        var transactionId = $"TXN-{Guid.NewGuid().ToString()[..8].ToUpper()}";
        
        Console.WriteLine($"[RemoteServer] Payment approved. Transaction: {transactionId}");
        return $"SUCCESS|{transactionId}|Payment processed successfully";
    }

    private string GetBalanceRequest(Dictionary<string, string> parameters)
    {
        var accountId = parameters["accountId"];
        
        if (_accounts.TryGetValue(accountId, out var balance))
        {
            Console.WriteLine($"[RemoteServer] Balance for {accountId}: {balance:C}");
            return $"SUCCESS|{balance}";
        }

        return "ERROR|Account not found";
    }
}
