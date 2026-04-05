import { IChatMediator } from './IChatMediator';

export abstract class User {
  protected mediator: IChatMediator;
  readonly name: string;

  constructor(mediator: IChatMediator, name: string) {
    this.mediator = mediator;
    this.name = name;
  }

  abstract send(message: string): void;
  abstract sendPrivate(message: string, receiver: User): void;
  abstract receive(message: string, sender: User): void;
}
