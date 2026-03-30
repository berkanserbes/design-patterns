package behavioral.mediator.example4;

import java.util.*;

public class ChatRoom implements IChatMediator {
    private final Map<String, User> users = new LinkedHashMap<>();

    @Override
    public void registerUser(User user) {
        users.put(user.getName(), user);
        System.out.println("[ChatRoom] " + user.getName() + " joined the room.");
    }

    @Override
    public void sendMessage(String message, User sender) {
        for (User u : users.values()) {
            if (u != sender) {
                u.receive("[" + sender.getName() + "]: " + message);
            }
        }
    }

    @Override
    public void sendPrivateMessage(String message, User sender, String recipientName) {
        User recipient = users.get(recipientName);
        if (recipient != null) {
            recipient.receive("[Private from " + sender.getName() + "]: " + message);
        } else {
            System.out.println("[ChatRoom] User '" + recipientName + "' not found.");
        }
    }
}
