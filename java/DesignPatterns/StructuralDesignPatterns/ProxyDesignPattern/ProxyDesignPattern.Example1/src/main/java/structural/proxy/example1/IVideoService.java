package structural.proxy.example1;

public interface IVideoService {
    Video getVideoInfo(String videoId);
    void streamVideo(String videoId);
}
