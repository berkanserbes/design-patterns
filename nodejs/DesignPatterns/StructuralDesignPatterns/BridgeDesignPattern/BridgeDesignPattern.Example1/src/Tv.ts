import { IDevice } from './IDevice';

export class Tv implements IDevice {
  isEnabled = false;
  volume = 10;
  channel = 1;
  enable(): void { this.isEnabled = true; }
  disable(): void { this.isEnabled = false; }
}
