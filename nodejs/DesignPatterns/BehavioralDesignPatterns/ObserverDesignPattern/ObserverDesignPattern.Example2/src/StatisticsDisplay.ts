import { IObserver } from './IObserver';
import { ISubject } from './ISubject';

export class StatisticsDisplay implements IObserver {
  private _maxTemp: number = -Infinity;
  private _minTemp: number = Infinity;
  private _tempSum: number = 0;
  private _numReadings: number = 0;
  private readonly _weatherStation: ISubject;

  constructor(weatherStation: ISubject) {
    this._weatherStation = weatherStation;
    this._weatherStation.registerObserver(this);
  }

  update(temperature: number, _humidity: number, _pressure: number): void {
    this._tempSum += temperature;
    this._numReadings++;

    if (temperature > this._maxTemp) this._maxTemp = temperature;
    if (temperature < this._minTemp) this._minTemp = temperature;

    this.display();
  }

  display(): void {
    const avgTemp = this._tempSum / this._numReadings;
    console.log(
      `📊 Statistics - Avg: ${avgTemp.toFixed(1)}°C, Max: ${this._maxTemp.toFixed(1)}°C, Min: ${this._minTemp.toFixed(1)}°C`
    );
  }
}
