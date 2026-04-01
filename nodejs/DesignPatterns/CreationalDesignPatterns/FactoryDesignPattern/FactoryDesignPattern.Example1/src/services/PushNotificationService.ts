import { INotificationService } from './INotificationService';

export class PushNotificationService implements INotificationService {
  send(to: string, message: string): string {
    const result = `Sending Push Notification to ${to} with message: ${message}`;
    console.log(result);
    return result;
  }
}
