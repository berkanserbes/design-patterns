export class DvdPlayer {
  on(): void { console.log('DVD player is turned on.'); }
  off(): void { console.log('DVD player is turned off.'); }
  play(movie: string): void { console.log(`Playing movie: '${movie}'.`); }
  stop(): void { console.log('Movie playback stopped.'); }
}
