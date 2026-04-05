export class Article {
  readonly title: string;
  readonly content: string;
  readonly publishedAt: Date;

  constructor(title: string, content: string) {
    this.title = title;
    this.content = content;
    this.publishedAt = new Date();
  }
}
