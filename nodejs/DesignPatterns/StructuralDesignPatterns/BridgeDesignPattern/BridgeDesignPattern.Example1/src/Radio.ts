import { IDevice } from './IDevice';

export class Radio implements IDevice {
  isEnabled = false;
  volume = 5;
  channel = 88;
  enable(): void { this.isEnabled = true; }
  disable(): void { this.isEnabled = false; }
}
