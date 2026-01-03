namespace ProxyDesignPattern.RemoteProxyExample;

/// <summary>
/// Remote Proxy - Represents the remote payment service locally.
/// Handles all communication details (serialization, network, deserialization).
/// Client uses this proxy as if it were a local object.
/// </summary>
public class PaymentServiceProxy : IPaymentService
{
    private readonly RemotePaymentServer _remoteServer;
    private readonly string _serverAddress;

    public PaymentServiceProxy(string serverAddress)
    {
        _serverAddress = serverAddress;
        _remoteServer = new RemotePaymentServer(); // Simulates connection to remote server
        
        Console.WriteLine($"[Proxy] Connected to remote server: {_serverAddress}");
    }

    public PaymentResult ProcessPayment(decimal amount, string cardNumber)
    {
        Console.WriteLine($"[Proxy] Preparing payment request...");
        
        // Serialize request (in real scenario: JSON, XML, Protocol Buffers, etc.)
        var parameters = new Dictionary<string, string>
        {
            { "amount", amount.ToString() },
            { "cardNumber", MaskCardNumber(cardNumber) }
        };

        Console.WriteLine($"[Proxy] Sending request to {_serverAddress}...");
        
        // Send to remote server
        var response = _remoteServer.HandleRequest("PROCESS_PAYMENT", parameters);

        // Deserialize response
        var parts = response.Split('|');
        var success = parts[0] == "SUCCESS";
        var transactionId = success ? parts[1] : "";
        var message = success ? parts[2] : parts[1];

        Console.WriteLine($"[Proxy] Response received from server");
        
        return new PaymentResult(success, transactionId, message);
    }

    public decimal GetBalance(string accountId)
    {
        Console.WriteLine($"[Proxy] Requesting balance for {accountId}...");
        
        var parameters = new Dictionary<string, string>
        {
            { "accountId", accountId }
        };

        Console.WriteLine($"[Proxy] Sending request to {_serverAddress}...");
        
        var response = _remoteServer.HandleRequest("GET_BALANCE", parameters);

        var parts = response.Split('|');
        if (parts[0] == "SUCCESS")
        {
            Console.WriteLine($"[Proxy] Response received from server");
            return decimal.Parse(parts[1]);
        }

        throw new Exception(parts[1]);
    }

    private static string MaskCardNumber(string cardNumber)
    {
        if (cardNumber.Length < 4) return "****";
        return $"****-****-****-{cardNumber[^4..]}";
    }
}
