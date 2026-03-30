package behavioral.iterator.example1;

public class BookIterator implements IIterator<Book> {
    private final BookCollection collection;
    private int currentIndex = 0;

    public BookIterator(BookCollection collection) { this.collection = collection; }

    @Override
    public boolean hasNext() { return currentIndex < collection.getCount(); }

    @Override
    public Book next() { return collection.get(currentIndex++); }

    @Override
    public Book getCurrent() { return collection.get(currentIndex); }

    @Override
    public void reset() { currentIndex = 0; }
}
