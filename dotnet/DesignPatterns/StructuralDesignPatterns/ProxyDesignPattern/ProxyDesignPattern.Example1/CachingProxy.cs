namespace ProxyDesignPattern.Example1;

/// <summary>
/// CACHING PROXY - Caches video metadata to reduce server calls.
/// </summary>
public class CachingProxy : IVideoService
{
    private readonly IVideoService _innerService;
    private readonly Dictionary<string, Video> _cache = new();

    public CachingProxy(IVideoService innerService)
    {
        _innerService = innerService;
    }

    public Video? GetVideoInfo(string videoId)
    {
        // Check cache first
        if (_cache.TryGetValue(videoId, out var cachedVideo))
        {
            Console.WriteLine($"[CachingProxy] Cache HIT for video: {videoId}");
            return cachedVideo;
        }

        // Cache miss - fetch from service
        Console.WriteLine($"[CachingProxy] Cache MISS for video: {videoId}");
        var video = _innerService.GetVideoInfo(videoId);
        
        if (video != null)
        {
            _cache[videoId] = video;
            Console.WriteLine($"[CachingProxy] Video info cached: {videoId}");
        }

        return video;
    }

    public void StreamVideo(string videoId)
    {
        _innerService.StreamVideo(videoId);
    }
}
