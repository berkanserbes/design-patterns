namespace ProxyDesignPattern.SmartReferenceProxyExample;

/// <summary>
/// Smart Reference Proxy - Tracks references and adds extra behavior:
/// - Reference counting
/// - Access logging
/// - Last access time tracking
/// - Auto-close when reference count reaches zero
/// </summary>
public class DatabaseConnectionProxy : IDatabaseConnection
{
    private readonly RealDatabaseConnection _realConnection;
    private readonly string _proxyId;
    
    private int _referenceCount;
    private int _queryCount;
    private DateTime _lastAccessTime;
    private bool _isClosed;

    public DatabaseConnectionProxy()
    {
        _proxyId = Guid.NewGuid().ToString()[..4].ToUpper();
        _realConnection = new RealDatabaseConnection();
        _referenceCount = 1;
        _lastAccessTime = DateTime.Now;
        
        Console.WriteLine($"[Proxy-{_proxyId}] Smart proxy created. Reference count: {_referenceCount}");
    }

    public void AddReference()
    {
        _referenceCount++;
        Console.WriteLine($"[Proxy-{_proxyId}] Reference added. Count: {_referenceCount}");
    }

    public void ReleaseReference()
    {
        _referenceCount--;
        Console.WriteLine($"[Proxy-{_proxyId}] Reference released. Count: {_referenceCount}");

        if (_referenceCount <= 0)
        {
            Console.WriteLine($"[Proxy-{_proxyId}] No more references - auto-closing connection");
            Close();
        }
    }

    public void ExecuteQuery(string query)
    {
        if (_isClosed)
            throw new InvalidOperationException("Connection is closed");

        _queryCount++;
        _lastAccessTime = DateTime.Now;

        // Log access
        Console.WriteLine($"[Proxy-{_proxyId}] Query #{_queryCount} at {_lastAccessTime:HH:mm:ss}");
        
        _realConnection.ExecuteQuery(query);
    }

    public void Close()
    {
        if (!_isClosed)
        {
            _isClosed = true;
            _realConnection.Close();
            Console.WriteLine($"[Proxy-{_proxyId}] Statistics: {_queryCount} queries executed");
        }
    }

    public void PrintStatistics()
    {
        Console.WriteLine($"\n[Proxy-{_proxyId}] --- Statistics ---");
        Console.WriteLine($"[Proxy-{_proxyId}] Reference Count: {_referenceCount}");
        Console.WriteLine($"[Proxy-{_proxyId}] Queries Executed: {_queryCount}");
        Console.WriteLine($"[Proxy-{_proxyId}] Last Access: {_lastAccessTime:HH:mm:ss}");
        Console.WriteLine($"[Proxy-{_proxyId}] Is Closed: {_isClosed}");
    }
}
