namespace ProxyDesignPattern.ProtectionProxyExample;

/// <summary>
/// RealSubject - The actual sensitive document.
/// Contains the real implementation without any access control.
/// </summary>
public class SensitiveDocument : IDocument
{
    private readonly string _name;
    private string _content;

    public SensitiveDocument(string name, string content)
    {
        _name = name;
        _content = content;
    }

    public void Read()
    {
        Console.WriteLine($"[Document] Reading '{_name}':");
        Console.WriteLine($"[Document] Content: {_content}");
    }

    public void Write(string content)
    {
        _content = content;
        Console.WriteLine($"[Document] Content updated to: {_content}");
    }

    public void Delete()
    {
        Console.WriteLine($"[Document] '{_name}' has been deleted!");
        _content = string.Empty;
    }
}
