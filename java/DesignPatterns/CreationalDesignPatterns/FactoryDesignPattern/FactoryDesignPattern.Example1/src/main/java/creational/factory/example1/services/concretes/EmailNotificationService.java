package creational.factory.example1.services.concretes;

import creational.factory.example1.services.abstracts.INotificationService;

public class EmailNotificationService implements INotificationService {
    public String send(String to, String message) {
        String result = "Sending Email to " + to + " with message: " + message;
        System.out.println(result);
        return result;
    }
}
