package structural.proxy.example1;

import java.util.HashMap;
import java.util.Map;

public class VirtualProxy implements IVideoService {
    private final IVideoService realService;
    private final Map<String, Video> loadedVideos = new HashMap<>();

    public VirtualProxy(IVideoService realService) {
        this.realService = realService;
    }

    @Override
    public Video getVideoInfo(String videoId) {
        return realService.getVideoInfo(videoId);
    }

    @Override
    public void streamVideo(String videoId) {
        if (loadedVideos.containsKey(videoId)) {
            System.out.println("[VirtualProxy] Video already loaded, reusing content");
            return;
        }
        System.out.println("[VirtualProxy] First time access - loading video content lazily");
        realService.streamVideo(videoId);
        Video video = realService.getVideoInfo(videoId);
        if (video != null) loadedVideos.put(videoId, video);
    }
}
