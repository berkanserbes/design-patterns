package behavioral.mediator.example4;

public abstract class User {
    protected IChatMediator mediator;
    protected final String name;

    public User(IChatMediator mediator, String name) {
        this.mediator = mediator;
        this.name = name;
    }

    public String getName() { return name; }

    public abstract void send(String message);
    public abstract void sendPrivate(String message, String recipientName);
    public abstract void receive(String message);
}
