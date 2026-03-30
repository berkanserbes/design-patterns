package structural.proxy.example1;

import java.util.HashMap;
import java.util.Map;

public class RealVideoService implements IVideoService {
    private final Map<String, Video> videoDatabase;

    public RealVideoService() {
        videoDatabase = new HashMap<>();
        videoDatabase.put("V001", new Video("V001", "Introduction to Design Patterns", false));
        videoDatabase.put("V002", new Video("V002", "Advanced Java Techniques", true));
        videoDatabase.put("V003", new Video("V003", "SOLID Principles Explained", false));
        videoDatabase.put("V004", new Video("V004", "Microservices Architecture", true));
    }

    @Override
    public Video getVideoInfo(String videoId) {
        System.out.println("[RealService] Fetching video info for: " + videoId);
        return videoDatabase.get(videoId);
    }

    @Override
    public void streamVideo(String videoId) {
        System.out.println("[RealService] Loading video content from server...");
        try { Thread.sleep(1000); } catch (InterruptedException e) { Thread.currentThread().interrupt(); }
        Video video = videoDatabase.get(videoId);
        if (video != null) {
            video.setContent("[Binary video data for '" + video.getTitle() + "']");
            System.out.println("[RealService] Streaming: " + video.getTitle());
            System.out.println("[RealService] Content loaded successfully");
        }
    }
}
