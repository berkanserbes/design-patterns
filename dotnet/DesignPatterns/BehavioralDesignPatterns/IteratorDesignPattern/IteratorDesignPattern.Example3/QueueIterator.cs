namespace IteratorDesignPattern.Example3;

public class QueueIterator : IIterator<Song>
{
    private readonly List<Song> _songs;
    private int _currentIndex = 0;

    public QueueIterator(PlayQueue playQueue)
    {
        _songs = playQueue.GetQueue().ToList();
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
