import { INotificationService } from './INotificationService';

export class EmailNotificationService implements INotificationService {
  send(to: string, message: string): string {
    const result = `Sending Email to ${to} with message: ${message}`;
    console.log(result);
    return result;
  }
}
