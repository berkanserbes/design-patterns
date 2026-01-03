namespace ProxyDesignPattern.VirtualProxyExample;

/// <summary>
/// Subject Interface - Common interface for both the real image and its proxy.
/// </summary>
public interface IImage
{
    void Display();
}
