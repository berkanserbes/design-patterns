import { ISubject } from './ISubject';
import { IObserver } from './IObserver';
import { Article } from './Article';

export class Author implements ISubject<Article> {
  readonly name: string;
  private readonly _followers: IObserver<Article>[] = [];

  constructor(name: string) {
    this.name = name;
  }

  subscribe(observer: IObserver<Article>): void {
    if (!this._followers.includes(observer)) {
      this._followers.push(observer);
    }
  }

  unsubscribe(observer: IObserver<Article>): void {
    const index = this._followers.indexOf(observer);
    if (index !== -1) {
      this._followers.splice(index, 1);
    }
  }

  notify(article: Article): void {
    for (const follower of this._followers) {
      follower.update(article);
    }
  }

  publishArticle(title: string, content: string): void {
    const article = new Article(title, content);
    console.log(`${this.name} published a new article: ${title}`);
    this.notify(article);
  }
}
