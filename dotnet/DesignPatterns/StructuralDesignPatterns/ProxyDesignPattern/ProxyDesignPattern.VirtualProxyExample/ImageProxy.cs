namespace ProxyDesignPattern.VirtualProxyExample;

/// <summary>
/// Virtual Proxy - Controls access to the real image.
/// Creates the real image only when Display() is called (lazy loading).
/// Thread-safe implementation using double-check locking.
/// </summary>
public class ImageProxy : IImage
{
    private readonly string _fileName;
    private readonly object _lock = new();
    private HighResolutionImage? _realImage;

    public ImageProxy(string fileName)
    {
        _fileName = fileName;
        Console.WriteLine($"[Proxy] Proxy created for: {_fileName}");
    }

    public void Display()
    {
        // Double-check locking for thread-safe lazy loading
        if (_realImage is null)
        {
            lock (_lock)
            {
                if (_realImage is null)
                {
                    Console.WriteLine($"[Proxy] First access - loading real image...");
                    _realImage = new HighResolutionImage(_fileName);
                }
            }
        }
        
        _realImage.Display();
    }

    public bool IsLoaded => _realImage is not null;
}
