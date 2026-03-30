package structural.proxy.example1;

import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;

public class LoggingProxy implements IVideoService {
    private final IVideoService innerService;
    private final List<String> logs = new ArrayList<>();

    public LoggingProxy(IVideoService innerService) {
        this.innerService = innerService;
    }

    @Override
    public Video getVideoInfo(String videoId) {
        String timestamp = LocalTime.now().format(DateTimeFormatter.ofPattern("HH:mm:ss"));
        logs.add("[" + timestamp + "] getVideoInfo called for: " + videoId);
        System.out.println("[LoggingProxy] Logging: getVideoInfo(" + videoId + ")");
        return innerService.getVideoInfo(videoId);
    }

    @Override
    public void streamVideo(String videoId) {
        String timestamp = LocalTime.now().format(DateTimeFormatter.ofPattern("HH:mm:ss"));
        logs.add("[" + timestamp + "] streamVideo called for: " + videoId);
        System.out.println("[LoggingProxy] Logging: streamVideo(" + videoId + ")");
        innerService.streamVideo(videoId);
    }

    public void printLogs() {
        System.out.println("\n--- Activity Logs ---");
        for (String log : logs) System.out.println(log);
        System.out.println("---------------------");
    }
}
