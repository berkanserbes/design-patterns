namespace ProxyDesignPattern.Example1;

/// <summary>
/// RealSubject - The actual video streaming service.
/// Contains the real implementation that accesses the video database.
/// </summary>
public class RealVideoService : IVideoService
{
    private readonly Dictionary<string, Video> _videoDatabase;

    public RealVideoService()
    {
        // Simulated video database
        _videoDatabase = new Dictionary<string, Video>
        {
            { "V001", new Video("V001", "Introduction to Design Patterns", false) },
            { "V002", new Video("V002", "Advanced C# Techniques", true) },
            { "V003", new Video("V003", "SOLID Principles Explained", false) },
            { "V004", new Video("V004", "Microservices Architecture", true) }
        };
    }

    public Video? GetVideoInfo(string videoId)
    {
        Console.WriteLine($"[RealService] Fetching video info for: {videoId}");
        
        if (_videoDatabase.TryGetValue(videoId, out var video))
        {
            return video;
        }
        
        return null;
    }

    public void StreamVideo(string videoId)
    {
        Console.WriteLine($"[RealService] Loading video content from server...");
        Thread.Sleep(1000); // Simulate network latency

        if (_videoDatabase.TryGetValue(videoId, out var video))
        {
            video.Content = $"[Binary video data for '{video.Title}']";
            Console.WriteLine($"[RealService] Streaming: {video.Title}");
            Console.WriteLine($"[RealService] Content loaded successfully");
        }
    }
}
