import { IObserver } from './IObserver';
import { ISubject } from './ISubject';

export class CurrentConditionsDisplay implements IObserver {
  private _temperature: number = 0;
  private _humidity: number = 0;
  private readonly _weatherStation: ISubject;

  constructor(weatherStation: ISubject) {
    this._weatherStation = weatherStation;
    this._weatherStation.registerObserver(this);
  }

  update(temperature: number, humidity: number, _pressure: number): void {
    this._temperature = temperature;
    this._humidity = humidity;
    this.display();
  }

  display(): void {
    console.log(`🌡️  Current Conditions: ${this._temperature}°C, Humidity: ${this._humidity}%`);
  }
}
