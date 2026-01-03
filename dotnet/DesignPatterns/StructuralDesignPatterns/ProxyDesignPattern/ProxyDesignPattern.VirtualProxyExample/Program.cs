// ============================================================================
// VIRTUAL PROXY DESIGN PATTERN
// ============================================================================
// Virtual Proxy delays the creation of an expensive object until it is needed.
// 
// Pattern Structure:
//   - IImage: Subject interface
//   - HighResolutionImage: RealSubject (expensive to create)
//   - ImageProxy: Proxy (creates RealSubject only when needed)
// ============================================================================

namespace ProxyDesignPattern.VirtualProxyExample;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== VIRTUAL PROXY PATTERN DEMO ===\n");

        // Create proxies for 3 images (no real images loaded yet!)
        Console.WriteLine("--- Creating image proxies (instant) ---\n");
        
        IImage image1 = new ImageProxy("photo1.png");
        IImage image2 = new ImageProxy("photo2.png");
        IImage image3 = new ImageProxy("photo3.png");

        Console.WriteLine("\n--- All proxies created. No images loaded yet! ---\n");
        Console.WriteLine("Press any key to display image 2...");
        Console.ReadKey();
        Console.WriteLine("\n");

        // Only image2 will be loaded now
        Console.WriteLine("--- Displaying image 2 (triggers loading) ---\n");
        image2.Display();

        Console.WriteLine("\n--- Displaying image 2 again (already loaded) ---\n");
        image2.Display();

        Console.WriteLine("\n--- Checking which images are loaded ---\n");
        Console.WriteLine($"Image 1: {(((ImageProxy)image1).IsLoaded ? "LOADED" : "NOT LOADED")}");
        Console.WriteLine($"Image 2: {(((ImageProxy)image2).IsLoaded ? "LOADED" : "NOT LOADED")}");
        Console.WriteLine($"Image 3: {(((ImageProxy)image3).IsLoaded ? "LOADED" : "NOT LOADED")}");

        Console.WriteLine("\n=== SUMMARY ===");
        Console.WriteLine("Only image 2 was loaded because only it was displayed.");
        Console.WriteLine("Images 1 and 3 remain unloaded - saving resources!");
    }
}
