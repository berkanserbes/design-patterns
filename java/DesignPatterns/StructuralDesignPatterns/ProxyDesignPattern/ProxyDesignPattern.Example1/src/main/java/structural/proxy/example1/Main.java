package structural.proxy.example1;

public class Main {
    public static void main(String[] args) {
        RealVideoService realService = new RealVideoService();
        VirtualProxy virtualProxy = new VirtualProxy(realService);
        ProtectionProxy protectionProxy = new ProtectionProxy(virtualProxy, new User("John", SubscriptionType.FREE));
        CachingProxy cachingProxy = new CachingProxy(protectionProxy);
        LoggingProxy loggingProxy = new LoggingProxy(cachingProxy);
        IVideoService videoService = loggingProxy;

        System.out.println("SCENARIO 1: Free user watching a FREE video");
        System.out.println("--------------------------------------------\n");
        Video video = videoService.getVideoInfo("V001");
        System.out.println("\nVideo: " + (video != null ? video.getTitle() : "null"));
        System.out.println("Premium: " + (video != null ? video.isPremium() : "null") + "\n");
        videoService.streamVideo("V001");

        System.out.println("\n\n=======================================================");
        System.out.println("SCENARIO 2: Free user trying to watch PREMIUM video");
        System.out.println("--------------------------------------------\n");
        video = videoService.getVideoInfo("V002");
        System.out.println("\nVideo: " + (video != null ? video.getTitle() : "null"));
        System.out.println("Premium: " + (video != null ? video.isPremium() : "null") + "\n");
        videoService.streamVideo("V002");

        System.out.println("\n\n=======================================================");
        System.out.println("SCENARIO 3: Premium user watching PREMIUM video");
        System.out.println("--------------------------------------------\n");
        ProtectionProxy premiumProtection = new ProtectionProxy(virtualProxy, new User("Alice", SubscriptionType.PREMIUM));
        CachingProxy premiumCaching = new CachingProxy(premiumProtection);
        LoggingProxy premiumLogging = new LoggingProxy(premiumCaching);
        IVideoService premiumService = premiumLogging;

        video = premiumService.getVideoInfo("V002");
        System.out.println("\nVideo: " + (video != null ? video.getTitle() : "null"));
        System.out.println("Premium: " + (video != null ? video.isPremium() : "null") + "\n");
        premiumService.streamVideo("V002");

        System.out.println("\n\n=======================================================");
        System.out.println("SCENARIO 4: Caching in action");
        System.out.println("--------------------------------------------\n");
        System.out.println("Requesting same video info again...\n");
        video = premiumService.getVideoInfo("V002");
        System.out.println("\nVideo: " + (video != null ? video.getTitle() : "null") + " (served from cache!)\n");

        System.out.println("=======================================================");
        System.out.println("SUMMARY\n");
        System.out.println("1. VIRTUAL PROXY    - Delayed video content loading");
        System.out.println("2. PROTECTION PROXY - Blocked free user from premium content");
        System.out.println("3. CACHING PROXY    - Cached video info on second request");
        System.out.println("4. LOGGING PROXY    - Logged all service calls");
    }
}
