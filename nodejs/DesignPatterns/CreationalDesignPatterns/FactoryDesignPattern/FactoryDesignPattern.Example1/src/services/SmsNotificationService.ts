import { INotificationService } from './INotificationService';

export class SmsNotificationService implements INotificationService {
  send(to: string, message: string): string {
    const result = `Sending SMS to ${to} with message: ${message}`;
    console.log(result);
    return result;
  }
}
