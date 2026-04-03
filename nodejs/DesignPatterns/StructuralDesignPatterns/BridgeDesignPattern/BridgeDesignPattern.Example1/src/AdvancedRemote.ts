import { IDevice } from './IDevice';
import { Remote } from './Remote';

export class AdvancedRemote extends Remote {
  constructor(device: IDevice) { super(device); }

  mute(): void {
    if (this.device.isEnabled) this.device.volume = 0;
  }
}
