import { Aircraft } from './Aircraft';
import { IMediator } from './IMediator';

export class CargoAircraft extends Aircraft {
  constructor(mediator: IMediator, callSign: string) {
    super(mediator, callSign, 'Cargo');
  }

  send(message: string): void {
    console.log(`[${this.callSign}] Sending: ${message}`);
    this.mediator.sendMessage(message, this);
  }

  receive(message: string): void {
    console.log(`[${this.callSign}] Received: ${message}`);
  }

  requestLanding(): void {
    console.log(`[${this.callSign}] Requesting landing clearance...`);
    this.mediator.requestLanding(this);
  }

  requestTakeoff(): void {
    console.log(`[${this.callSign}] Requesting takeoff clearance...`);
    this.mediator.requestTakeoff(this);
  }
}
