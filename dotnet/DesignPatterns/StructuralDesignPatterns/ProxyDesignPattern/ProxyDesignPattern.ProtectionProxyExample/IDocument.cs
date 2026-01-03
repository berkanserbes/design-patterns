namespace ProxyDesignPattern.ProtectionProxyExample;

/// <summary>
/// Subject Interface - Common interface for real document and proxy.
/// </summary>
public interface IDocument
{
    void Read();
    void Write(string content);
    void Delete();
}
