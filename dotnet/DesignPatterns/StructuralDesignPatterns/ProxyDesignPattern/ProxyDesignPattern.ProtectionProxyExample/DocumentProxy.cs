namespace ProxyDesignPattern.ProtectionProxyExample;

/// <summary>
/// Protection Proxy - Controls access to the document based on user role.
/// 
/// Access Rules:
/// - Viewer: Can only Read
/// - Editor: Can Read and Write
/// - Admin:  Can Read, Write and Delete
/// </summary>
public class DocumentProxy : IDocument
{
    private readonly SensitiveDocument _realDocument;
    private readonly User _user;

    public DocumentProxy(SensitiveDocument document, User user)
    {
        _realDocument = document;
        _user = user;
        Console.WriteLine($"[Proxy] Access granted to user '{_user.Name}' with role '{_user.Role}'");
    }

    public void Read()
    {
        // All roles can read
        Console.WriteLine($"[Proxy] User '{_user.Name}' is reading...");
        _realDocument.Read();
    }

    public void Write(string content)
    {
        // Only Editor and Admin can write
        if (_user.Role == Role.Viewer)
        {
            Console.WriteLine($"[Proxy] ACCESS DENIED: '{_user.Name}' (Viewer) cannot write!");
            return;
        }

        Console.WriteLine($"[Proxy] User '{_user.Name}' is writing...");
        _realDocument.Write(content);
    }

    public void Delete()
    {
        // Only Admin can delete
        if (_user.Role != Role.Admin)
        {
            Console.WriteLine($"[Proxy] ACCESS DENIED: '{_user.Name}' ({_user.Role}) cannot delete!");
            return;
        }

        Console.WriteLine($"[Proxy] User '{_user.Name}' is deleting...");
        _realDocument.Delete();
    }
}
