namespace ProxyDesignPattern.Example1;

/// <summary>
/// PROTECTION PROXY - Controls access based on user subscription.
/// Free users cannot access premium content.
/// </summary>
public class ProtectionProxy : IVideoService
{
    private readonly IVideoService _innerService;
    private readonly User _currentUser;

    public ProtectionProxy(IVideoService innerService, User currentUser)
    {
        _innerService = innerService;
        _currentUser = currentUser;
    }

    public Video? GetVideoInfo(string videoId)
    {
        // Everyone can see video info
        return _innerService.GetVideoInfo(videoId);
    }

    public void StreamVideo(string videoId)
    {
        var video = _innerService.GetVideoInfo(videoId);
        
        if (video == null)
        {
            Console.WriteLine($"[ProtectionProxy] Video not found: {videoId}");
            return;
        }

        // Check if user has access to premium content
        if (video.IsPremium && _currentUser.Subscription == SubscriptionType.Free)
        {
            Console.WriteLine($"[ProtectionProxy] ACCESS DENIED: '{_currentUser.Name}' needs Premium subscription");
            Console.WriteLine($"[ProtectionProxy] Upgrade to Premium to watch: {video.Title}");
            return;
        }

        Console.WriteLine($"[ProtectionProxy] Access granted for user: {_currentUser.Name}");
        _innerService.StreamVideo(videoId);
    }
}
