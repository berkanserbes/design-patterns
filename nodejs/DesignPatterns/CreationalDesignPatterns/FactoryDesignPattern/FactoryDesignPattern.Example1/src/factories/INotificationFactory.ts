import { NotificationType } from '../enums/NotificationType';
import { INotificationService } from '../services/INotificationService';

export interface INotificationFactory {
  create(notificationType: NotificationType): INotificationService;
}
