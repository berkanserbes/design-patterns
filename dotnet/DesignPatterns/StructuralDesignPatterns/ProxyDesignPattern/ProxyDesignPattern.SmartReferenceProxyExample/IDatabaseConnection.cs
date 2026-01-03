namespace ProxyDesignPattern.SmartReferenceProxyExample;

/// <summary>
/// Subject Interface - Common interface for database connection.
/// </summary>
public interface IDatabaseConnection
{
    void ExecuteQuery(string query);
    void Close();
}
