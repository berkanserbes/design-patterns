export class Book {
  constructor(
    public readonly title: string,
    public readonly author: string,
    public readonly year: number
  ) {}

  toString(): string {
    return `${this.title} - ${this.author} (${this.year})`;
  }
}
