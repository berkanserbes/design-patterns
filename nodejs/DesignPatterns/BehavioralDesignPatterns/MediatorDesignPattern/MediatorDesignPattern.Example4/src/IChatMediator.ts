import { User } from './User';

export interface IChatMediator {
  registerUser(user: User): void;
  sendMessage(message: string, sender: User): void;
  sendPrivateMessage(message: string, sender: User, receiver: User): void;
}
