package behavioral.iterator.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Iterator Pattern - Book Collection ===\n");

        BookCollection collection = new BookCollection();
        collection.addBook(new Book("Clean Code", "Robert C. Martin", 2008));
        collection.addBook(new Book("Design Patterns", "Gang of Four", 1994));
        collection.addBook(new Book("The Pragmatic Programmer", "Andrew Hunt", 1999));

        IIterator<Book> iterator = collection.createIterator();
        System.out.println("Iterating through books:");
        while (iterator.hasNext()) {
            System.out.println("  " + iterator.next());
        }

        iterator.reset();
        System.out.println("\nAfter reset - iterating again:");
        while (iterator.hasNext()) {
            System.out.println("  " + iterator.next());
        }
    }
}
