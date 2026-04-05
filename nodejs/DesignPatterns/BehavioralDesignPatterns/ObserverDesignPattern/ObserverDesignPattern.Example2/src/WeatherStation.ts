import { ISubject } from './ISubject';
import { IObserver } from './IObserver';

export class WeatherStation implements ISubject {
  private readonly _observers: IObserver[] = [];
  private _temperature: number = 0;
  private _humidity: number = 0;
  private _pressure: number = 0;

  registerObserver(observer: IObserver): void {
    this._observers.push(observer);
    console.log(`New observer added. Total: ${this._observers.length}`);
  }

  removeObserver(observer: IObserver): void {
    const index = this._observers.indexOf(observer);
    if (index !== -1) {
      this._observers.splice(index, 1);
      console.log(`Observer removed. Total: ${this._observers.length}`);
    }
  }

  notifyObservers(): void {
    for (const observer of this._observers) {
      observer.update(this._temperature, this._humidity, this._pressure);
    }
  }

  setMeasurements(temperature: number, humidity: number, pressure: number): void {
    this._temperature = temperature;
    this._humidity = humidity;
    this._pressure = pressure;
    this.notifyObservers();
  }

  getTemperature(): number { return this._temperature; }
  getHumidity(): number { return this._humidity; }
  getPressure(): number { return this._pressure; }
}
