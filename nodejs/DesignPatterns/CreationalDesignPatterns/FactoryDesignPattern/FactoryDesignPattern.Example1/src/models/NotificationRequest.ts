import { NotificationType } from '../enums/NotificationType';

export interface NotificationRequest {
  to: string;
  message: string;
  notificationType: NotificationType;
}
