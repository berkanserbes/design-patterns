using IteratorDesignPattern.Example1;

Console.WriteLine("Iterator Design Pattern - Example 1: Book Collection\n");

var bookCollection = new BookCollection();
bookCollection.AddBook(new Book("Clean Code", "Robert C. Martin", 2008));
bookCollection.AddBook(new Book("Design Patterns", "Gang of Four", 1994));
bookCollection.AddBook(new Book("The Pragmatic Programmer", "Andrew Hunt", 1999));

var iterator = bookCollection.CreateIterator();

Console.WriteLine("Books in collection:");
while (iterator.HasNext())
{
    var book = iterator.Next();
    Console.WriteLine($"- {book}");
}

Console.WriteLine("\nIterating again after reset:");
iterator.Reset();
while (iterator.HasNext())
{
    var book = iterator.Next();
    Console.WriteLine($"- {book}");
}
