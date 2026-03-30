package behavioral.iterator.example1;

import java.util.ArrayList;
import java.util.List;

public class BookCollection implements IAggregate<Book> {
    private final List<Book> books = new ArrayList<>();

    public void addBook(Book book) { books.add(book); }
    public int getCount() { return books.size(); }
    public Book get(int index) { return books.get(index); }

    @Override
    public IIterator<Book> createIterator() { return new BookIterator(this); }
}
