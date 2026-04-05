import { IDevice } from './IDevice';

export class Remote {
  constructor(protected readonly device: IDevice) {}

  togglePower(): void {
    if (this.device.isEnabled) this.device.disable();
    else this.device.enable();
  }

  volumeUp(): void { if (this.device.volume < 100) this.device.volume++; }
  volumeDown(): void { if (this.device.volume > 0) this.device.volume--; }
  channelUp(): void { this.device.channel++; }
  channelDown(): void { if (this.device.channel > 1) this.device.channel--; }
}
