namespace IteratorDesignPattern.Example3;

public class PlayQueue : IAggregate<Song>
{
    private readonly Queue<Song> _queue = new();

    public void Enqueue(Song song)
    {
        _queue.Enqueue(song);
    }

    public Queue<Song> GetQueue() => _queue;

    public IIterator<Song> CreateIterator()
    {
        return new QueueIterator(this);
    }
}
