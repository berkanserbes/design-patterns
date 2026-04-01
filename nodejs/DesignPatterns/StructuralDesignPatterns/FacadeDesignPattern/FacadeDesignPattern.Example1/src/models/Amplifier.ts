export class Amplifier {
  on(): void { console.log('Amplifier is turned on.'); }
  off(): void { console.log('Amplifier is turned off.'); }
  setVolume(level: number): void { console.log(`Amplifier volume is set to ${level}.`); }
}
