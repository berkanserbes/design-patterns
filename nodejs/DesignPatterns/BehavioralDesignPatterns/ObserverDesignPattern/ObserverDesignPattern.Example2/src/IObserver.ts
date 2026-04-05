export interface IObserver {
  update(temperature: number, humidity: number, pressure: number): void;
}
