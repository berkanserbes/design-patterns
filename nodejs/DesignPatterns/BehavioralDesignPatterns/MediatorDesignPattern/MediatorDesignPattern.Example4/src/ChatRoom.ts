import { IChatMediator } from './IChatMediator';
import { User } from './User';

export class ChatRoom implements IChatMediator {
  private readonly _users: User[] = [];
  private readonly _roomName: string;

  constructor(roomName: string) {
    this._roomName = roomName;
    console.log(`[CHAT ROOM] '${this._roomName}' created.`);
  }

  registerUser(user: User): void {
    this._users.push(user);
    console.log(`[CHAT ROOM] ${user.name} joined the room.`);
  }

  sendMessage(message: string, sender: User): void {
    for (const user of this._users.filter(u => u !== sender)) {
      user.receive(message, sender);
    }
  }

  sendPrivateMessage(message: string, sender: User, receiver: User): void {
    if (this._users.includes(receiver)) {
      receiver.receive(`[Private] ${message}`, sender);
    } else {
      console.log(`[CHAT ROOM] User ${receiver.name} is not in the room.`);
    }
  }
}
