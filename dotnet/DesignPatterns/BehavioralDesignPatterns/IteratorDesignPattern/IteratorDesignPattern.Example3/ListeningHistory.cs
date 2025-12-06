namespace IteratorDesignPattern.Example3;

public class ListeningHistory : IAggregate<Song>
{
    private readonly Stack<Song> _history = new();

    public void AddToHistory(Song song)
    {
        _history.Push(song);
    }

    public Stack<Song> GetHistory() => _history;

    public IIterator<Song> CreateIterator()
    {
        return new HistoryIterator(this);
    }
}
