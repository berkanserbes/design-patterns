// ============================================================================
// ITERATOR DESIGN PATTERN - Example 1: Book Collection
// ============================================================================
// Iterator provides a way to sequentially access elements of a collection
// without exposing its underlying representation.
//
// Pattern Structure:
//   - IIterator<T>: Iterator interface (hasNext, next, current, reset)
//   - IAggregate<T>: Aggregate interface (createIterator)
//   - BookIterator: Concrete Iterator
//   - BookCollection: Concrete Aggregate
// ============================================================================

import { Book } from "./Book";
import { BookCollection } from "./BookCollection";

console.log("Iterator Design Pattern - Example 1: Book Collection\n");

const bookCollection = new BookCollection();
bookCollection.addBook(new Book("Clean Code", "Robert C. Martin", 2008));
bookCollection.addBook(new Book("Design Patterns", "Gang of Four", 1994));
bookCollection.addBook(new Book("The Pragmatic Programmer", "Andrew Hunt", 1999));

const iterator = bookCollection.createIterator();

console.log("Books in collection:");
while (iterator.hasNext()) {
  const book = iterator.next();
  console.log(`- ${book}`);
}

console.log("\nIterating again after reset:");
iterator.reset();
while (iterator.hasNext()) {
  const book = iterator.next();
  console.log(`- ${book}`);
}
