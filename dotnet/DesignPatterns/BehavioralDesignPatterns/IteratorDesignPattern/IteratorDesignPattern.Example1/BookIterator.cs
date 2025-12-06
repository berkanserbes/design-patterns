namespace IteratorDesignPattern.Example1;

public class BookIterator : IIterator<Book>
{
    private readonly BookCollection _collection;
    private int _currentIndex = 0;

    public BookIterator(BookCollection collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _currentIndex < _collection.Count;
    }

    public Book Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("No more books in collection.");
        }

        return _collection[_currentIndex++];
    }

    public Book Current => _collection[_currentIndex];

    public void Reset()
    {
        _currentIndex = 0;
    }
}
