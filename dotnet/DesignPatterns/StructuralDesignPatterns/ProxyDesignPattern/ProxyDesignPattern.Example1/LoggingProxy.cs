namespace ProxyDesignPattern.Example1;

/// <summary>
/// LOGGING PROXY - Logs all video service operations for analytics.
/// </summary>
public class LoggingProxy : IVideoService
{
    private readonly IVideoService _innerService;
    private readonly List<string> _logs = new();

    public LoggingProxy(IVideoService innerService)
    {
        _innerService = innerService;
    }

    public Video? GetVideoInfo(string videoId)
    {
        var timestamp = DateTime.Now.ToString("HH:mm:ss");
        _logs.Add($"[{timestamp}] GetVideoInfo called for: {videoId}");
        Console.WriteLine($"[LoggingProxy] Logging: GetVideoInfo({videoId})");
        
        return _innerService.GetVideoInfo(videoId);
    }

    public void StreamVideo(string videoId)
    {
        var timestamp = DateTime.Now.ToString("HH:mm:ss");
        _logs.Add($"[{timestamp}] StreamVideo called for: {videoId}");
        Console.WriteLine($"[LoggingProxy] Logging: StreamVideo({videoId})");
        
        _innerService.StreamVideo(videoId);
    }

    public void PrintLogs()
    {
        Console.WriteLine("\n--- Activity Logs ---");
        foreach (var log in _logs)
        {
            Console.WriteLine(log);
        }
        Console.WriteLine("---------------------");
    }
}
