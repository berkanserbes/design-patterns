export interface IDevice {
  isEnabled: boolean;
  volume: number;
  channel: number;
  enable(): void;
  disable(): void;
}
