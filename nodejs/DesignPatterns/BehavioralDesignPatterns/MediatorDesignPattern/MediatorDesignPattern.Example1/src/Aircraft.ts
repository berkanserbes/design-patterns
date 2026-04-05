import { IMediator } from './IMediator';

export abstract class Aircraft {
  protected mediator: IMediator;
  readonly callSign: string;
  readonly aircraftType: string;

  constructor(mediator: IMediator, callSign: string, aircraftType: string) {
    this.mediator = mediator;
    this.callSign = callSign;
    this.aircraftType = aircraftType;
  }

  abstract send(message: string): void;
  abstract receive(message: string): void;
  abstract requestLanding(): void;
  abstract requestTakeoff(): void;
}
