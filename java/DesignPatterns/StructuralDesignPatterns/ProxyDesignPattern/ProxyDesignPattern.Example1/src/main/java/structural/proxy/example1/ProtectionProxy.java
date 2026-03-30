package structural.proxy.example1;

public class ProtectionProxy implements IVideoService {
    private final IVideoService innerService;
    private final User currentUser;

    public ProtectionProxy(IVideoService innerService, User currentUser) {
        this.innerService = innerService;
        this.currentUser = currentUser;
    }

    @Override
    public Video getVideoInfo(String videoId) {
        return innerService.getVideoInfo(videoId);
    }

    @Override
    public void streamVideo(String videoId) {
        Video video = innerService.getVideoInfo(videoId);
        if (video == null) {
            System.out.println("[ProtectionProxy] Video not found: " + videoId);
            return;
        }
        if (video.isPremium() && currentUser.getSubscription() == SubscriptionType.FREE) {
            System.out.println("[ProtectionProxy] ACCESS DENIED: '" + currentUser.getName() + "' needs Premium subscription");
            System.out.println("[ProtectionProxy] Upgrade to Premium to watch: " + video.getTitle());
            return;
        }
        System.out.println("[ProtectionProxy] Access granted for user: " + currentUser.getName());
        innerService.streamVideo(videoId);
    }
}
