namespace ProxyDesignPattern.SmartReferenceProxyExample;

/// <summary>
/// RealSubject - Actual database connection (expensive resource).
/// </summary>
public class RealDatabaseConnection : IDatabaseConnection
{
    private readonly string _connectionId;
    private bool _isClosed;

    public RealDatabaseConnection()
    {
        _connectionId = Guid.NewGuid().ToString()[..8].ToUpper();
        Console.WriteLine($"[Connection-{_connectionId}] Database connection opened");
    }

    public void ExecuteQuery(string query)
    {
        if (_isClosed)
            throw new InvalidOperationException("Connection is closed");

        Console.WriteLine($"[Connection-{_connectionId}] Executing: {query}");
        Thread.Sleep(100); // Simulate query execution
        Console.WriteLine($"[Connection-{_connectionId}] Query completed");
    }

    public void Close()
    {
        if (!_isClosed)
        {
            _isClosed = true;
            Console.WriteLine($"[Connection-{_connectionId}] Connection closed");
        }
    }
}
