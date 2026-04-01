import { Projector } from './models/Projector';
import { Amplifier } from './models/Amplifier';
import { DvdPlayer } from './models/DvdPlayer';
import { Lights } from './models/Lights';

export class HomeTheaterFacade {
  constructor(
    private readonly projector: Projector,
    private readonly amplifier: Amplifier,
    private readonly dvdPlayer: DvdPlayer,
    private readonly lights: Lights,
  ) {}

  watchMovie(movie: string): void {
    console.log('\n--- Starting Movie Mode ---');
    this.lights.dim();
    this.projector.on();
    this.projector.setWideScreenMode();
    this.amplifier.on();
    this.amplifier.setVolume(10);
    this.dvdPlayer.on();
    this.dvdPlayer.play(movie);
  }

  endMovie(): void {
    console.log('\n--- Shutting Down Movie Mode ---');
    this.dvdPlayer.stop();
    this.dvdPlayer.off();
    this.amplifier.off();
    this.projector.off();
    this.lights.on();
  }
}
