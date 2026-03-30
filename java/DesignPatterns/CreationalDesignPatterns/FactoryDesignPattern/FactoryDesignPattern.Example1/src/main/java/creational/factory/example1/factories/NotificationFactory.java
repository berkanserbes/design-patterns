package creational.factory.example1.factories;

import creational.factory.example1.enums.NotificationType;
import creational.factory.example1.services.abstracts.INotificationService;
import creational.factory.example1.services.concretes.*;

public class NotificationFactory {
    public INotificationService create(NotificationType type) {
        return switch (type) {
            case EMAIL              -> new EmailNotificationService();
            case SMS                -> new SmsNotificationService();
            case PUSH_NOTIFICATION  -> new PushNotificationService();
        };
    }
}
