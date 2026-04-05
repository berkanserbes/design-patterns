import { Book } from "./Book";
import { IAggregate, IIterator } from "./Interfaces";
import { BookIterator } from "./BookIterator";

export class BookCollection implements IAggregate<Book> {
  private readonly _books: Book[] = [];

  addBook(book: Book): void {
    this._books.push(book);
  }

  get count(): number {
    return this._books.length;
  }

  getAt(index: number): Book {
    return this._books[index];
  }

  createIterator(): IIterator<Book> {
    return new BookIterator(this);
  }
}
