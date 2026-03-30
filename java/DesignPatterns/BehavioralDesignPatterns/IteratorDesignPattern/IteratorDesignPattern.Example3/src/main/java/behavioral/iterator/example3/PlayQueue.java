package behavioral.iterator.example3;

import java.util.*;

public class PlayQueue implements IAggregate<Song> {
    private final Queue<Song> queue = new ArrayDeque<>();

    public void enqueue(Song song) { queue.add(song); }
    public Queue<Song> getQueue() { return queue; }

    @Override
    public IIterator<Song> createIterator() { return new QueueIterator(this); }
}
