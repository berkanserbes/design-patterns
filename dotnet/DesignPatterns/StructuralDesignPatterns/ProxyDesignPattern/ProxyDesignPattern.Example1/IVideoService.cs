namespace ProxyDesignPattern.Example1;

/// <summary>
/// Subject Interface - Defines operations for the video streaming service.
/// </summary>
public interface IVideoService
{
    Video? GetVideoInfo(string videoId);
    void StreamVideo(string videoId);
}
