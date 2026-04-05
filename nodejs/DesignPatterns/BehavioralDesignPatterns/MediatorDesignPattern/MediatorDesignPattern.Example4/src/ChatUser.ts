import { User } from './User';
import { IChatMediator } from './IChatMediator';

export class ChatUser extends User {
  constructor(mediator: IChatMediator, name: string) {
    super(mediator, name);
  }

  send(message: string): void {
    console.log(`[${this.name}] Sending: ${message}`);
    this.mediator.sendMessage(message, this);
  }

  sendPrivate(message: string, receiver: User): void {
    console.log(`[${this.name}] Sending private to ${receiver.name}: ${message}`);
    this.mediator.sendPrivateMessage(message, this, receiver);
  }

  receive(message: string, sender: User): void {
    console.log(`[${this.name}] Received from ${sender.name}: ${message}`);
  }
}
