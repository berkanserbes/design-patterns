package behavioral.mediator.example4;

public class ChatUser extends User {
    public ChatUser(IChatMediator mediator, String name) { super(mediator, name); }

    @Override
    public void send(String message) {
        System.out.println("[" + name + "] -> Group: " + message);
        mediator.sendMessage(message, this);
    }

    @Override
    public void sendPrivate(String message, String recipientName) {
        System.out.println("[" + name + "] -> @" + recipientName + " (private): " + message);
        mediator.sendPrivateMessage(message, this, recipientName);
    }

    @Override
    public void receive(String message) {
        System.out.println("[" + name + "] Received: " + message);
    }
}
