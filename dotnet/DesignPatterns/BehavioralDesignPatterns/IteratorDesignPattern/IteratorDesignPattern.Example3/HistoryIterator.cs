namespace IteratorDesignPattern.Example3;

public class HistoryIterator : IIterator<Song>
{
    private readonly List<Song> _songs;
    private int _currentIndex = 0;

    public HistoryIterator(ListeningHistory history)
    {
        _songs = history.GetHistory().ToList();
    }

    public bool HasNext()
    {
        return _currentIndex < _songs.Count;
    }

    public Song Next()
    {
        return _songs[_currentIndex++];
    }

    public void Reset()
    {
        _currentIndex = 0;
    }
}
