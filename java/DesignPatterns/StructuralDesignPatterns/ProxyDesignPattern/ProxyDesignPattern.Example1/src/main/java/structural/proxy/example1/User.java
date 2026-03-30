package structural.proxy.example1;

public class User {
    private final String name;
    private final SubscriptionType subscription;

    public User(String name, SubscriptionType subscription) {
        this.name = name;
        this.subscription = subscription;
    }

    public String getName() { return name; }
    public SubscriptionType getSubscription() { return subscription; }
}
