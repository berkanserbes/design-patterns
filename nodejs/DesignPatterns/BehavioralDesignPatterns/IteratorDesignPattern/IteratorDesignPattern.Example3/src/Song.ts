export class Song {
  constructor(
    public readonly id: string,
    public readonly title: string,
    public readonly artist: string,
    public readonly album: string,
    public readonly durationSeconds: number,
    public readonly genre: string
  ) {}

  toString(): string {
    const min = Math.floor(this.durationSeconds / 60)
      .toString()
      .padStart(2, "0");
    const sec = (this.durationSeconds % 60).toString().padStart(2, "0");
    return `${this.title} - ${this.artist} (${min}:${sec})`;
  }
}
