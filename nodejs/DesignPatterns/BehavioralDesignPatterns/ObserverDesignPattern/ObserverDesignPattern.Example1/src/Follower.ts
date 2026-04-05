import { IObserver } from './IObserver';
import { Article } from './Article';

export class Follower implements IObserver<Article> {
  readonly name: string;
  readonly email: string;

  constructor(name: string, email: string) {
    this.name = name;
    this.email = email;
  }

  update(article: Article): void {
    console.log(`Email sent to ${this.email}: '${article.title}' by author at ${article.publishedAt.toISOString()}`);
  }
}
