namespace ProxyDesignPattern.Example1;

/// <summary>
/// VIRTUAL PROXY - Implements lazy loading for video content.
/// Video info is loaded immediately, but actual content is loaded only when streaming starts.
/// </summary>
public class VirtualProxy : IVideoService
{
    private readonly IVideoService _realService;
    private readonly Dictionary<string, Video> _loadedVideos = new();

    public VirtualProxy(IVideoService realService)
    {
        _realService = realService;
    }

    public Video? GetVideoInfo(string videoId)
    {
        // Video info is lightweight, fetch it immediately
        return _realService.GetVideoInfo(videoId);
    }

    public void StreamVideo(string videoId)
    {
        // Check if video content is already loaded
        if (_loadedVideos.ContainsKey(videoId))
        {
            Console.WriteLine($"[VirtualProxy] Video already loaded, reusing content");
            return;
        }

        // Lazy load: Only load video content when actually needed
        Console.WriteLine($"[VirtualProxy] First time access - loading video content lazily");
        _realService.StreamVideo(videoId);
        
        var video = _realService.GetVideoInfo(videoId);
        if (video != null)
        {
            _loadedVideos[videoId] = video;
        }
    }
}
