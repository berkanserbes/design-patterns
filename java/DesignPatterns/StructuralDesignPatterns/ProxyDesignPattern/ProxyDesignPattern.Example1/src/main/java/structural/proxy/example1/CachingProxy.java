package structural.proxy.example1;

import java.util.HashMap;
import java.util.Map;

public class CachingProxy implements IVideoService {
    private final IVideoService innerService;
    private final Map<String, Video> cache = new HashMap<>();

    public CachingProxy(IVideoService innerService) {
        this.innerService = innerService;
    }

    @Override
    public Video getVideoInfo(String videoId) {
        if (cache.containsKey(videoId)) {
            System.out.println("[CachingProxy] Cache HIT for video: " + videoId);
            return cache.get(videoId);
        }
        System.out.println("[CachingProxy] Cache MISS for video: " + videoId);
        Video video = innerService.getVideoInfo(videoId);
        if (video != null) {
            cache.put(videoId, video);
            System.out.println("[CachingProxy] Video info cached: " + videoId);
        }
        return video;
    }

    @Override
    public void streamVideo(String videoId) {
        innerService.streamVideo(videoId);
    }
}
