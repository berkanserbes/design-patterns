namespace ProxyDesignPattern.VirtualProxyExample;

/// <summary>
/// RealSubject - The actual high-resolution image.
/// Creating this object is expensive (simulated with delay).
/// </summary>
public class HighResolutionImage : IImage
{
    private readonly string _fileName;

    public HighResolutionImage(string fileName)
    {
        _fileName = fileName;
        LoadImageFromDisk();
    }

    private void LoadImageFromDisk()
    {
        Console.WriteLine($"[RealImage] Loading image: {_fileName}");
        Console.WriteLine("[RealImage] Connecting to storage...");
        Thread.Sleep(1000);
        
        Console.WriteLine("[RealImage] Downloading image data...");
        Thread.Sleep(1500);
        
        Console.WriteLine($"[RealImage] Image '{_fileName}' loaded successfully!");
    }

    public void Display()
    {
        Console.WriteLine($"[RealImage] Displaying: {_fileName}");
    }
}
