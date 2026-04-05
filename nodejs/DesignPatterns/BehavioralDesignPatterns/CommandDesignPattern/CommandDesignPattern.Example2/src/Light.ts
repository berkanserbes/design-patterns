/**
 * Receiver — The light device.
 */
export class Light {
  constructor(private readonly _location: string) {}

  turnOn(): void {
    console.log(`${this._location} light turned on.`);
  }

  turnOff(): void {
    console.log(`${this._location} light turned off.`);
  }

  increaseBrightness(): void {
    console.log(`${this._location} light brightness increased.`);
  }

  decreaseBrightness(): void {
    console.log(`${this._location} light brightness decreased.`);
  }
}
