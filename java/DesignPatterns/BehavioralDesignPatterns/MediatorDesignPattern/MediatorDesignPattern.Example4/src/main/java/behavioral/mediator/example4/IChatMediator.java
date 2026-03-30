package behavioral.mediator.example4;

public interface IChatMediator {
    void registerUser(User user);
    void sendMessage(String message, User sender);
    void sendPrivateMessage(String message, User sender, String recipientName);
}
