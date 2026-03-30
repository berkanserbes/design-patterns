package creational.factory.example1;

import creational.factory.example1.enums.NotificationType;
import creational.factory.example1.factories.NotificationFactory;
import creational.factory.example1.services.abstracts.INotificationService;

public class Main {
    public static void main(String[] args) {
        NotificationFactory factory = new NotificationFactory();

        INotificationService emailService = factory.create(NotificationType.EMAIL);
        emailService.send("user@example.com", "Hello via Email!");

        INotificationService smsService = factory.create(NotificationType.SMS);
        smsService.send("+905001234567", "Hello via SMS!");

        INotificationService pushService = factory.create(NotificationType.PUSH_NOTIFICATION);
        pushService.send("device-token-123", "Hello via Push!");
    }
}
