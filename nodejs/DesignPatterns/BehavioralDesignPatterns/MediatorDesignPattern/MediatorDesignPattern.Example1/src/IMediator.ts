import { Aircraft } from './Aircraft';

export interface IMediator {
  registerAircraft(aircraft: Aircraft): void;
  sendMessage(message: string, sender: Aircraft): void;
  requestLanding(aircraft: Aircraft): void;
  requestTakeoff(aircraft: Aircraft): void;
}
