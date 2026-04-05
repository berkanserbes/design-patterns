import { NotificationType } from '../enums/NotificationType';
import { INotificationFactory } from './INotificationFactory';
import { INotificationService } from '../services/INotificationService';
import { EmailNotificationService } from '../services/EmailNotificationService';
import { SmsNotificationService } from '../services/SmsNotificationService';
import { PushNotificationService } from '../services/PushNotificationService';

export class NotificationFactory implements INotificationFactory {
  create(notificationType: NotificationType): INotificationService {
    switch (notificationType) {
      case NotificationType.Email:
        return new EmailNotificationService();
      case NotificationType.Sms:
        return new SmsNotificationService();
      case NotificationType.PushNotification:
        return new PushNotificationService();
      default:
        throw new Error(`Invalid notification type: ${notificationType}`);
    }
  }
}
