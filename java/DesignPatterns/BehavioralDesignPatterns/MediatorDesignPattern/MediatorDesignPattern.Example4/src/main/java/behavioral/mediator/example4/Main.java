package behavioral.mediator.example4;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Mediator Pattern - Chat Room ===\n");

        ChatRoom chatRoom = new ChatRoom();

        User alice = new ChatUser(chatRoom, "Alice");
        User bob = new ChatUser(chatRoom, "Bob");
        User charlie = new ChatUser(chatRoom, "Charlie");

        System.out.println("--- Design Patterns Discussion Room ---");
        chatRoom.registerUser(alice);
        chatRoom.registerUser(bob);
        chatRoom.registerUser(charlie);

        System.out.println();
        alice.send("Has anyone implemented the Observer pattern before?");
        System.out.println();
        bob.send("Yes! I used it for event handling in my last project.");
        System.out.println();
        alice.sendPrivate("Bob, can you share your implementation?", "Bob");
        System.out.println();
        charlie.send("I think Strategy pattern is more flexible.");
    }
}
