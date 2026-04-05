import { Book } from "./Book";
import { BookCollection } from "./BookCollection";
import { IIterator } from "./Interfaces";

export class BookIterator implements IIterator<Book> {
  private _currentIndex = 0;

  constructor(private readonly _collection: BookCollection) {}

  hasNext(): boolean {
    return this._currentIndex < this._collection.count;
  }

  next(): Book {
    if (!this.hasNext()) {
      throw new Error("No more books in collection.");
    }
    return this._collection.getAt(this._currentIndex++);
  }

  current(): Book {
    return this._collection.getAt(this._currentIndex);
  }

  reset(): void {
    this._currentIndex = 0;
  }
}
