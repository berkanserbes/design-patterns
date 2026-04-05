import { IObserver } from './IObserver';
import { ISubject } from './ISubject';

export class ForecastDisplay implements IObserver {
  private _currentPressure: number = 1013.0;
  private _lastPressure: number = 1013.0;
  private readonly _weatherStation: ISubject;

  constructor(weatherStation: ISubject) {
    this._weatherStation = weatherStation;
    this._weatherStation.registerObserver(this);
  }

  update(_temperature: number, _humidity: number, pressure: number): void {
    this._lastPressure = this._currentPressure;
    this._currentPressure = pressure;
    this.display();
  }

  display(): void {
    process.stdout.write('🔮 Weather Forecast: ');
    if (this._currentPressure > this._lastPressure) {
      console.log('Improving!');
    } else if (this._currentPressure === this._lastPressure) {
      console.log('No change.');
    } else {
      console.log('Bad weather incoming.');
    }
  }
}
